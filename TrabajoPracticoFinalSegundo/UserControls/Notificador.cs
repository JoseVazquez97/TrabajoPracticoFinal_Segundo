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
        public Notificador()
        {
            InitializeComponent();
        }

        public void Load_Notificador() 
        {
            
        }

        public void Mensaje(string texto) 
        {
            this.lbl_texto.Text = texto;
        }
    }
}
