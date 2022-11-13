using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoFinalSegundo.Clases;
using TrabajoPracticoFinalSegundo.Pantallas;

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

            this.pictureBox1.Width = tamaTotal / 2;
        }

        public void Siguiente() 
        {
            this.turno++;
            lbl_Turno.Text = turno.ToString();
        }

        public void setTurno(int turnox) 
        {
            this.turno = turnox;
            lbl_Turno.Text = this.turno.ToString();
        }

        public void setRol(string rol) 
        {
            this.lbl_Nombre.Text = rol;
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
