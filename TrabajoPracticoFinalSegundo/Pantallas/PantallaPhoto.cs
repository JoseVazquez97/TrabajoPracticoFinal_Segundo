namespace TrabajoPracticoFinalSegundo.Pantallas
{
    public partial class PantallaPhoto : Form
    {
        //private VideoCapture camara;
        //private Mat frame;
        //private int contador;
        //private bool jugarCam;


        private string pathAvatar;
        Home home;

        public PantallaPhoto()
        {
            this.BackgroundImage = Image.FromFile(@"./Recursos/Fondos/Madera.jpg");
            InitializeComponent();
            this.comboBox1.SelectedItem = "Capitan";
            this.pathAvatar = @".\Recursos\Avatars\avatar1.png";
            this.Imagen.Image = Image.FromFile(pathAvatar);
            home = new Home();
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
            for (int c = 1; c <= 15; c++)
            {
                PictureBox avatar = new PictureBox();
                avatar.Name = "avatar" + c;
                avatar.Size = new System.Drawing.Size(100, 100);
                avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
                avatar.Image = new Bitmap(Image.FromFile(@".\Recursos\Avatars\" + avatar.Name + ".png"), new Size(100, 80));
                avatar.Click += new EventHandler(this.clickAvatar);
                avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.fpl_avatars.Controls.Add(avatar);
            }
        }

        private void clickAvatar(object sender, EventArgs e)
        {
            //this.jugarCam = false;

            object pictureBox = new PictureBox();
            if (sender.GetType() == pictureBox.GetType())
            {
                PictureBox avatarClickeado = sender as PictureBox;
                string path = @".\Recursos\Avatars\";
                Imagen.Image = Image.FromFile(path + avatarClickeado.Name + ".png");
                pathAvatar = path + avatarClickeado.Name + ".png";
            }
        }

        #region Legacy

        /*LEGACY CAMARA WEB
         * 
         * 
         * 
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
        *
        *
        */

        /*LEGACY FUNCIONES PARA UTILIZAR LA CAMARA WEB
         * 
         * 
         * 
         * 
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

        *
        *
        *
        *
        */

        #endregion
        private void PantallaPhoto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ConfirmarSeleccion_Click(object sender, EventArgs e)
        {
            Intro x = new Intro();
            
            /*
             * 
             * ESTA ES LA FORMA FINAL DE CARGA
             * NECESITO QUE SE CAMBIE LO QUE RECIBE
             * EL CONSTRUCTOR DEL FORMULARIO HOME.
             * 
            home.AsignarAvatar(pathAvatar, this.comboBox1.Text);
            x.Show();
            home.Show();
            this.Dispose();
            */

            try
            {
                Imagen.Image = new Bitmap(Imagen.Image, new Size(100, 70));
                if (File.Exists(@".\Recursos\Avatars\avatar" + comboBox1.Text + ".png"))
                    File.Delete(@".\Recursos\Avatars\avatar" + comboBox1.Text + ".png");
                Imagen.Image.Save(@".\Recursos\Avatars\avatar" + comboBox1.Text + ".png");
                Imagen.Image = Image.FromFile(@".\Recursos\Avatars\avatar" + comboBox1.Text + ".png");

                home.AsignarAvatar(this.Imagen.Image, this.comboBox1.Text, false); //Se cambio de this.jugarCam a false, (ES MEJOR QUE ESTO SEA QUITADO LUEGO)
                x.Show();
                home.Show();
                this.Dispose();
            }
            catch { MessageBox.Show("El rol ya esta ocupado."); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}