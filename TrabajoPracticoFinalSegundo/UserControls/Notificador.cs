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
    public partial class Notificador : UserControl
    {
        string path;

        public Notificador()
        {
            InitializeComponent();
        }

        public void Load_Notificador() 
        {
            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();
            this.BackgroundImage = Image.FromFile(this.path + @"\Recursos\Fondos\Notificador22.png");
        }

        public void MensajeArmadoCap(int x)
        {
            switch (x) 
            {
                case 1:
                    this.lbl_texto.Text = "Al Norte!";
                    break;
                case 2:
                    this.lbl_texto.Text = "Al Este!";
                    break;
                case 3:
                    this.lbl_texto.Text = "Al Oeste!";
                    break;
                case 4:
                    this.lbl_texto.Text = "Al Sur!";
                    break;
            }
        }

        public void Mensaje(string texto) 
        {
            this.lbl_texto.Text = texto;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
