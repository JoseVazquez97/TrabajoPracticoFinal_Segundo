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
        string path;

        public RecursosDisplay()
        {
            InitializeComponent();

            this.path = Directory.GetParent(Directory.GetParent("..").ToString()).ToString();
        }

        public void LoadRecursos(int tamaTotal, int alturaTotal) 
        {
            this.Width = tamaTotal;
            this.Height = alturaTotal;

            this.flowLayoutPanel1.Location = new Point(((tamaTotal / 2)-(tamaTotal/7)),0);

            this.flowLayoutPanel2.Parent = this.flowLayoutPanel1;
            this.lbl_Tesoro.Parent = this.flowLayoutPanel2;
            this.lbl_Maderas.Parent = this.flowLayoutPanel2;
            this.lbl_Balas.Parent = this.flowLayoutPanel2;

            this.p_Madera.BackgroundImage = Image.FromFile(this.path + @"\Recursos\Iconos\Madera.png");
            this.p_Tesoro.BackgroundImage = Image.FromFile(this.path + @"\Recursos\Iconos\Oro.jpg");
            this.p_Balas.BackgroundImage = Image.FromFile(this.path + @"\Recursos\Iconos\Balas.png");

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
            }
        }

        public void consultarRecursos() 
        {
            string mensaje;

            mensaje = this.lbl_Tesoro.Text + ";" + this.lbl_Maderas.Text + ";" + this.lbl_Balas.Text;
        }

    }
}
