using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TouchLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (Directory.Exists("res"))
                foreach (string i in Directory.EnumerateFiles("res", "*.png"))
                    this.comboBox2.Items.Add(i);
        }

        private String get_rgb(PictureBox p)
        {
            return $"{p.BackColor.R},{p.BackColor.G},{p.BackColor.B}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] res = comboBox1.Text.Split('x');
            String s = $"-w{res[0]} -h{res[1]}";
            if (checkBox1.Checked)
                s += " -fs";
            s += " -z" + textBox1.Text;
            s += " -bg" + get_rgb(pictureBox1);
            s += " -fg" + get_rgb(pictureBox2);
            if (comboBox2.Text != "Default")
                s += " -s" + comboBox2.Text;
            Process.Start("pythonw.exe", "touch.pyw " + s);
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox1.BackColor = colorDialog1.Color;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox2.BackColor = colorDialog1.Color;
        }

    }
}
