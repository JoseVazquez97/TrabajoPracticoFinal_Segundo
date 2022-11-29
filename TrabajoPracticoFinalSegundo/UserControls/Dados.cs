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

namespace TrabajoPracticoFinalSegundo.UserControls
{ 
    public partial class Dados : UserControl
    {

        private int tiradas;
        private int d1;
        private int d2;
        private bool cerradura;
        private bool Listo;

        public int V1 { get { return this.d1; } }
        public int V2 { get { return this.d2; } }
        public bool LISTO { get { return this.Listo; } }

        public Dados()
        {
            InitializeComponent();
        }


        #region  LOADS

        public void LoadTablero(object sender, EventArgs e)
        {
            this.Listo = false;
            anim1.Visible = false;
            anim2.Visible = false;
            anim1.BackColor = Color.Red;
            anim2.BackColor = Color.Red;

            dado1.Image = Image.FromFile(@".\Recursos\Dados\Dado1.bmp");
            dado2.Image = Image.FromFile(@".\Recursos\Dados\Dado2.bmp");
        }

        public void setEnable(bool x) 
        {
            this.anim1.Enabled=x;
            this.anim2.Enabled=x;
            this.dado1.Enabled=x;
            this.dado2.Enabled=x;
            this.Enabled = x;

            cerradura = x;
        }

        public bool getEnable() 
        {
            return cerradura;
        }

        public void CargarTablero(int tamaTotal, int altoTotal)
        {
            this.Width = tamaTotal;
            this.Height = altoTotal;

            anim1.Visible = false;
            anim2.Visible = false;
            anim1.BackColor = Color.Red;
            anim2.BackColor = Color.Red;

            dado1.Image = Image.FromFile(@".\Recursos\Dados\Dado1.bmp");
            dado2.Image = Image.FromFile(@".\Recursos\Dados\Dado2.bmp");

            int x = Convert.ToInt32(this.Width / 2);

            anim1.Location = new Point(x-70, 32);
            anim2.Location = new Point(x+55, 32);

            dado1.Location = new Point(x-65, 38);
            dado2.Location = new Point(x+60, 38);
        }
        #endregion

        #region FUNCIONALIDAD
        private Image Tirada(int dado)
        {
            return Image.FromFile(@".\Recursos\Dados\Dado"+ dado + ".bmp");
        }

        private int Suerte() 
        {
            int d;
            return d = new Random().Next(1, 7);
        }

        public void tirar()
        {
            this.Listo = false;
            tiradas = 0;
            TirandoDados.Interval = 50;
          
            TirandoDados.Start();
        }

        public void tirar(string val1, string val2)
        {
            this.Listo = false;
            tiradas = 0;
            TirandoDados.Interval = 50;

            TirandoDados.Start();
        }


        private void Dados_Try() 
        {
            this.d1 = Suerte();
            this.d2 = Suerte();
            this.dado1.Image = Tirada(this.d1);
            this.dado2.Image = Tirada(this.d2);

            if(anim1.Visible)
            {
                anim1.Visible = false;
                anim2.Visible = false;
            }
            else
            {
                anim1.Visible = true;
                anim2.Visible = true;
            }
        }

        private void TerminarTirada()
        {
            anim1.Visible = false;
            anim2.Visible = false;
            this.Listo = true;
        }

        public void AsignarValores(string val1, string val2) 
        {
            this.dado1.Image = Tirada(int.Parse(val1));
            this.dado2.Image = Tirada(int.Parse(val2));
            TerminarTirada();
        }

        private void TirandoDados_Tick(object sender, EventArgs e)
        {
            Dados_Try();

            if (tiradas < 8) 
            {
                TirandoDados.Interval += 70;
            }
            else TirandoDados.Interval += 300;


            tiradas++;


            if (tiradas >= 10)
            {
                TirandoDados.Stop();
                TerminarTirada();
            }
        }

        private void TirandoDados_Tick(object sender, EventArgs e,string especial)
        {
            Dados_Try();

            if (tiradas < 8) 
            {
                TirandoDados.Interval += 70;
            }
            else TirandoDados.Interval += 300;


            tiradas++;


            if (tiradas >= 9)
            {
                TirandoDados.Stop();
            }
        }
        #endregion
    }
}
