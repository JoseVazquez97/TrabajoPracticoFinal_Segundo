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
    public partial class Escrutinio : UserControl
    {
        public Escrutinio()
        {
            InitializeComponent();
        }

        public void recibirVoto(string rol, int voto)
        {
            switch (rol) 
            {
                case "Carpintero":
                    if (voto == 0)
                    {
                        this.pictureBox1.BackColor = Color.Red;
                    }
                    else { this.pictureBox1.BackColor = Color.Green; }
                    break;

                case "Mercader":
                    if (voto == 0)
                    {
                        this.pictureBox1.BackColor = Color.Red;
                    }
                    else { this.pictureBox1.BackColor = Color.Green; }
                    break;

                case "Artillero":
                    if (voto == 0)
                    {
                        this.pictureBox1.BackColor = Color.Red;
                    }
                    else { this.pictureBox1.BackColor = Color.Green; }
                    break;
            }
        }

        public void reiniciarVotos() 
        {
            this.pictureBox1.BackColor= Color.White;
            this.pictureBox2.BackColor = Color.White;
            this.pictureBox3.BackColor = Color.White;
        }
    }
}
