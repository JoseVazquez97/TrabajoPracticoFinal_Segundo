using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoFinalSegundo.UserControls
{
    public partial class UrnaCapitan : UserControl
    {
        int desicion;
        Notificador noti_cap;
        Turnero turn;
        string notificacion;

        public UrnaCapitan()
        {
            InitializeComponent();
            this.desicion = 0;
        }

        public void Load_UrnaCapitan(int tamaTotal, int altoTotal, ref Notificador noticap, ref Turnero turnero, ref string noti)
        {
            this.Width = tamaTotal;
            this.Height = altoTotal;
            this.noti_cap = noticap;
            this.turn = turnero;
            this.notificacion = noti;
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
            this.turn.Siguiente();
        }

        private void btn_Este_Click(object sender, EventArgs e)
        {
            this.desicion= 3;
            this.noti_cap.Visible = true;
            this.noti_cap.MensajeArmadoCap(3);
            this.turn.Siguiente();
        }

        private void btn_Oeste_Click(object sender, EventArgs e)
        {
            this.desicion= 2;
            this.noti_cap.Visible = true;
            this.noti_cap.MensajeArmadoCap(2);
            this.turn.Siguiente();
        }

        private void btn_Sur_Click(object sender, EventArgs e)
        {
            this.desicion = 4;
            this.noti_cap.Visible = true;
            this.noti_cap.MensajeArmadoCap(4);
            this.turn.Siguiente();
        }


    }
}
