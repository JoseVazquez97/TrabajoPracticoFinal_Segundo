using Emgu.CV.Dnn;
using Emgu.CV.Face;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabajoPracticoFinalSegundo.UserControls
{
    public partial class Nombre : UserControl
    {
        public Nombre()
        {
            InitializeComponent();
        }

        public void EstablecerNombre(int key)
        {
            this.BackgroundImage = Image.FromFile(@".\Recursos\Gifs\Nombre.png");

            switch (key) 
            {
                case 1:
                    this.label1.Text = "CAPITAN";
                    break;

                case 2:
                    this.label1.Text = "CARPINTERO";
                    break;

                case 3:
                    this.label1.Text = "MERCADER";
                    break;

                case 4:
                    this.label1.Text = "ARTILLERO";
                    break;
            }
        }
    }
}
