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
    public partial class UrnaCapitan : UserControl
    {
        int desicion;

        public UrnaCapitan()
        {
            InitializeComponent();
            this.desicion= 0;
        }

        public void Load_UrnaCapitan(int tamaTotal, int altoTotal)
        {
            this.Width = tamaTotal;
            this.Height = altoTotal;
        }

        public int ConsultarDesicion() 
        {
            return this.desicion;
        }

        public void ReiniciarDesicion() 
        {
            this.desicion = 0;
        }


        private void btn_Norte_Click(object sender, EventArgs e)
        {
            this.desicion= 1;
        }

        private void btn_Este_Click(object sender, EventArgs e)
        {
            this.desicion= 2;
        }

        private void btn_Oeste_Click(object sender, EventArgs e)
        {
            this.desicion= 3;
        }

        private void btn_Sur_Click(object sender, EventArgs e)
        {
            this.desicion = 4;
        }
    }
}
