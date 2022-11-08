using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoFinalSegundo.Pantallas
{
    public partial class Prueba : Form
    {
        private string _url = "https://localhost:7170/Hubs/HomeHub.cs";
        HubConnection HomeConection;

        int x;

        public Prueba()
        {
            InitializeComponent();

            HomeConection = new HubConnectionBuilder().WithUrl(_url).Build();

            //Si te desconectas segui intentado.
            HomeConection.Closed +=
                async (error) => { System.Threading.Thread.Sleep(5000); await HomeConection.StartAsync(); };
        }

        private async void Prueba_Load(object sender, EventArgs e)
        {
            try
            {
                await HomeConection.StartAsync();
            }
            catch
            {
                MessageBox.Show("Nosepuedoconectar");
            }

            HomeConection.On<int>("UpdateTurno", pepe =>
            {
                refrescarNumero(pepe);
            });

        }
        private void refrescarNumero(int pepe) 
        {
            LBL_PRUEBA.Location = new Point(pepe, 0);
        }
    }
}
