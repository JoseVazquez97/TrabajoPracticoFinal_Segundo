using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;

namespace TrabajoPracticoFinalSegundo.Pantallas
{
    public partial class PantallaPhoto : Form
    {
        private VideoCapture camara;
        private Mat frame;

        public PantallaPhoto()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            camara = new VideoCapture();
            

            frame = new Mat();
        }


        private void btnEncender_Click(object sender, EventArgs e)
        {
 
            camara.Start();
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }
            timer1.Start();
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            camara.Stop();
            pictureBox1.Image = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            camara.Read(frame);

            pictureBox1.Image = frame.ToBitmap();

        }
    }
}