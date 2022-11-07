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
        Ingreso ing;
        int cont;

        public Intro(Ingreso ing)
        {
            InitializeComponent();
            this.ing = ing;
            this.cont = 0;

            p_boxUno.Location = new Point((((this.Width) / 2) - 50), (this.Height / 2));

            p_boxUno.Image = Image.FromFile(@".\Recursos\Logos\LOGO_Manija.png");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            cont++;
            if(cont >= 3 && cont < 6) 
            {
                p_boxUno.Image = Image.FromFile(@".\Recursos\Logos\LOGO_Gregoire.png");
            }

            if (cont >= 6) 
            {
                Home x = new Home();
                x.Show();

                this.Close();
            }
        }

        private void Intro_Load(object sender, EventArgs e)
        {

        }

        private void Intro_Click(object sender, EventArgs e)
        {
            if (this.cont < 3) 
            {
                this.cont = 3;
            }else if (this.cont < 6) 
            {
                this.cont = 6;
            }
        }
    }
}
