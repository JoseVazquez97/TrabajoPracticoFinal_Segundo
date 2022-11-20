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
        public Notificador()
        {
            InitializeComponent();
        }

        public void Load_Notificador(int tamaTotal) 
        {
            this.Width = tamaTotal;
            this.Height = 75;
            this.flowLayoutPanel1.Width = tamaTotal;
            this.flowLayoutPanel1.Height = 75;
            this.lbl_texto.Width = this.flowLayoutPanel1.Width;
            this.lbl_texto.Height = this.flowLayoutPanel1.Height;
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
