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
using System.Media;

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
            pictarget.ImageLocation = @"C:\Users\User\source\repos\ImageToText\ImageToText\img\testim.jpg";
            
            automatic();

        }
        public void automatic()
        {
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                string plainText = objOcr.GetTextFromImage(pictarget.ImageLocation);
                txtOutput.Text = plainText;
               
            }
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
            /*for (int i=0; i<6; i++)
            {
                t.Show();
            }*/
           
        }

        private void cboCamera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\User\source\repos\ImageToText\ImageToText\img\alarm.wav");

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean check = false;
            do
            {
               // MessageBox.Show(txtOutput.Text);
                check = true;
                int value = Convert.ToInt32(txtOutput.Text);
                if(value > 100)
                {
                    label1.Visible = true;
                    button3.Visible = true;
                    button2.Enabled = false;
                    button1.Enabled = false;
                    btnEnter.Enabled = false;
                    btnCamera.Enabled = false;
                   
                    simpleSound.PlayLooping();
                }
            } while (check == false);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            label1.Visible = false;
            button3.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            btnEnter.Enabled = true;
            btnCamera.Enabled = true;
        }
    }
}
