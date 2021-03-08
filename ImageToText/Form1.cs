using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patagames.Ocr;
using System.Drawing;


namespace ImageToText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pictarget.ImageLocation = @"C:\Users\User\source\repos\ImageToText\ImageToText\img\testimg.jpg";

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            using(var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                string plainText = objOcr.GetTextFromImage(pictarget.ImageLocation);
                txtOutput.Text = plainText;
            }
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            TakePicture t = new TakePicture();
            //t. this;
            t.Show();
            this.Hide();
        }
    }
}
