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
using TrabajoPracticoFinalSegundo.Clases;

namespace TrabajoPracticoFinalSegundo.UserControls
{
    public partial class Barco : UserControl
    {
        Almacen almacen;
        string path;
        int Vida;
        int Danio;

        public Barco()
        {
            InitializeComponent();
            this.almacen = new Almacen();
            this.Vida = 100;
            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();
        }

        public void loadBarcoEnemigo() 
        {
            this.pic_Barco.Image = Image.FromFile(this.path + @"\Recursos\BarcO\BARCO_BaseDos.png");

            canon1.esIzquierdo();
            canon2.esDerecho();
            canon3.esDerecho();
            canon4.esIzquierdo();

            canon1.Parent = pic_Barco;
            canon2.Parent = pic_Barco;
            canon3.Parent = pic_Barco;
            canon4.Parent = pic_Barco;
            progressBar1.Parent = pic_Barco;
        }

        public void RecibirDanio(int danio) 
        {
            this.Vida -= danio;
            if (this.Vida >= 0)
            {
                this.progressBar1.Value = this.Vida;
            }
            else 
            {
                this.progressBar1.Value = 0;
            }
        }

        public void ReiniciarVida() 
        {
            this.Vida = 100;
            this.progressBar1.Value = 100;
        }

        public int ConsultarDanio() 
        {
            return this.Danio;
        }

        public void loadBarco()
        {
            this.pic_Barco.Image = Image.FromFile(this.path + @"\Recursos\BarcO\BARCO_BaseUno.png");

            canon1.esIzquierdo();
            canon2.esDerecho();
            canon3.esDerecho();
            canon4.esIzquierdo();

            canon1.Parent = pic_Barco;
            canon2.Parent = pic_Barco;
            canon3.Parent = pic_Barco;
            canon4.Parent = pic_Barco;

            progressBar1.Parent = pic_Barco;
        }
    }
}
