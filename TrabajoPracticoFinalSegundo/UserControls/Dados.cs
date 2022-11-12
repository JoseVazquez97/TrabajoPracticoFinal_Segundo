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
        Turnero turnero;
        string path;
        private bool cerradura;

        public int V1 { get { return this.d1; } }
        public int V2 { get { return this.d2; } }

        public Dados()
        {
            InitializeComponent();
            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();
        }


        #region  LOADS

        public void LoadTablero(object sender, EventArgs e)
        {
            anim1.Visible = false;
            anim2.Visible = false;
            anim1.BackColor = Color.Red;
            anim2.BackColor = Color.Red;

            dado1.Image = Image.FromFile(this.path + @"\Recursos\Dados\Dado1.bmp");
            dado2.Image = Image.FromFile(this.path + @"\Recursos\Dados\Dado2.bmp");
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

        public void AsignarTurnero(ref Turnero x) 
        {
            this.turnero = x;
        }

        public void CargarTablero(int tamaTotal, int altoTotal)
        {
            this.Width = tamaTotal;
            this.Height = altoTotal;

            anim1.Visible = false;
            anim2.Visible = false;
            anim1.BackColor = Color.Red;
            anim2.BackColor = Color.Red;

            dado1.Image = Image.FromFile(this.path + @"\Recursos\Dados\Dado1.bmp");
            dado2.Image = Image.FromFile(this.path + @"\Recursos\Dados\Dado2.bmp");

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
            int d = new Random().Next(1, 7);
            dado = d;
            return Image.FromFile(this.path + @"\Recursos\Dados\Dado"+d+".bmp");
            
        }

        public void tirar()
        {
            tiradas = 0;
            TirandoDados.Interval = 50;
          
            TirandoDados.Start();
            this.turnero.Siguiente();
        }


        private void Dados_Try() 
        {
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
        #endregion
    }
}
