using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata;
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
        private int contador;

        public PantallaPhoto()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   

            frame = new Mat();

            //106 a la derecha y hacia abajo -- 421; 70 posicion inicial
            int x = 421, y = 70, c = 1;
            string path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();
            for (int i = 0; i < 5; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {
                    PictureBox avatar = new PictureBox();
                    avatar.Location = new System.Drawing.Point(x, y);
                    avatar.Name = "avatar" + c;
                    avatar.Size = new System.Drawing.Size(100, 70);
                    avatar.Image = resizeImage(Image.FromFile(path + @"\Recursos\Avatars\" + avatar.Name + ".png"), new Size(100, 70));
                    avatar.Click += new EventHandler(this.clickAvatar);
                    avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.Controls.Add(avatar);
                    c++;
                    y += 106;
                }
                x += 106;
                y = 70;
            }
            

        }

        private void clickAvatar(object sender, EventArgs e)
        {
            object pictureBox = new PictureBox();
            if (sender.GetType() == pictureBox.GetType())
            {
                PictureBox avatarClickeado = sender as PictureBox;
                string path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString() + @"\Recursos\Avatars\";
                Imagen.Image = Image.FromFile(path + avatarClickeado.Name + ".png");
            }
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            if(camara != null) camara.Dispose();
            camara = new VideoCapture();
            this.contador = 0;
            camara.Start();
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }
            timer1.Start();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.contador++;   
            camara.Read(frame);

            Imagen.Image = resizeImage(frame.ToBitmap(), Imagen.Size);
            if (contador == 20)
            {
                camara.Stop();
                timer1.Stop();
                camara.Dispose();
            }

        }

        private void PantallaPhoto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_JugarConFoto_Click(object sender, EventArgs e)
        {
            BuscarFoto.ShowDialog();
        }

        private void BuscarFoto_FileOk(object sender, CancelEventArgs e)
        {
            Image ImagenRecibida = Image.FromFile(BuscarFoto.FileName);

            if (ImagenRecibida.Size.Width > 2300 || ImagenRecibida.Size.Height > 1700)
            {
                MessageBox.Show("La imagen tiene que tener el tamaño de 2300x1700 o menor");
            }
            else
            {
                Image imagenProcesada = resizeImage(ImagenRecibida, new Size(230,170));

                Imagen.Image = imagenProcesada;
            }
        }
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
        private void TimerCamara_Tick(object sender, EventArgs e)
        {
            camara.Read(frame);
            Imagen.Image = frame.ToBitmap();
        }

        private void ConfirmarSeleccion_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.AsignarAvatar(this.Imagen.Image,this.comboBox1.Text);
            home.Show();


            /*Cuando este bien decidido, esto prodia hacerse de varias formas*/
            //Home home = new Home(Imagen.Image);
            //home.CargarImagenUsuario(Imagen.Image);  << Prefiero esto personalmente, asi no interfiere, y es facil de sacar de ser necesario
            //home.IniciarVideo(); << Este podria ser si selecciona estar con camara o en vivo

            this.Dispose();
        }
    }
}