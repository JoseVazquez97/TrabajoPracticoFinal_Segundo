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
        Notificador notificador;

        public Urna()
        {
            InitializeComponent();
            this.voto = 0;
            this.tipo = "Votacion";
        }

        #region LOADS
        public void Load_Urna() 
        {
            
        }

        public void Load_Urna(int tamaTotal, int altoTotal, ref Notificador noti)
        {
            this.notificador = noti;

            this.Width = tamaTotal;
            this.Height = altoTotal;

            int x = tamaTotal / 2 - btn_Si.Width / 2;
            int y = altoTotal / 2 - btn_Si.Width / 5;


            btn_Si.Location = new Point(x-150,y);
            btn_No.Location = new Point(x+150,y);

            btn_No.BackgroundImage = Image.FromFile(@".\Recursos\Iconos\BotonUno.png");
            btn_Si.BackgroundImage = Image.FromFile(@".\Recursos\Iconos\BotonUno.png");

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
            this.btn_Si.Text = "Estoy Listo";
            this.btn_No.Text = "No Capitan!";
            this.btn_No.Visible = false;
            this.btn_Si.Width = this.Width/2;

            this.notificador.Mensaje("Estoy Listo!");
        }

        public void Batalla(int rol)
        {
            this.tipo = "Batalla";

            switch (rol) 
            {
                case 1:
                    this.btn_Si.Text = "Disparar!";
                    this.btn_No.Text = "Huir";
                    break;

                case 2:
                    this.btn_Si.Text = "Reparar!";
                    this.btn_No.Text = "Recargar";
                    break;

                case 3:
                    this.btn_Si.Text = "Parley!";
                    this.btn_No.Text = "Recargar";
                    break;

                case 4:
                    this.btn_Si.Text = "Disparar!";
                    this.btn_No.Text = "Recargar";
                    break;
            }

            
            this.btn_No.Visible = false;
            this.btn_Si.Width = this.Width / 2;

            this.notificador.Mensaje("Estoy Listo!");
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
            this.notificador.Mensaje("Estoy Listo!");
            this.notificador.Visible = true;
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            voto = 2;
            this.notificador.Visible = true;
        }
    }
}
