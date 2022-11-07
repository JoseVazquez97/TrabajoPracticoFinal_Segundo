using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrabajoPracticoFinalSegundo.UserControls
{
    public partial class Canon : UserControl
    {

        int danio;
        int nivel;
        Image imagen;
        string path;

        public Image IMG { get { return this.imagen; } set{ this.imagen = value; } }

        public Canon()
        {
            InitializeComponent();

            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();

            this.Visible = true;
            this.danio = 0;
            this.nivel = 0;
        }


        public void subirNivel()
        {
            
        }
        
        public void esDerecho()
        {
             this.p_Box.Image = Image.FromFile(this.path + @"\Recursos\Caniones\CanionBase.png");
        }

        public void esIzquierdo() 
        {
             this.p_Box.Image = Image.FromFile(this.path + @"\Recursos\Caniones\CanionBaseIzquierdo.png");
        }

        private string UpdatearImagen()
        {
            string path = "";


            return path;
        }

        public string Disparar()
        {
            string path = "";

            return path;
        }

        
    }
}
