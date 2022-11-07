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

        public Barco()
        {
            InitializeComponent();
            this.almacen = new Almacen();

            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();
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
        }

        public void loadBarco(int tamaAncho, int alturaMaxima)
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
        }
    }
}
