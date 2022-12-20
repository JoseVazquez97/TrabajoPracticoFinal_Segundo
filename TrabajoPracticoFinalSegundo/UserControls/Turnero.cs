using Emgu.CV.Dnn;
using Emgu.CV.Face;
using Emgu.CV;
using Microsoft.AspNetCore.SignalR.Client;
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
using TrabajoPracticoFinalSegundo.Clases;
using TrabajoPracticoFinalSegundo.Pantallas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabajoPracticoFinalSegundo.UserControls
{
    public partial class Turnero : UserControl
    {
        int turno;
        int Segundos;

        public Turnero()
        {
            InitializeComponent();
            this.turno = 1;
        }
        public void LoadTurnero(int tamaTotal, int altoTotal)
        {
            this.Width = tamaTotal;
            this.Height = altoTotal;
            this.pictureBox1.Width = tamaTotal;
            this.pictureBox1.Height = tamaTotal;
            this.pictureBox1.Image = Image.FromFile(@".\Recursos\Iconos\Turnero.png");

            

            setRol();
        }
        public void Siguiente() 
        {
            this.turno++;
            lbl_Turno.Text = turno.ToString();
            setRol();
        }

        public void setTurno(int turnox) 
        {
            this.turno = turnox;
            lbl_Turno.Text = this.turno.ToString();
            setRol();
        }

        private void setRol() 
        {
            switch (obtenerTurno(this.turno)) 
            {
                case 1:
                    this.lbl_Nombre.Text = "Capitan";
                    break;
                case 2:
                    this.lbl_Nombre.Text = "Carpintero";
                    break;
                case 3:
                    this.lbl_Nombre.Text = "Mercader";
                    break;
                case 4:
                    this.lbl_Nombre.Text = "Artillero";
                    break;
            }
        }

        private int obtenerTurno(int turnoActual)
        {
            int turnoDevuelto = turnoActual;
            if (turnoDevuelto > 4)
            {
                turnoDevuelto = turnoActual - 4;
                return obtenerTurno(turnoDevuelto);
            }
            else
            {
                return turnoDevuelto;
            }
        }

        public int getTurno() 
        {
            return this.turno;
        }

        private void lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Segundos++;
        }
    }
}
