using TrabajoPracticoFinalSegundo.Pantallas;
using System.IO;
using Emgu.CV.Dnn;
using Emgu.CV.Face;
using System.Diagnostics;

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
            pp.WindowState = FormWindowState.Maximized;
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
    }
}