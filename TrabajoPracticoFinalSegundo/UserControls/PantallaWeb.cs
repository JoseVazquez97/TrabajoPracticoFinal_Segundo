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
    public partial class PantallaWeb : UserControl
    {
        string path;
        
        public PantallaWeb()
        {
            InitializeComponent();

            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();
        }

        public void WebLoad() 
        {
            pictureBox1.BackgroundImage = Image.FromFile(this.path+ @".\Recursos\Iconos\LogoEjemplo.png");
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
