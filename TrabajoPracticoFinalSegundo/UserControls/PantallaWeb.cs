using Emgu.CV;
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
        ImageConverter _imageConverter = new ImageConverter();

        public PantallaWeb()
        {
            InitializeComponent();

            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();
        }

        public void WebLoad()
        {
            pictureBox1.Image = Image.FromFile(this.path + @".\Recursos\Iconos\LogoEjemplo.png");
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
    }
}
