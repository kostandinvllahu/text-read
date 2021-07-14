using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarrenLee.Media;
using System.IO;
using System.Drawing.Imaging;

namespace ImageToText
{
    public partial class TakePicture : Form
    {
        Camera myCamera = new Camera();
        public TakePicture()
        {
            Boolean startTime = false;
            InitializeComponent();
            GetInfo();
            myCamera.OnFrameArrived += myCamera_onFrameArrived;
        }

        private void myCamera_onFrameArrived(object source, FrameArrivedEventArgs e)
        {
            Image img = e.GetFrame();
            pictureBox1.Image = img;
        }

        private void GetInfo()
        {
            var cameraDevice = myCamera.GetCameraSources();
            var cameraResolution = myCamera.GetSupportedResolutions();

            foreach (var d in cameraDevice)
            {
                comboBox1.Items.Add(d);
            }
            foreach (var r in cameraResolution)
            {
                comboBox2.Items.Add(r);
            }

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void TakePicture_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCamera.ChangeCamera(comboBox1.SelectedIndex);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCamera.ChangeCamera(comboBox2.SelectedIndex);
        }

        private void TakePicture_FormClosing(object sender, FormClosingEventArgs e)
        {
            myCamera.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(@"C:\Users\User\source\repos\ImageToText\ImageToText\img"))
                {
                    Directory.CreateDirectory(@"C:\Users\User\source\repos\ImageToText\ImageToText\img");
                    MessageBox.Show("Images folder created!");
                }
                else
                {
                    string path = @"C:\Users\User\source\repos\ImageToText\ImageToText\img";
                    pictureBox1.Image.Save(path + @"\" + textBox1.Text + ".jpg", ImageFormat.Jpeg);

                    Form1 f = new Form1();
                    f.Show();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int i = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           for(i=0; i<6; i++)
            {
                textBox2.Text = i.ToString();
                check();
            }
            
            
        }

        public void check()
        {
           
            if(textBox2.Text == ("5"))
            {
                 timer1.Stop();
                 textBox2.Text = "";
                 timer1.Start();
                automatic();
                 
               
            }
        }
        public void automatic()
        {
            try
            {
                if (!Directory.Exists(@"C:\Users\User\source\repos\ImageToText\ImageToText\img"))
                {
                    Directory.CreateDirectory(@"C:\Users\User\source\repos\ImageToText\ImageToText\img");
                    MessageBox.Show("Images folder created!");
                }
                else
                {
                    string path = @"C:\Users\User\source\repos\ImageToText\ImageToText\img";
                    pictureBox1.Image.Save(path + @"\" + textBox1.Text + ".jpg", ImageFormat.Jpeg);

                    Form1 f = new Form1();
                    f.Show();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                button1.Enabled = false;
                timer1.Start();
                automatic();
                check();

            }
        }

     
    }
}
