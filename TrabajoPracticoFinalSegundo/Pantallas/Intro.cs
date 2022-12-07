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
        string path;int TIPO;

        public Intro(Ingreso ing)
        {
            InitializeComponent();
            this.ing = ing;
            this.cont = 0;
            this.TIPO = 1;

            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();

            p_boxUno.Location = new Point((((this.Width) / 2) - 50), (this.Height / 2));

            p_boxUno.Image = Image.FromFile(this.path + @"\Recursos\Logos\LOGO_Manija.png");
        }

        public Intro()
        {
            InitializeComponent();
            this.cont = 0;
            this.TIPO = 2;

            this.p_boxUno.Enabled = false;
			this.p_box2.Enabled = true;
			
            p_box2.Image = Image.FromFile(@".\Recursos\Gifs\barco.gif");
            p_box2.Location = new Point(30, (this.Height - 100));
            p_box2.BackColor = Color.Black;this.BackColor = Color.Black;
			
			

            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            cont++;
            if(cont >= 3 && cont < 5) 
            {
                if (this.TIPO == 1)
                p_boxUno.Image = Image.FromFile(this.path + @"\Recursos\Logos\LOGO_Gregoire.png");
            }

            if (cont >= 5) 
            {
                /*
                Home x = new Home();
                x.Show();
                */

                /*
                Prueba x = new Prueba();
                x.Show();
                */
                if (this.TIPO == 1)
                {
                    PantallaPhoto x = new PantallaPhoto();
                    x.Show();
                    this.Close();
                }
                else 
                {
                    this.Close();
                }
                
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
