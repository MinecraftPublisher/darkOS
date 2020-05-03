using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace Swapcoin_Node
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Miner = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkMagenta;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "0 SWP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkMagenta;
            this.label2.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(12, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "2020 (C) Swapcoin Node";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Swapcoin_Node.Properties.Resources.pi;
            this.pictureBox2.Location = new System.Drawing.Point(260, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Miner
            // 
            this.Miner.Interval = 200;
            this.Miner.Tick += new System.EventHandler(this.Miner_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkMagenta;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Tomato;
            this.richTextBox1.Location = new System.Drawing.Point(12, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(242, 431);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Swapcoin Node";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(318, 520);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(334, 558);
            this.MinimumSize = new System.Drawing.Size(334, 558);
            this.Name = "Form1";
            this.Text = "Swapcoin Node";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer Miner;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string value = "0";
      
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\Users\Public\SwapNode\Mined.MD5"))
            {
                File.WriteAllText(@"C:\Users\Public\SwapNode\Mined.MD5", "0");
                label1.Text = value + " SWP";
            }
            else
            {
                value = File.ReadAllText(@"C:\Users\Public\SwapNode\Mined.MD5");
                label1.Text = value + " SWP";
            }

            Directory.CreateDirectory(@"C:\Users\Public\SwapNode");
            WebClient wc = new WebClient();
            Uri url = new Uri("https://raw.githubusercontent.com/MinecraftPublisher/miner/master/news.md5");
            richTextBox1.Text = wc.DownloadString(url);
            Uri image=new Uri("https://www.microsoft.com/favicon.ico");
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted1;
            wc.DownloadFile(image,"img.ico");
            this.Opacity = 100;
            this.ShowInTaskbar = true;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Miner.Enabled = true;
        }

        private void Miner_Tick(object sender, EventArgs e)
        {
            if(new Random().Next(0,20) == 0)
            {
                int mined = int.Parse(value) + new Random().Next(1, 3);
                value = mined.ToString();
                File.WriteAllText(@"C:\Users\Public\SwapNode\Mined.MD5", value);
                label1.Text = value + " SWP";
            }
        }

        private void Wc_DownloadFileCompleted1(object sender, AsyncCompletedEventArgs e)
        {
            pictureBox2.Image = Image.FromFile("img.ico");
        }
        
    }
}
