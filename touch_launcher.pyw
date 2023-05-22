from tkinter import *
from tkinter import ttk

RES = '1400x900', '1200x900', '800x600', '500x400'
STYLES = 'Default', 'Checker1', 'Checker2', 'Char?'

root = Tk()
frm = ttk.Frame(root, padding=5)
frm.grid()

cb_res = ttk.Combobox(frm, values=RES)
cb_res.set('800x600')

cb_styles = ttk.Combobox(frm, values=STYLES)
cb_styles.set('Default')

e_zoom = ttk.Entry(frm)
e_zoom.insert(0, '1')

col = 0
row = 0

for i in [
    ttk.Label(frm, text='Res'),
    cb_res,
    ttk.Label(frm, text='Style'),
    cb_styles,
    ttk.Label(frm, text='Zoom'),
    e_zoom,
    ttk.Button(frm, text='Quit', command=root.destroy)
]:
    if col == 2:
        col = 0
        row += 1
    i.grid(column=col, row=row, pady=5)
    col += 1

root.mainloop()