using Microsoft.AspNetCore.SignalR.Client;
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
    public partial class ChatBox : UserControl
    {
        HubConnection hubConnection;
        public ChatBox()
        {
            InitializeComponent();

            hubConnection = new HubConnectionBuilder().WithUrl("https://localhost:7170").Build();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
