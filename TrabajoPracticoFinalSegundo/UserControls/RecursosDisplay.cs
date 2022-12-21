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
using System.IO;
using Microsoft.AspNetCore.SignalR.Client;

namespace TrabajoPracticoFinalSegundo.UserControls
{
    public partial class RecursosDisplay : UserControl
    {
        private string _url = "https://localhost:7170/homeHubNew";
        HubConnection HomeConection;
        private int Key;

        public RecursosDisplay()
        {
            InitializeComponent();

            #region DECLARACION DEL HUB
            HomeConection = new HubConnectionBuilder().WithUrl(_url).Build();

            //Si te desconectas segui intentado.
            HomeConection.Closed +=
                async (error) => { System.Threading.Thread.Sleep(5000); await HomeConection.StartAsync(); };
            #endregion
        }

        private async void EnviarRecursos()
        {
            int usr = this.Key;
            string msg = consultarRecursos();

            try
            {
                await HomeConection.InvokeAsync("EnviarRecursos", usr,msg);
            }
            catch { MessageBox.Show("Error en el envio de dados."); }
        }


        private async void RecursosDisplay_Load(object sender, EventArgs e)
        {
            #region CONECTARSE
            //Este try es importante no sacar xd
            try
            {
                await HomeConection.StartAsync();
            }
            catch
            {
                MessageBox.Show("Nosepuedoconectar");
            }
            #endregion

            HomeConection.On<int,string>("RecibirRecursos", (usr, msg) =>
            {
                if (usr != this.Key)
                {
                    try
                    {
                        RecibirRecurso(msg);
                    }
                    catch { MessageBox.Show($"Error al cargar los valores {msg} en los dados"); }
                }
            });
        }

        public void LoadRecursos(int tamaTotal, int alturaTotal) 
        {
            this.Width = (tamaTotal / 3);
            this.Height = alturaTotal;

            this.flowLayoutPanel1.Location = new Point(((this.Width / 4)-(this.Width/7)),0);

            this.flowLayoutPanel2.Parent = this.flowLayoutPanel1;
            this.lbl_Tesoro.Parent = this.flowLayoutPanel2;
            this.lbl_Maderas.Parent = this.flowLayoutPanel2;
            this.lbl_Balas.Parent = this.flowLayoutPanel2;

            this.p_Madera.BackgroundImage = Image.FromFile(@".\Recursos\Iconos\Madera.png");
            this.p_Tesoro.BackgroundImage = Image.FromFile(@".\Recursos\Iconos\Oro.png");
            this.p_Balas.BackgroundImage = Image.FromFile(@".\Recursos\Iconos\Balas.png");
            this.p_Comida.BackgroundImage = Image.FromFile(@".\Recursos\Iconos\Comida.jpg");

        }

        public void extraerRecurso(string cual, int cant) 
        {
            int aux = 0;

            switch (cual) 
            {
                case "Oro":
                    aux = int.Parse(this.lbl_Tesoro.Text) - cant;
                    this.lbl_Tesoro.Text = aux.ToString();
                    break;

                case "Madera":
                    aux = int.Parse(this.lbl_Maderas.Text) - cant;
                    this.lbl_Maderas.Text = aux.ToString();
                    break;

                case "Bala":
                    aux = int.Parse(this.lbl_Balas.Text) - cant;
                    this.lbl_Balas.Text = aux.ToString();
                    break;

                case "Comida":
                    aux = int.Parse(this.lbl_Comida.Text) - cant;
                    this.lbl_Comida.Text = aux.ToString();
                    break;

            }

            EnviarRecursos();
        }

        public void cargarRecurso(string cual, int cant)
        {
            int aux = 0;

            switch (cual)
            {
                case "Oro":
                    aux = int.Parse(this.lbl_Tesoro.Text) + cant;
                    this.lbl_Tesoro.Text = aux.ToString();
                    break;

                case "Madera":
                    aux = int.Parse(this.lbl_Maderas.Text) + cant;
                    this.lbl_Maderas.Text = aux.ToString();
                    break;

                case "Bala":
                    aux = int.Parse(this.lbl_Balas.Text) + cant;
                    this.lbl_Balas.Text = aux.ToString();
                    break;

                case "Comida":
                    aux = int.Parse(this.lbl_Comida.Text) + cant;
                    this.lbl_Comida.Text = aux.ToString();
                    break;
            }

            EnviarRecursos();
        }

        #region SIGNALR

        public string consultarRecursos() 
        {
            string mensaje;

            mensaje = this.lbl_Tesoro.Text + ";" + this.lbl_Balas.Text + ";" + this.lbl_Maderas.Text + ";"  + this.lbl_Comida.Text + ";";
            return mensaje;
        }

        public void RecibirRecurso(string recursos) 
        {
            string aux = "";
            int cont = 0;

            for (int i = 0; i < recursos.Length; i++)
            {
                if (recursos[i] != ';')
                {
                    aux += recursos[i].ToString();
                }
                else 
                {
                    cont++;

                    switch (cont)
                    {
                        case 1: this.lbl_Tesoro.Invoke(new Action(() => this.lbl_Tesoro.Text = aux)); break;
                        case 2: this.lbl_Balas.Invoke(new Action(() => this.lbl_Balas.Text = aux)); break;
                        case 3: this.lbl_Maderas.Invoke(new Action(() => this.lbl_Maderas.Text = aux)); break;
                        case 4: this.lbl_Comida.Invoke(new Action(() => this.lbl_Comida.Text = aux)); break;
                    }
                    aux = "";
                }
            }
        }

        internal void recibirKey(int key)
        {
            this.Key = key;
        }

        #endregion


    }
}
