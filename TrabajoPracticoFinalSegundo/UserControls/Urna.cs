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
    public partial class Urna : UserControl
    {
        int voto;
        string tipo;
        string path;

        public Urna()
        {
            InitializeComponent();
            this.voto = 0;
            this.tipo = "Votacion";
            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();
        }

        #region LOADS
        public void Load_Urna() 
        {
            
        }

        public void Load_Urna(int tamaTotal, int altoTotal)
        {
            this.Width = tamaTotal;
            this.Height = altoTotal;

            int x = tamaTotal / 2 - btn_Si.Width / 2;
            int y = altoTotal / 2 - btn_Si.Width / 5;


            btn_Si.Location = new Point(x-150,y);
            btn_No.Location = new Point(x+150,y);

            btn_No.BackgroundImage = Image.FromFile(this.path + @"\Recursos\Iconos\BotonUno.png");
            btn_Si.BackgroundImage = Image.FromFile(this.path + @"\Recursos\Iconos\BotonUno.png");

        }

        public void DesicionesNuevas(string rol) 
        {
            this.tipo = "Desicion";

            switch (rol) 
            {
                case "Capitan":
                    this.btn_Si.Text = "Voy a Disparar!";
                    this.btn_No.Text = "Voy a Recargar!";
                    break;

                case "Carpintero":
                    this.btn_Si.Text = "Voy a Reparar!";
                    this.btn_No.Text = "Voy a Recargar!";
                    break;

                case "Mercader":
                    this.btn_Si.Text = "Voy a Disparar!";
                    this.btn_No.Text = "Voy a Recargar!";
                    break;

                case "Artillero":
                    this.btn_Si.Text = "Voy a Disparar!";
                    this.btn_No.Text = "Voy a Recargar!";
                    break;
            }
        }

        public string getTipo() 
        {
            return this.tipo;
        }

        public string getMensaje(int x) 
        {
            switch (x) 
            {
                case 1: return this.btn_Si.Text;

                case 2: return this.btn_No.Text;

                default: return "error";
            }
        }

        public void Votacion() 
        {
            this.tipo = "Votacion";
            this.btn_Si.Text = "Si Capitan!";
            this.btn_No.Text = "No Capitan!";
        }
        #endregion

        public void reiniciarVoto() 
        {
            this.voto = 0;
        }

        public int ConsultarVoto() 
        {
            return this.voto;
        }

        private void btn_Si_Click(object sender, EventArgs e)
        {
            voto = 1;
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            voto = 2;
        }
    }
}
