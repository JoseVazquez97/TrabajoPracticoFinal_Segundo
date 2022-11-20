﻿using Emgu.CV.Shape;
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
        string path;

        public Intro(Ingreso ing)
        {
            InitializeComponent();
            this.ing = ing;
            this.cont = 0;

            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();

            p_boxUno.Location = new Point((((this.Width) / 2) - 50), (this.Height / 2));

            p_boxUno.Image = Image.FromFile(this.path + @"\Recursos\Logos\LOGO_Manija.png");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            cont++;
            if(cont >= 3 && cont < 5) 
            {
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

                PantallaPhoto x = new PantallaPhoto();
                x.Show();
                this.Close();
            }
        }

        private void Intro_Load(object sender, EventArgs e)
        {

        }

        private void Intro_Click(object sender, EventArgs e)
        {
            Timer.Interval = 10;

        }
    }
}
