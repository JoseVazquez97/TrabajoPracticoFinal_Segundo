using TrabajoPracticoFinalSegundo.Pantallas;
using System.IO;
using Emgu.CV.Dnn;
using Emgu.CV.Face;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using TrabajoPracticoFinalSegundo.Clases;

namespace TrabajoPracticoFinalSegundo
{
    public partial class Ingreso : Form
    {
        string path;
        PantallaPhoto pp;
        public Ingreso()
        {
            InitializeComponent();

            this.BackgroundImage = Image.FromFile(@"./Recursos/Fondos/FONDO_Ingreso.jpg");
            Intro intro = new Intro(this);
            intro.Show();
            this.pp = new PantallaPhoto();
            pp.Show();
            pp.Visible = false;
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            pp.Visible = true;
            this.Hide();
        }

        private void btn_Host_Click(object sender, EventArgs e)
        {

            //System.Diagnostics.Process.Start(@"C:\Users\JVazquez\source\repos\TrabajoPracticoFinal_Segundo\WebApi_SingalR_Com\bin\Debug\net6.0\WebApi_SignalR_Com.exe");
            /*
            Pantalla_Host x = new Pantalla_Host();
            x.Show();

            this.Hide();
            */
        }

        private void btn_Unirse_Click(object sender, EventArgs e)
        {
            Pantalla_Unirme x = new Pantalla_Unirme();
            x.Show();
            this.Hide();
        }

        private void btnDeveloper_Click(object sender, EventArgs e)
        {
            string path1 = @".\Recursos\Avatars\avatar1.png";
            string path2 = @".\Recursos\Avatars\avatar2.png";
            string path3 = @".\Recursos\Avatars\avatar3.png";
            string path4 = @".\Recursos\Avatars\avatar4.png";

            Home home1, home2, home3, home4;

            home1 = new Home();
            home2 = new Home();
            home3 = new Home();
            home4 = new Home();

            Intro x = new Intro(6);
            x.Show();            
            

            home1.AsignarAvatar(path1, "Capitan");
            home1.Show();
            home2.AsignarAvatar(path2, "Carpintero");
            home2.Show();
            home3.AsignarAvatar(path3, "Mercader");
            home3.Show();
            home4.AsignarAvatar(path4, "Artillero");
            home4.Show();


            this.Hide();
        }
    }
}