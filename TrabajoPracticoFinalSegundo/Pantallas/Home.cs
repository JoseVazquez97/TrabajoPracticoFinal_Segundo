using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoFinalSegundo.Clases;
using System.IO;
using Microsoft.AspNetCore.SignalR.Client;
using TrabajoPracticoFinalSegundo.UserControls;

namespace TrabajoPracticoFinalSegundo.Pantallas
{
    public partial class Home : Form
    {

        private string _url = "https://localhost:7170/Hubs/HomeHub.cs";
        HubConnection HomeConection;


        Image miAvatar;
        List<Jugador> jugadores;
        int segundos;
        string path;

        //Esto Es un comentario.

        public Home()
        {
            InitializeComponent();
            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();

            //Carga de componentes.
            this.segundos = 0;
            this.pantallaWeb1.WebLoad();
            this.pantallaWeb2.WebLoad();
            this.pantallaWeb3.WebLoad();

            int x = (this.Width / 2);
            int y = (this.Height / 2);

            #region LOADS con configuracion responsiva. 

            //RECURSOS
            this.recursosDisplay1.LoadRecursos(flowLayoutPanel4.Width, flowLayoutPanel4.Height);

            //BARCO

            this.barco1.loadBarco(this.flowLayoutPanel5.Width,this.flowLayoutPanel5.Height);
            this.BackgroundImage = Image.FromFile(this.path + @"\Recursos\Fondos\FondoHomeDos.jpg");

            //BARRA (INFERIOR)
            x = Convert.ToInt32(this.flowLayoutPanel1.Width / 3);
            y = this.flowLayoutPanel1.Height;

            this.urna1.Load_Urna(x, y);
            this.turnero1.LoadTurnero(x, y);
            this.dados1.CargarTablero(x, y);
            this.dados1.AsignarTurnero(ref this.turnero1);

            //PROGRESSBAR
            this.progress.Width = this.Width;
            this.progress.Visible = true;
            this.progress.Minimum = 1;
            this.progress.Maximum = 100;
            this.progress.Value = 1;
            this.progress.Step = 1;
            #endregion


            #region Conexion al hub.
            HomeConection = new HubConnectionBuilder().WithUrl(_url).Build();

            //Si te desconectas segui intentado.
            HomeConection.Closed +=
                async (error) => { System.Threading.Thread.Sleep(5000); await HomeConection.StartAsync(); };
            #endregion
        }

        private async void Home_Load(object sender, EventArgs e)
        {
            

            HomeConection.On<string,string,string,string>("RecibirImagen", (img1,img2,img3,img4) =>
            {
                #region Comunicacion entre las webcams


                if (this.pantallaWeb1.InvokeRequired)
                {
                    pantallaWeb1.Invoke(new Action(() => pantallaWeb1.RecibirFrame(img1)));
                }
                
                if (this.pantallaWeb2.InvokeRequired)
                {
                    pantallaWeb2.Invoke(new Action(() => pantallaWeb2.RecibirFrame(img2)));
                }

                if (this.pantallaWeb3.InvokeRequired)
                {
                    pantallaWeb3.Invoke(new Action(() => pantallaWeb3.RecibirFrame(img3)));
                }

                try
                {
                    mandarImagenes();
                }
                catch (Exception ex)
                {

                }

                #endregion

            });
        }

        private async void mandarImagenes()
        {
            try
            {
                string imgUser = "";
                string imgUser1 = this.pantallaWeb1.DarFrame();
                string imgUser2 = this.pantallaWeb2.DarFrame();
                string imgUser3 = this.pantallaWeb3.DarFrame();

                await HomeConection.InvokeAsync("EnviarImagen", imgUser1, imgUser2, imgUser3, imgUser);
            }
            catch (Exception ex)
            {

            }
        }


        #region JUEGO


        private void Update_Tick(object sender, EventArgs e)
        {
            HacerPaso(); 
            segundos++;
        }


        #endregion


        #region FUNCIONES

        #region PROGRES_BAR

        private void HacerPaso() 
        {
            /*
            if () 
            {
                this.progress.PerformStep();
            }
            */
            
        }

        #endregion


        #region CERRAR FORM
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salirAlIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }



        #endregion

        #endregion


        #region LOADS

        public void AsignarAvatar(Image avatar) 
        {
            this.miAvatar = avatar;
            this.pantallaWeb1.CargarAvatar(this.miAvatar);
        }

        #endregion

        private void barco1_Load(object sender, EventArgs e)
        {

        }



    }
}
