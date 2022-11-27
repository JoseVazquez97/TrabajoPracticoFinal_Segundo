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
        Notificador noti_cap;

        public UrnaCapitan()
        {
            InitializeComponent();
            this.desicion= 1;
        }

        public void Load_UrnaCapitan(int tamaTotal, int altoTotal, ref Notificador noticap)
        {
            this.Width = tamaTotal;
            this.Height = altoTotal;
            this.noti_cap = noticap;
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
            this.noti_cap.Visible = true;
            this.noti_cap.MensajeArmadoCap(1);
        }

        private void btn_Este_Click(object sender, EventArgs e)
        {
            this.desicion= 2;
            this.noti_cap.Visible = true;
            this.noti_cap.MensajeArmadoCap(2);
        }

        private void btn_Oeste_Click(object sender, EventArgs e)
        {
            this.desicion= 3;
            this.noti_cap.Visible = true;
            this.noti_cap.MensajeArmadoCap(3);
        }

        private void btn_Sur_Click(object sender, EventArgs e)
        {
            this.desicion = 4;
            this.noti_cap.Visible = true;
            this.noti_cap.MensajeArmadoCap(4);
        }
    }
}
