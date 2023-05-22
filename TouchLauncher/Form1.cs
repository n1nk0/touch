using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TouchLauncher
{
    public partial class Form1 : Form
    {
        private readonly string cfgPath = "config.txt";
        public Form1()
        {
            InitializeComponent();
            if (Directory.Exists("res"))
                foreach (string i in Directory.EnumerateFiles("res", "*.png"))
                    comboBox_Style.Items.Add(i);
            if (File.Exists(cfgPath))
            {
                using (StreamReader sr = File.OpenText(cfgPath))
                {
                    foreach (string i in sr.ReadLine().Split(' '))
                    {
                        string p = i.Substring(1);
                        char c = i[0];
                        if (c == 'w') comboBox_Res.Text = p;
                        if (c == 'z') textBox_Zoom.Text = p;
                        if (c == 's') comboBox_Style.Text = p;
                        if (c == 'b') pictureBox_BG.BackColor = GetColor(p);
                        if (c == 'd') pictureBox_FG.BackColor = GetColor(p);
                        if (c == 'f') checkBox_FS.Checked = true;
                        if (c == 'e') comboBox_Sequence.Text = p;
                    }
                }
            }
        }

        private string GetRGB(PictureBox p)
        {
            return $"{p.BackColor.R},{p.BackColor.G},{p.BackColor.B}";
        }

        private System.Drawing.Color GetColor(string s)
        {
            string[] x = s.Split(',');
            return System.Drawing.Color.FromArgb(255, int.Parse(x[0]), int.Parse(x[1]), int.Parse(x[2]));
        }

        private string GetCfg()
        {
            string s = String.Empty;
            s += "s" + comboBox_Style.Text;
            s += " w" + comboBox_Res.Text;
            s += " z" + textBox_Zoom.Text;
            s += " b" + GetRGB(pictureBox_BG);
            s += " d" + GetRGB(pictureBox_FG);
            s += " e" + comboBox_Sequence.Text;
            if (checkBox_FS.Checked) s += " f";
            return s;
        }

        private void WriteCfgToFile()
        {
            using (FileStream fs = File.Create(cfgPath))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(GetCfg());
                fs.Write(info, 0, info.Length);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("pythonw.exe", "touch.pyw " + GetCfg());
            WriteCfgToFile();
            Application.Exit();
        }

        private System.Drawing.Color AskColor()
        {
            colorDialog1.ShowDialog();
            return colorDialog1.Color;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox_BG.BackColor = AskColor();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox_FG.BackColor = AskColor();
        }

    }
}
