using Emgu.CV;
using Emgu.CV.DepthAI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TrabajoPracticoFinalSegundo.UserControls
{
    public partial class PantallaWeb : UserControl
    {
        string path;
        private Mat frame;
        private VideoCapture camara;
        private Image imagenActual;
        private bool jugarCam;

        ImageConverter _imageConverter = new ImageConverter();

        public PantallaWeb()
        {
            InitializeComponent();

            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();
            frame = new Mat();
        }

        public void WebLoad()
        {
            pictureBox1.Image = Image.FromFile(this.path + @".\Recursos\Iconos\LogoEjemplo.png");
        }


        public void jugarConCamara(bool x) 
        {
            this.jugarCam = x;
            if (x) 
            {
                this.camara = new VideoCapture();
                this.Camara.Start();
            }
        }

        public void RecibirFrame(string stringimagen) 
        {
           byte[] imgBytes = Convert.FromBase64String(stringimagen);
           
           this.pictureBox1.Image = byteArrayToImage(imgBytes);
            
        }

        public string DarFrame() 
        {
            byte[] arreglo = ImageToByteArray(this.pictureBox1.Image);

            string imagenByte = Convert.ToBase64String(arreglo);
            return imagenByte;
        }

        public void CargarAvatar(Image avatar) 
        {
            this.pictureBox1.Image = avatar;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        #region LA PERDICION
        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            byte[] pepe = { 0};

            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }

            
        }

       
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        #endregion

        static Image resizeImage(Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }

        private void Camara_Tick(object sender, EventArgs e)
        {
            camara.Read(frame);
            imagenActual = resizeImage(frame.ToBitmap(), new Size(10, 10));
            this.pictureBox1.Image = imagenActual;
        }
    }
}
