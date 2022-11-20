using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.VisualBasic.ApplicationServices;
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
using System.Xml.Linq;

namespace TrabajoPracticoFinalSegundo.Pantallas
{
    public partial class Prueba : Form 
    {
        private string _url = "https://localhost:7170/Hubs/EjemploHub.cs";
        HubConnection HomeConection;
        string path;

        public Prueba()
        {
            InitializeComponent();

            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();

            HomeConection = new HubConnectionBuilder().WithUrl(_url).Build();

            //Si te desconectas segui intentado.
            HomeConection.Closed +=
                async (error) => { System.Threading.Thread.Sleep(5000); await HomeConection.StartAsync(); };

            this.pictureBox1.Image = Image.FromFile(this.path + @"\Recursos\Fondos\Viajando.gif");

        }

        private async void Prueba_Load(object sender, EventArgs e)
        {
            //Este try es importante no sacar xd
            try
            {
                await HomeConection.StartAsync();
            }
            catch
            {
                MessageBox.Show("Desconectado");
            }

            HomeConection.On<int>("UpdateTurno", pepe =>
            {
                if (LBL_PRUEBA.InvokeRequired)
                {
                    try
                    {
                        LBL_PRUEBA.Invoke(new Action(() => LBL_PRUEBA.Text = $"{pepe}"));
                    }
                    catch
                    {
                        MessageBox.Show("Debes cerrar la app");
                    }
                }

                if (pruebauControl1.InvokeRequired)
                {
                    try
                    {
                        pruebauControl1.Invoke(new Action(() => pruebauControl1.recibirCambio(pepe)));
                    }
                    catch
                    {
                        MessageBox.Show("Debes cerrar la app");
                    }

                }

            });

        }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                await HomeConection.StartAsync();
            }
            catch
            {
                MessageBox.Show("Nosepuedoconectar");
            }
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                await HomeConection.InvokeAsync("MandarTurno", 0);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
