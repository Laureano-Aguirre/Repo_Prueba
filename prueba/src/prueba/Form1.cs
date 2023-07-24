using System.IO;
using System;
using System.Diagnostics;

namespace prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Process.Start(AppDomain.CurrentDomain.BaseDirectory+@"images\img-Fondo.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"images/img-Fondo.png"); 
        }
    }
}