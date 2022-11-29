using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrabajoPracticoFinalSegundo.UserControls
{
    public partial class Canon : UserControl
    {

        int danio;
        int nivel;

        public Canon()
        {
            InitializeComponent();

            this.Visible = true;
            this.danio = 0;
            this.nivel = 0;
            this.lbl_Muni.Parent = this.p_Box;
        }

        public void setMuni(string valor) 
        {
            this.lbl_Muni.Text = valor;
            if (valor == "0")
            {
                this.lbl_Muni.Image = Image.FromFile(@".\Recursos\Caniones\Alerta.png");
            }
            else 
            {
                this.lbl_Muni.Image = null;
            }
        }

        public void gastarMuni() 
        {
            this.lbl_Muni.Text = "0";
            this.lbl_Muni.Image = Image.FromFile(@".\Recursos\Caniones\Alerta.png");
        }

        public void regargarMuni() 
        {
            this.lbl_Muni.Text = "1";
            this.lbl_Muni.Image = null;
        }

        public int consultarMuni() 
        {
            return int.Parse(this.lbl_Muni.Text);
        }

        public void subirNivel()
        {
            
        }
        
        public void esDerecho()
        {
            this.p_Box.Image = Image.FromFile(@".\Recursos\Caniones\CanionBase.png");
            this.lbl_Muni.Location = new Point(54, 20);
        }

        public void esIzquierdo() 
        {
            this.p_Box.Image = Image.FromFile(@".\Recursos\Caniones\CanionBaseIzquierdo.png");
            this.lbl_Muni.Location = new Point(54, 20);
        }

        private string UpdatearImagen()
        {
            string path = "";


            return path;
        }

        public string Disparar()
        {
            string path = "";

            return path;
        }

        private void lbl_Muni_Click(object sender, EventArgs e)
        {

        }
    }
}
