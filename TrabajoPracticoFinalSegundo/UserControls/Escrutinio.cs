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

namespace TrabajoPracticoFinalSegundo.UserControls
{
    public partial class Escrutinio : UserControl
    {
        int CHECKC;
        int CHECKM;
        int CHECKA;
        int resultado;

        public Escrutinio()
        {
            InitializeComponent();
            this.CHECKC = 0;
            this.CHECKM = 0;
            this.CHECKA = 0;
        }

        public void loadEscrutinio(int tamaTotal)
        {
            this.Width = (tamaTotal / 3);

            this.flowLayoutPanel1.Location = new Point(0, 0);

            int x = this.flowLayoutPanel1.Width;

        }

        public void recibirVoto(int rol, int voto)
        {
            switch (rol)
            {
                case 2:
                    if (this.CHECKC == 0) 
                    {
                        if (voto == 2)
                        {
                            this.pictureBox1.BackColor = Color.Red;
                            this.CHECKC++;
                            this.resultado++;
                        }

                        if(voto == 1) { this.pictureBox1.BackColor = Color.Green; this.CHECKC++; this.resultado--; }
                    }
                    break;

                case 3:
                    if (this.CHECKM == 0)
                    {
                        if (voto == 2)
                        {
                            this.pictureBox2.BackColor = Color.Red;
                            this.CHECKM++;
                            this.resultado++;
                        }

                        if (voto == 1) { this.pictureBox2.BackColor = Color.Green; this.CHECKM++; this.resultado--; }
                    }
                    break;

                case 4:
                    if (this.CHECKA == 0)
                    {
                        if (voto == 2)
                        {
                            this.pictureBox3.BackColor = Color.Red;
                            this.CHECKA++;
                            this.resultado++;
                        }

                        if (voto == 1) { this.pictureBox3.BackColor = Color.Green; this.CHECKA++; this.resultado--; }
                    }
                    break;

                default:

                    break;
            }
        }

        public void reiniciarVotos() 
        {
            this.pictureBox1.BackColor= Color.Gray;
            this.pictureBox2.BackColor = Color.Gray;
            this.pictureBox3.BackColor = Color.Gray;
        }

        public void reiniciarCheck()
        {
            this.CHECKA = 0;
            this.CHECKC = 0;
            this.CHECKM = 0;
        }

        public int confirmarVotacion() 
        {
            if ((this.CHECKC > 0) && (this.CHECKA > 0) && (this.CHECKM > 0))
            {
                return this.resultado;
            }
            else 
            {
                return 0;
            }
        }
    }
}
