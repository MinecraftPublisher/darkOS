using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Diagnostics;

namespace Swapcoin_Node
{
    static class Program
    {
        [DllImport("user32.dll")]

      public static extern IntPtr FindWindow(string lpClassName,string lpWindowName);

 

      [DllImport("user32.dll")]

      static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        static void Main()
        {
             Console.Title="Node";
            
         IntPtr hWnd = FindWindow(null, "Node"); 

         if(hWnd != IntPtr.Zero)

         {

            

            ShowWindow(hWnd, 0); 

         }

 

                  

 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    partial class Form1
    {
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


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Miner = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Advertizment = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Advertizment)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(258, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "0 Swapcoin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkMagenta;
            this.label2.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(12, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "This Is Safe!";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(260, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start\nMining";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.pictureBox2_Click);
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
            // 
            // Advertizment
            // 
            this.Advertizment.Location = new System.Drawing.Point(260, 134);
            this.Advertizment.Name = "Advertizment";
            this.Advertizment.Size = new System.Drawing.Size(161, 326);
            this.Advertizment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Advertizment.TabIndex = 6;
            this.Advertizment.TabStop = false;
            this.Advertizment.Click += new System.EventHandler(this.Advertizment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Swap Ads";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(434, 581);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Advertizment);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(450, 619);
            this.MinimumSize = new System.Drawing.Size(450, 619);
            this.Name = "Form1";
            this.Text = "Swapcoin Node";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Advertizment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer Miner;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private PictureBox Advertizment;
        private Label label3;
        private System.Windows.Forms.Timer timer1;

        private void Advertizment_Click(object sender, EventArgs e)
        {
            Process.Start("http://minecraftpublisher.github.io");
        }
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
        string value = "100";

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\Users\Public\SwapNode\Mined.MD5"))
            {
                Directory.CreateDirectory(@"C:\Users\Public\SwapNode\");
                File.WriteAllText(@"C:\Users\Public\SwapNode\Mined.MD5", "100");
                float toswp = float.Parse(value) / 100;
                label1.Text = toswp.ToString() + " Swapcoin";
            }
            else
            {

                value = File.ReadAllText(@"C:\Users\Public\SwapNode\Mined.MD5");
                if (value == "0") { File.WriteAllText(@"C:\Users\Public\SwapNode\Mined.MD5", "100"); }
                float toswp = float.Parse(value) / 100;
                label1.Text = toswp.ToString() + " Swapcoin";
            }

            Directory.CreateDirectory(@"C:\Users\Public\SwapNode");
            WebClient wc = new WebClient();
            Uri ad = new Uri(wc.DownloadString("https://raw.githubusercontent.com/MinecraftPublisher/darkOS/master/redirect.link"));
            Uri url = new Uri("https://raw.githubusercontent.com/MinecraftPublisher/miner/master/news.md5");
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
            wc.DownloadFileAsync(ad,@"C:\Users\Public\SwapNode\Ad.png");
            //richTextBox1.Text = wc.DownloadString(url);
            richTextBox1.Text = "سلام دوستان\nازتون ممنونیم که تا اینحا ما رو همراهی کردین\nمیخواستم بگم که از این به بعد شما میتونید سواپ کوین های خود تون رو به حسابتون واریز کنین\nاگه حدود 50 سواپ کوین دارید میتونید یه ویدیو از صفحتون بگیرید که برنامه رو باز و بسته میکنید\nبرای تایید\nو بعدش اونرو برای ما بفرستید\nالبته باید اسم کامپیوتر خودتون رو هم وارد کنین\nروی مای کامپیوتر کلیک راست کنید و منیج رو بزنید\nتوی قسمت کامپیوتر نیم یه اسمی هست اونرو به ما بگین\nممنون که تا اینجا مارو همراهی کردین";
            this.Opacity = 100;
            this.ShowInTaskbar = true;
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Image img = Image.FromFile(@"C:\Users\Public\SwapNode\Ad.png");
            Advertizment.Image = img;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Miner.Enabled = true;
        }

        private void Miner_Tick(object sender, EventArgs e)
        {
            ///<Summary>
            ///This Code Is Supposed To Mine Swapcoin.
            ///<Summary>
            if (new Random().Next(0, 3) == 0)
            {
                float mined = float.Parse(value) + 1;
                float mining = mined / 100;
                value = mined.ToString();
                File.WriteAllText(@"C:\Users\Public\SwapNode\Mined.MD5", value);
                label1.Text = mining.ToString() + " Swapcoin";
            }
        }


    }
}
