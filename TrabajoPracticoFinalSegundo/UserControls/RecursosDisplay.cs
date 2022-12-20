using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrabajoPracticoFinalSegundo.UserControls
{
    public partial class RecursosDisplay : UserControl
    {
        public RecursosDisplay()
        {
            InitializeComponent();
        }

        public void LoadRecursos(int tamaTotal, int alturaTotal) 
        {
            this.Width = (tamaTotal / 3);
            this.Height = alturaTotal;

            this.flowLayoutPanel1.Location = new Point(((this.Width / 4)-(this.Width/7)),0);

            this.flowLayoutPanel2.Parent = this.flowLayoutPanel1;
            this.lbl_Tesoro.Parent = this.flowLayoutPanel2;
            this.lbl_Maderas.Parent = this.flowLayoutPanel2;
            this.lbl_Balas.Parent = this.flowLayoutPanel2;

            this.p_Madera.BackgroundImage = Image.FromFile(@".\Recursos\Iconos\Madera.png");
            this.p_Tesoro.BackgroundImage = Image.FromFile(@".\Recursos\Iconos\Oro.png");
            this.p_Balas.BackgroundImage = Image.FromFile(@".\Recursos\Iconos\Balas.png");
            this.p_Comida.BackgroundImage = Image.FromFile(@".\Recursos\Iconos\Comida.jpg");

        }

        public void extraerRecurso(string cual, int cant) 
        {
            int aux = 0;

            switch (cual) 
            {
                case "Oro":
                    aux = int.Parse(this.lbl_Tesoro.Text) - cant;
                    this.lbl_Tesoro.Text = aux.ToString();
                    break;

                case "Madera":
                    aux = int.Parse(this.lbl_Maderas.Text) - cant;
                    this.lbl_Maderas.Text = aux.ToString();
                    break;

                case "Bala":
                    aux = int.Parse(this.lbl_Balas.Text) - cant;
                    this.lbl_Balas.Text = aux.ToString();
                    break;

                case "Comida":
                    aux = int.Parse(this.lbl_Comida.Text) - cant;
                    this.lbl_Comida.Text = aux.ToString();
                    break;

            }
        }

        public void cargarRecurso(string cual, int cant)
        {
            int aux = 0;

            switch (cual)
            {
                case "Oro":
                    aux = int.Parse(this.lbl_Tesoro.Text) + cant;
                    this.lbl_Tesoro.Text = aux.ToString();
                    break;

                case "Madera":
                    aux = int.Parse(this.lbl_Maderas.Text) + cant;
                    this.lbl_Maderas.Text = aux.ToString();
                    break;

                case "Bala":
                    aux = int.Parse(this.lbl_Balas.Text) + cant;
                    this.lbl_Balas.Text = aux.ToString();
                    break;

                case "Comida":
                    aux = int.Parse(this.lbl_Comida.Text) + cant;
                    this.lbl_Comida.Text = aux.ToString();
                    break;
            }
        }

        #region SIGNALR

        public string consultarRecursos() 
        {
            string mensaje;

            mensaje = this.lbl_Tesoro.Text + ";" + this.lbl_Maderas.Text + ";" + this.lbl_Balas.Text + ";";
            return mensaje;
        }

        public void RecibirRecurso(string recursos) 
        {
            string aux = "";
            int cont = 0;

            for (int i = 0; i < recursos.Length; i++)
            {
                if (recursos[i] != ';')
                {
                    aux += recursos[i].ToString();
                    
                }
                else 
                {
                    cont++;

                    switch (cont) 
                    {
                        case 1: this.lbl_Tesoro.Text = aux; break;
                        case 2: this.lbl_Maderas.Text = aux; break;
                        case 3: this.lbl_Balas.Text = aux; break;
                    }
                    aux = "";
                }
            }
        }

        #endregion

    }
}
