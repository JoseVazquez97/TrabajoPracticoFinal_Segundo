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
    public partial class Comunicador : UserControl
    {
        public Comunicador()
        {
            InitializeComponent();
            
        }

        public ref Label miLabel() 
        {
            return ref this.LABEL_PRUEBA;
        }

        public void siguienteValor(int i)
        { 
            this.LABEL_PRUEBA.Text = i.ToString();
        }

    }
}
