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
namespace ImageToText
{
    public partial class Camera : Form
    {


        Camera myCamera = new Camera();
        public Camera()
        {
            InitializeComponent();
            GetInfo();
            myCamera.onFrameArrived += myCamera_onFrameaArrived;
        }

        private void

        private void Camera_Load(object sender, EventArgs e)
        {

        }
    }
}
