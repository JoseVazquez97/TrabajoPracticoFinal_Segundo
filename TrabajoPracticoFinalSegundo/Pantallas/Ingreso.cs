using TrabajoPracticoFinalSegundo.Pantallas;

namespace TrabajoPracticoFinalSegundo
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            /*
            Intro intro = new Intro(this);
            intro.Show();
            */

            Home h = new Home();
            h.Show();

            this.Hide();
        }

        private void btn_Host_Click(object sender, EventArgs e)
        {
            Pantalla_Host x = new Pantalla_Host();
            x.Show();

            this.Hide();
        }

        private void btn_Unirse_Click(object sender, EventArgs e)
        {
            Pantalla_Unirme x = new Pantalla_Unirme();
            x.Show();

            this.Hide();
        }
    }
}