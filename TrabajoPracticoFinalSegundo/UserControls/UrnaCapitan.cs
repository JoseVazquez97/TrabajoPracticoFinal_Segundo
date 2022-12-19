using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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

        public void Load_UrnaCapitan(ref Notificador noticap, ref Turnero turnero)
        {
            this.noti_cap = noticap;
            this.turn = turnero;
            ReSize();
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
            this.desicion= 3;
            this.noti_cap.Visible = true;
            this.noti_cap.MensajeArmadoCap(3);
        }

        private void btn_Oeste_Click(object sender, EventArgs e)
        {
            this.desicion= 2;
            this.noti_cap.Visible = true;
            this.noti_cap.MensajeArmadoCap(2);
        }

        private void btn_Sur_Click(object sender, EventArgs e)
        {
            this.desicion = 4;
            this.noti_cap.Visible = true;
            this.noti_cap.MensajeArmadoCap(4);
        }

        private void ReSize()
        {
            int x, y;
            x = (this.Width * btn_Este.Location.X) / 510;
            y = (this.Height * btn_Este.Location.Y) / 124;
            btn_Este.Location = new Point(x,y);

            x = (this.Width * btn_Sur.Location.X) / 510;
            y = (this.Height * btn_Sur.Location.Y) / 124;
            btn_Sur.Location = new Point(x, y);

            x = (this.Width * btn_Oeste.Location.X) / 510;
            y = (this.Height * btn_Oeste.Location.Y) / 124;
            btn_Oeste.Location = new Point(x, y);

            x = (this.Width * btn_Norte.Location.X) / 510;
            y = (this.Height * btn_Norte.Location.Y) / 124;
            btn_Norte.Location = new Point(x, y);


            x = (this.Width * btn_Este.Width) / 510;
            y = (this.Height * btn_Este.Height) / 124;
            btn_Este.Size = new Size(x, y);

            x = (this.Width * btn_Sur.Width) / 510;
            y = (this.Height * btn_Sur.Height) / 124;
            btn_Sur.Size = new Size(x, y);

            x = (this.Width * btn_Oeste.Width) / 510;
            y = (this.Height * btn_Oeste.Height) / 124;
            btn_Oeste.Size = new Size(x, y);

            x = (this.Width * btn_Norte.Width) / 510;
            y = (this.Height * btn_Norte.Height) / 124;
            btn_Norte.Size = new Size(x, y);
        }
    }
}
