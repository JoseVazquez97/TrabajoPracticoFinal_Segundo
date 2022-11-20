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
    public partial class Notificador : UserControl
    {
        string path;

        public Notificador()
        {
            InitializeComponent();
        }

        public void Load_Notificador(int tamaTotal) 
        {
            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();
            this.BackgroundImage = Image.FromFile(this.path + @"\Recursos\Fondos\Notificador.png");
            this.Width = tamaTotal;
            this.Height = 75;
            this.lbl_texto.Width = tamaTotal;
            this.lbl_texto.Height = 75;
        }
            
        public void Mensaje(string texto) 
        {
            this.lbl_texto.Text = texto;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
