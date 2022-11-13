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
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Http;
using System.Security.Policy;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Reflection.Metadata;

namespace TrabajoPracticoFinalSegundo.Pantallas
{
    public partial class Home : Form
    {

        private string _url = "https://localhost:7170/Hubs/HomeHub.cs";
        HubConnection HomeConection;

        string Rol;
        Image miAvatar;
        Jugador jugador;
        int segundos;
        string path;
        int contError;
        int Key;
        int turno;

        //Esto Es un comentario.

        public Home()
        {
            InitializeComponent();

            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();
            this.contError = 0;

            #region LOADS DE COMPONENTES 

            //PANTALLAS WEB
            this.segundos = 0;
            this.pantallaWeb1.WebLoad();
            this.pantallaWeb2.WebLoad();
            this.pantallaWeb3.WebLoad();

            int x = (this.Width / 2);
            int y = (this.Height / 2);

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
            this.dados1.CargarTablero(x+100, y);
            this.dados1.AsignarTurnero(ref this.turnero1);

            //PROGRESSBAR
            this.progress.Width = this.Width;
            this.progress.Visible = true;
            this.progress.Minimum = 1;
            this.progress.Maximum = 100;
            this.progress.Value = 1;
            this.progress.Step = 1;
            #endregion


            #region DECLARACION DEL HUB
            HomeConection = new HubConnectionBuilder().WithUrl(_url).Build();

            //Si te desconectas segui intentado.
            HomeConection.Closed +=
                async (error) => { System.Threading.Thread.Sleep(5000); await HomeConection.StartAsync(); };
            #endregion
        }


        /// ///////////////////////////////////////////////////////////////


        #region JUEGO (LOOP PRINCIPAL)

        private void Update_Tick(object sender, EventArgs e)
        {
            //Adelanta un fragmento de la progress bar
            HacerPaso();

            //Compartimos la informacion
            mandarImagenes();
            mandarInfoDados();

            //Contador de segundos.
            segundos++;
        }

        #endregion


        /// ///////////////////////////////////////////////////////////////

        #region USERS_CONTROLS

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

        #region DADOS

        private void dados_Click(object sender, EventArgs e) 
        {
            this.dados1.tirar();
            mandarInfoDados();
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

        /// ///////////////////////////////////////////////////////////////

        #region SIGNAL R


        #region ENVIO DE MENSAJES

        #region Mandar Imagenes
        private async void mandarImagenes()
        {
            string imgUser;
            string rol = this.Rol;

            switch (rol)
            {
                case "Capitan": imgUser = this.pantallaWeb1.DarFrame(); break;
                case "Carpintero": imgUser = this.pantallaWeb2.DarFrame(); break;
                case "Mercader": imgUser = this.pantallaWeb3.DarFrame(); break;
                case "Artillero": imgUser = this.pantallaWeb4.DarFrame(); break;
                default: imgUser = "Defaul"; break;
            };

            try
            {
                await HomeConection.InvokeAsync("EnviarImagen", imgUser, rol);
            }
            catch { if (this.contError == 0) MessageBox.Show("Error en el envio de imagenes."); this.contError++; }
        }
        #endregion

        #region Mandar Info Dados

        private async void mandarInfoDados()
        {
            string rol = this.Rol;
            string key = this.Key.ToString();
            string turno = this.turno.ToString();

            try
            {
                await HomeConection.InvokeAsync("SiguienteTurno", rol, key, turno);
            }
            catch { }
        }

        #endregion

        #region INFORMAR - Turneros

        #endregion

        #endregion

        #region RECEPCION DE MENSAJES

        private async void Home_Load(object sender, EventArgs e)
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

            #region IMAGE-COM

            HomeConection.On<string, string>("RecibirImagen", (img, rolx) =>
            {
                switch (rolx.ToString())
                {
                    case "Capitan":
                        if (this.pantallaWeb1.InvokeRequired)
                        {
                            try
                            {
                                pantallaWeb1.Invoke(new Action(() => pantallaWeb1.RecibirFrame(img.ToString())));
                            }
                            catch { }
                        }
                        break;

                    case "Carpintero":
                        if (this.pantallaWeb2.InvokeRequired)
                        {
                            try
                            {
                                pantallaWeb2.Invoke(new Action(() => pantallaWeb2.RecibirFrame(img.ToString())));
                            }
                            catch { }
                        }
                        break;

                    case "Mercader":
                        if (this.pantallaWeb3.InvokeRequired)
                        {
                            try
                            {
                                pantallaWeb3.Invoke(new Action(() => pantallaWeb3.RecibirFrame(img.ToString())));
                            }
                            catch { }
                        }
                        break;

                    case "Artillero":
                        if (this.pantallaWeb4.InvokeRequired)
                        {
                            try
                            {
                                pantallaWeb4.Invoke(new Action(() => pantallaWeb4.RecibirFrame(img.ToString())));
                            }
                            catch { }
                        }
                        break;

                    default:

                        break;
                }
            });
            #endregion

            #region TURNERO-COM

            HomeConection.On<string, string, string>("RecibirTurno", (rol, key, turno) =>
            {
                int turnox = int.Parse(turno);
                this.Key = int.Parse(key);

                if (this.Rol == rol) //Si el mensaje es para mi rol
                {
                    switch (this.Key)
                    {
                        case 1:
                            if (this.dados1.InvokeRequired)
                            {
                                try
                                {
                                    dados1.Invoke(new Action(() => dados1.setEnable(true)));
                                }
                                catch { }
                            }
                            break;


                        case 0:
                            if (this.dados1.InvokeRequired)
                            {
                                try
                                {
                                    dados1.Invoke(new Action(() => dados1.setEnable(false)));
                                }
                                catch { }
                            }
                            break;
                    }
                }
                else // osea, si no es mi rol
                {
                    if (this.turno != turnox)  //Pero el turno cambio!!
                    {
                        try 
                        {
                            if (this.dados1.InvokeRequired)
                            {
                                try
                                {
                                    dados1.Invoke(new Action(() => dados1.tirar()));
                                }
                                catch { }
                            }
                        }
                        catch{ }
                    }
                }

                
            });
            #endregion
        }

        #endregion

        #endregion


        /// ///////////////////////////////////////////////////////////////

        #region LOADS

        //Funcion llamada desde la pantalla anterior, para definir el rol y el avatar del cliente.
        public void AsignarAvatar(Image avatar,string rol) 
        {
            this.Rol = rol;
            this.miAvatar = avatar;

            switch (rol)
            {
                case "Capitan":
                    this.Key = 1;
                    this.pantallaWeb1.CargarAvatar(this.miAvatar);
                    break;

                case "Carpintero":
                    this.pantallaWeb2.CargarAvatar(this.miAvatar);
                    break;

                case "Mercader":
                    this.pantallaWeb3.CargarAvatar(this.miAvatar);
                    break;

                case "Artillero":
                    this.pantallaWeb4.CargarAvatar(this.miAvatar);
                    break;
            }
        }

        private void barco1_Load(object sender, EventArgs e)
        {

        }

        private void dados1_Load(object sender, EventArgs e)
        {

        }
        #endregion


        ///////////////////////////////////////////////////////////////////
        public int obtenerTurno(int turnoActual)
        {
            /*
             * PARA UTILIZAR ESTO, SERIA ALGO ASI:
             * SWITCH(obtenerTurno(this.turno))
             * {
             *  case 1:
             *      if (this.rol = "Capitan")
             *      {
             *          //habilita control de dados..
             *      }
             *      break;
             *  case 2:
             *      break;
             *  case 3:
             *      break;
             *  case 4:
             *      break;
             * }
             * 
             */

            int turnoDevuelto = turnoActual;
            if(turnoDevuelto > 4)
            {
                turnoDevuelto = turnoActual - 4;
                return obtenerTurno(turnoDevuelto);
            }
            else
            {
                return turnoDevuelto;
            }
        }

    }
}
