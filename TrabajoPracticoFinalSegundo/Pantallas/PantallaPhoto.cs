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
        private bool jugarCam;

        public PantallaPhoto()
        {

            InitializeComponent();
            this.comboBox1.SelectedItem = "Capitan";
        }


        #region Hacer el Formulario Arrastrable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormMove_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {   

            frame = new Mat();

            //106 a la derecha y hacia abajo -- 421; 70 posicion inicial
            int x = 421, y = 160, c = 1;
            string path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();
            for (int i = 0; i < 5; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {
                    PictureBox avatar = new PictureBox();
                    avatar.Location = new System.Drawing.Point(x, y);
                    avatar.Name = "avatar" + c;
                    avatar.Size = new System.Drawing.Size(100, 70);
                    avatar.Image = new Bitmap(Image.FromFile(path + @"\Recursos\Avatars\" + avatar.Name + ".png"), new Size(100, 80));
                    avatar.Click += new EventHandler(this.clickAvatar);
                    avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(avatar);
                    c++;
                    y += 106;
                }
                x += 106;
                y = 160;
            }
            

        }

        private void clickAvatar(object sender, EventArgs e)
        {
            this.jugarCam = false;

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
            this.jugarCam = false;


            if (camara != null) camara.Dispose();
            camara = new VideoCapture();
            this.contador = 0;
            camara.Start();
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }
            timer1.Start();
        }

        private void btnJugarConCamara_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.contador++;   
            camara.Read(frame);

            Imagen.Image = new Bitmap(frame.ToBitmap(), new Size(80, 80));
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
            this.jugarCam = false;
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
                Image imagenProcesada = new Bitmap(ImagenRecibida, new Size(80, 80));

                Imagen.Image = imagenProcesada;
            }
        }
        private void TimerCamara_Tick(object sender, EventArgs e)
        {
            camara.Read(frame);
            Imagen.Image = new Bitmap(frame.ToBitmap(), new Size(80, 80));
            this.jugarCam = true;
        }

        private void ConfirmarSeleccion_Click(object sender, EventArgs e)
        {
            Home home = new Home();

            Imagen.Image = new Bitmap(Imagen.Image, new Size(100, 70));
            if (File.Exists(Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString() + @"\Recursos\Avatars\avatar" + comboBox1.Text + ".png"))
                File.Delete(Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString() + @"\Recursos\Avatars\avatar" + comboBox1.Text + ".png");
            Imagen.Image.Save(Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString() + @"\Recursos\Avatars\avatar" + comboBox1.Text + ".png");
            Imagen.Image = Image.FromFile(Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString() + @"\Recursos\Avatars\avatar" + comboBox1.Text + ".png");

            home.AsignarAvatar(this.Imagen.Image,this.comboBox1.Text,this.jugarCam);
            home.Show();

            //this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}