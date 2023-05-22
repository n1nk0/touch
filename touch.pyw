import random


WIDTH = 800
HEIGHT = 600
BG = 0, 0, 0
FG = 255, 255, 255
TITLE = 'touch'
FULLSCREEN = False
SQUARE_SIZE = 53
FONT_SIZE = 80
FONT_SIZE_JP = 60
STYLE = ''
SEQUENCE = list('012345678')
SEQUENCE_STYLE = ''
FONT_PATH_JP = 'res/NotoSansJP-VariableFont_wght.ttf'


def colorize(surface, color):
    for x in range(surface.get_width()):
        for y in range(surface.get_height()):
            color.a = surface.get_at((x, y)).a
            surface.set_at((x, y), color)

def is_japanese(c):
    n = ord(c)
    if (0x3040 <= n <= 0x30FF) \
            or (0x3400 <= n <= 0x4DBF) \
            or (0x4E00 <= n <= 0x9FFF) \
            or (0xF900 <= n <= 0xFAFF) \
            or (0xFF66 <= n <= 0xFF9F):
        return True
    else:
        return False


class Grid:
    def __init__(self):
        self.sz = SQUARE_SIZE
        pad = 5
        w = h = w_s = h_s = 0
        self.l = []
        while h < HEIGHT - self.sz:
            w_s = 0
            while w < WIDTH - self.sz:
                self.l.append([w, h])
                w += self.sz + pad
                w_s += 1
            h += self.sz + pad
            h_s += 1
            w = 0

        w_dif = WIDTH - (w_s * self.sz + (w_s - 1) * pad)
        h_dif = HEIGHT - (h_s * self.sz + (h_s - 1) * pad)

        for i in self.l:
            i[0] += w_dif // 2
            i[1] += h_dif // 2

        self.s = pygame.Surface((self.sz, self.sz), pygame.SRCALPHA)

        c = STYLE.replace('Char', '')

        if STYLE.startswith('Char') and len(c) == 1:
            if is_japanese(c):
                font = pygame.font.Font(FONT_PATH_JP, FONT_SIZE_JP)
            else:
                font = pygame.font.Font(None, FONT_SIZE)
            text = font.render(STYLE.replace('Char', ''), True, FG)
            text_rect = text.get_rect()
            text_rect.center = self.sz//2, self.sz//2
            self.s.blit(text, text_rect)
        elif STYLE.endswith('.png'):
            im = pygame.image.load(STYLE)
            im = pygame.transform.scale(im, (self.sz, self.sz))
            self.s.blit(im, (0, 0))
            colorize(self.s, pygame.Color(*FG))
        else:
            pygame.draw.rect(
                self.s, FG, (0, 0, self.sz, self.sz)
            )


    def get_grid(self, n):
        l = []
        for _ in range(n):
            while True:
                s = random.choice(self.l)
                if s not in l:
                    l.append(s)
                    break
        return l


class Frame:
    def __init__(self):
        self.s = pygame.Surface((WIDTH, HEIGHT))
        if SEQUENCE_STYLE == 'hiragana' or SEQUENCE_STYLE == 'katakana':
            self.font = pygame.font.Font(FONT_PATH_JP, FONT_SIZE_JP)
        else:
            self.font = pygame.font.Font(None, FONT_SIZE)

    def w(self, s, x, y):
        text = self.font.render(str(s), True, FG)
        text_rect = text.get_rect()
        text_rect.center = x, y
        self.s.blit(text, text_rect)

    def update(self, state):
        self.s.fill(BG)

        if state.n == len(state.l):
            for n, i in enumerate(state.l):
                self.w(SEQUENCE[n], i[0] + state.grid.sz / 2, i[1] + state.grid.sz / 2)
        else:
            for i in state.l:
                self.s.blit(state.grid.s, i)

        if state.error:
            dif = state.error - pygame.time.get_ticks()
            if dif < 0:
                state.error = 0
            else:
                s = pygame.Surface((WIDTH, HEIGHT))
                alpha = 255 - (255 - ((dif % 1000) * 255 // 1000))
                if alpha > 230:
                    pass
                elif alpha > 200:
                    alpha += 20
                elif alpha > 150:
                    alpha += 10
                s.set_alpha(alpha)
                s.fill((255, 0, 0))
                self.s.blit(s, (0,0))


class State:
    def __init__(self):
        self.grid = Grid()
        self.l = []
        self.n = 3
        self.error = 0
        self.update_l = True
        self.end = False

    def update(self):
        if self.update_l or not self.l and self.n:
            self.l = self.grid.get_grid(self.n)
            self.update_l = False

    def click(self, x, y):
        for i in self.l:
            sz = self.grid.sz
            if i[0] <= x <= i[0] + sz and i[1] <= y <= i[1] + sz:
                if i == self.l[0]:
                    self.l.remove(i)
                else:
                    self.update_l = True
                    self.error = pygame.time.get_ticks() + 1000

    def key(self, k):
        if k == pygame.K_q:
            self.end = True
        k -= ord('0')
        if k < 10 and k > 0 and k != self.n:
            self.n = int(k)
            self.update_l = True


class Game:
    def __init__(self):
        pygame.init()
        pygame.display.set_caption(TITLE)
        if FULLSCREEN:
            s = pygame.display.Info()
            global WIDTH, HEIGHT
            WIDTH, HEIGHT = s.current_w, s.current_h
            self.win = pygame.display.set_mode((WIDTH, HEIGHT), pygame.FULLSCREEN)
        else:
            self.win = pygame.display.set_mode((WIDTH, HEIGHT))
        self.state = State()
        self._frame = Frame()

    def events(self):
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                self.state.end = True

            if event.type == pygame.MOUSEBUTTONDOWN and event.button == 1:
                self.state.click(*pygame.mouse.get_pos())

            if event.type == pygame.KEYUP:
                self.state.key(event.key)

    def frame(self):
        self._frame.update(self.state)
        self.win.blit(self._frame.s, (0,0))
        pygame.display.flip()

    def run(self):
        while not self.state.end:
            self.events()
            self.state.update()
            self.frame()
        pygame.quit()


if __name__ == '__main__':
    import sys
    for i in sys.argv[1:]:
        c = i[0]
        s = i[1:]
        if 'f' == c:
            FULLSCREEN = True
        if 'w' == c:
            s = s.split('x')
            WIDTH = int(s[0])
            HEIGHT = int(s[1])
        if 'z' == c:
            n = float(s)
            FONT_SIZE = int(FONT_SIZE * n)
            FONT_SIZE_JP = int(FONT_SIZE_JP * n)
            SQUARE_SIZE = int(SQUARE_SIZE * n)
        if 'b' == c:
            BG = [int(i) for i in s.split(',')]
        if 'd' == c:
            FG = [int(i) for i in s.split(',')]
        if 's' == c:
            STYLE = s
        if 'e' == c:
            if s == 'ascii_lowercase':
                SEQUENCE = list('abcdefgh')
            elif s == 'ascii_uppercase':
                SEQUENCE = list('ABCDEFGH')
            elif s == 'hiragana':
                SEQUENCE = list('あいうえおかきくけ')
                SEQUENCE_STYLE = s
            elif s == 'katakana':
                SEQUENCE = list('アイウエオカキクケ')
                SEQUENCE_STYLE = s
            elif len(s) > 9:
                SEQUENCE = list(s)
    import pygame
    Game().run()
