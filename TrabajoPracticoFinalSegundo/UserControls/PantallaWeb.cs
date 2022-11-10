using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TrabajoPracticoFinalSegundo.UserControls
{
    public partial class PantallaWeb : UserControl
    {
        string path;
        
        public PantallaWeb()
        {
            InitializeComponent();

            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();
        }

        public void WebLoad()
        {
            pictureBox1.Image = Image.FromFile(this.path + @".\Recursos\Iconos\LogoEjemplo.png");
        }

        public void RecibirFrame(string imagen) 
        {
            Bitmap frame = Base64StringToBitmap(imagen);
            pictureBox1.Image = frame;
        }

        public string DarFrame() 
        {
            using (MemoryStream m = new MemoryStream())
            {
                Image image = pictureBox1.Image;
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                MessageBox.Show(base64String);
                return base64String;
            }
        }

        public void CargarAvatar(Image avatar) 
        {
            this.pictureBox1.Image = avatar;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        //CONVIERTE STRING 64 A BITMAL
        public static Bitmap Base64StringToBitmap(string base64String)
        {
            Bitmap bmpReturn = null;


            byte[] byteBuffer = Convert.FromBase64String(base64String);
            MemoryStream memoryStream = new MemoryStream(byteBuffer);


            memoryStream.Position = 0;


            bmpReturn = (Bitmap)Bitmap.FromStream(memoryStream);


            memoryStream.Close();
            memoryStream = null;
            byteBuffer = null;


            return bmpReturn;
        }
    }
}
