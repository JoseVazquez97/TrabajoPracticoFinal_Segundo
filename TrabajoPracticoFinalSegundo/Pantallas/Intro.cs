using Emgu.CV.Shape;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoFinalSegundo.Pantallas
{
    public partial class Intro : Form
    {
        int cont;
        int TIPO;

        public Intro(Ingreso ing)
        {
            InitializeComponent();
            this.cont = 0;
            this.TIPO = 1;

            p_boxUno.Location = new Point((((this.Width) / 2) - 50), (this.Height / 2));

            p_boxUno.Image = Image.FromFile(@".\Recursos\Logos\LOGO_Manija.png");
        }

        public Intro()
        {
            Image carga = Image.FromFile(@".\Recursos\Gifs\barco.gif");
            InitializeComponent();
            this.cont = 0;
            this.TIPO = 2;

            this.p_boxUno.Enabled = false;
			this.p_box2.Enabled = true;

            p_box2.Image = carga;





        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            cont++;
            if(cont >= 3 && cont < 5) 
            {
                if (this.TIPO == 1)
                p_boxUno.Image = Image.FromFile(@".\Recursos\Logos\LOGO_Gregoire.png");
            }

            if (cont >= 5) 
            {
                this.Close();
            }
        }

        private void Intro_Load(object sender, EventArgs e)
        {

        }

        private void Intro_Click(object sender, EventArgs e)
        {
            if (this.TIPO == 1)
            Timer.Interval = 10;

        }
    }
}
