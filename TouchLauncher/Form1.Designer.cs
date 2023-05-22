using System.Drawing;
using System.IO;

namespace TouchLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_Res = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_FS = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Zoom = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_BG = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_FG = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Style = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Sequence = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FG)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(15, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Res
            // 
            this.comboBox_Res.FormattingEnabled = true;
            this.comboBox_Res.Items.AddRange(new object[] {
            "1400x900",
            "1200x900",
            "800x600",
            "500x400"});
            this.comboBox_Res.Location = new System.Drawing.Point(80, 6);
            this.comboBox_Res.Name = "comboBox_Res";
            this.comboBox_Res.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Res.TabIndex = 3;
            this.comboBox_Res.Tag = "";
            this.comboBox_Res.Text = "800x600";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Res";
            // 
            // checkBox_FS
            // 
            this.checkBox_FS.AutoSize = true;
            this.checkBox_FS.Location = new System.Drawing.Point(80, 151);
            this.checkBox_FS.Name = "checkBox_FS";
            this.checkBox_FS.Size = new System.Drawing.Size(29, 17);
            this.checkBox_FS.TabIndex = 4;
            this.checkBox_FS.Text = " ";
            this.checkBox_FS.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zoom";
            // 
            // textBox_Zoom
            // 
            this.textBox_Zoom.Location = new System.Drawing.Point(80, 87);
            this.textBox_Zoom.Name = "textBox_Zoom";
            this.textBox_Zoom.Size = new System.Drawing.Size(100, 20);
            this.textBox_Zoom.TabIndex = 6;
            this.textBox_Zoom.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "BG";
            // 
            // pictureBox_BG
            // 
            this.pictureBox_BG.BackColor = System.Drawing.Color.Black;
            this.pictureBox_BG.Location = new System.Drawing.Point(80, 113);
            this.pictureBox_BG.Name = "pictureBox_BG";
            this.pictureBox_BG.Size = new System.Drawing.Size(15, 13);
            this.pictureBox_BG.TabIndex = 8;
            this.pictureBox_BG.TabStop = false;
            this.pictureBox_BG.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "FG";
            // 
            // pictureBox_FG
            // 
            this.pictureBox_FG.BackColor = System.Drawing.Color.White;
            this.pictureBox_FG.Location = new System.Drawing.Point(80, 132);
            this.pictureBox_FG.Name = "pictureBox_FG";
            this.pictureBox_FG.Size = new System.Drawing.Size(15, 13);
            this.pictureBox_FG.TabIndex = 10;
            this.pictureBox_FG.TabStop = false;
            this.pictureBox_FG.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Style";
            // 
            // comboBox_Style
            // 
            this.comboBox_Style.FormattingEnabled = true;
            this.comboBox_Style.Items.AddRange(new object[] {
            "Default",
            "Char?"});
            this.comboBox_Style.Location = new System.Drawing.Point(80, 33);
            this.comboBox_Style.Name = "comboBox_Style";
            this.comboBox_Style.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Style.TabIndex = 12;
            this.comboBox_Style.Text = "default";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sequence";
            // 
            // comboBox_Sequence
            // 
            this.comboBox_Sequence.FormattingEnabled = true;
            this.comboBox_Sequence.Items.AddRange(new object[] {
            "digits",
            "ascii_lowercase",
            "ascii_uppercase",
            "hiragana",
            "katakana"});
            this.comboBox_Sequence.Location = new System.Drawing.Point(80, 60);
            this.comboBox_Sequence.Name = "comboBox_Sequence";
            this.comboBox_Sequence.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Sequence.TabIndex = 14;
            this.comboBox_Sequence.Text = "digits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fullscreen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(353, 234);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Sequence);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_Style);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox_FG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox_BG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Zoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_FS);
            this.Controls.Add(this.comboBox_Res);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Touch Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_Res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_FS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Zoom;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_BG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox_FG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Style;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Sequence;
        private System.Windows.Forms.Label label7;
    }
}

