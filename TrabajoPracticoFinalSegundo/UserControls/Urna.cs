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

        public Urna()
        {
            InitializeComponent();
            this.voto = 9;
            this.tipo = "Votacion";
        }

        #region LOADS
        public void Load_Urna() 
        {
            
        }

        public void Load_Urna(int tamaTotal, int altoTotal)
        {
            this.Width = tamaTotal;
            this.Height = altoTotal;

            btn_Si.Location = new Point(0,0);
            btn_Si.Height = this.Height;
            btn_Si.Width = (this.Width/2);
            

            btn_No.Location = new Point(this.Width/2, 0);
            btn_No.Height = this.Height;
            btn_No.Width = (this.Width / 2);

        }

        public void DesicionesNuevas(string rol) 
        {
            this.tipo = "Desicion";

            switch (rol) 
            {
                case "Capitan":

                    break;

                case "Carpintero":

                    break;

                case "Mercader":

                    break;

                case "Artillero":
                    this.btn_Si.Text = "Disparar!";
                    this.btn_No.Text = "Recargar!";
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

                case 0: return this.btn_No.Text;

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
            this.voto = 9;
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
            voto = 0;
        }
    }
}
