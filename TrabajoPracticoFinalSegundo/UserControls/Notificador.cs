using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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

        public void Load_Notificador() 
        {
            this.BackgroundImage = Image.FromFile(@".\Recursos\Fondos\Notificador22.png");
        }

        public void MensajeArmadoCap(int x)
        {
            switch (x) 
            {
                case 1:
                    this.lbl_texto.Text = "Al Norte!";
                    break;
                case 2:
                    this.lbl_texto.Text = "Al Este!";
                    break;
                case 3:
                    this.lbl_texto.Text = "Al Oeste!";
                    break;
                case 4:
                    this.lbl_texto.Text = "Al Sur!";
                    break;
            }
            
        }

        public void MensajeArmado(int quien, int x,string evento) 
        {
            switch (x) 
            {
                case 1:
                    switch (quien) 
                    {
                        case 1:
                            switch (evento) 
                            {
                                case "Batalla":
                                    this.lbl_texto.Text = "Voy a Disparar!";
                                    break;

                                case "Pezca":

                                    break;
                            }
                            break;

                        case 2:
                            switch (evento)
                            {
                                case "Orden":

                                    break;

                                case "Votacion":
                                    this.lbl_texto.Text = "Estoy Listo!";
                                    break;

                                case "Batalla":
                                    this.lbl_texto.Text = "Voy a Disparar!";
                                    break;

                                case "Pezca":

                                    break;
                            }
                            break;

                        case 3:
                            switch (evento)
                            {
                                case "Orden":

                                    break;

                                case "Votacion":
                                    this.lbl_texto.Text = "Estoy Listo!";
                                    break;

                                case "Batalla":
                                    this.lbl_texto.Text = "Voy a Disparar!";
                                    break;

                                case "Pezca":

                                    break;
                            }
                            break;

                        case 4:
                            switch (evento)
                            {

                                case "Orden":

                                    break;

                                case "Votacion":
                                    this.lbl_texto.Text = "Estoy Listo!";
                                    break;

                                case "Batalla":
                                    this.lbl_texto.Text = "Voy a Disparar!";
                                    break;

                                case "Pezca":

                                    break;
                            }
                            break;
                    }
                    break;

                case 2:
                    switch (quien)
                    {
                        case 1:
                            switch (evento)
                            {
                                case "Batalla":
                                    this.lbl_texto.Text = "Voy a Recargar!";
                                    break;

                                case "Pezca":

                                    break;
                            }
                            break;

                        case 2:
                            switch (evento)
                            {
                                case "Batalla":
                                    this.lbl_texto.Text = "Voy a Recargar!";
                                    break;

                                case "Pezca":

                                    break;
                            }
                            break;

                        case 3:
                            switch (evento)
                            {
                                case "Batalla":
                                    this.lbl_texto.Text = "Voy a Recargar!";
                                    break;

                                case "Pezca":

                                    break;
                            }
                            break;

                        case 4:
                            switch (evento)
                            {
                                case "Batalla":
                                    this.lbl_texto.Text = "Voy a Recargar!";
                                    break;

                                case "Pezca":

                                    break;
                            }
                            break;
                    }
                    break;
            }
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
