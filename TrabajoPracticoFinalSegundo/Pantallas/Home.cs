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
using System.CodeDom;
using System.Drawing.Text;
using Emgu.CV.Features2D;
using Emgu.CV.Util;
using System.Runtime.CompilerServices;

namespace TrabajoPracticoFinalSegundo.Pantallas
{
    public partial class Home : Form
    {

        private string _url = "https://localhost:7170/Hubs/HomeHub.cs";
        HubConnection HomeConection;

        string Rol;
        Image miAvatar;
        string path;
        int Key;
        int turno;
        int accionHome;
        int votosRonda;
        int desicionCapitan;
        string eventoRandom;
        int segundos;

        //Esto Es un comentario.

        public Home()
        {
            InitializeComponent();

            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();
            this.accionHome = 1;
            this.segundos= 0;

            #region LOADS DE COMPONENTES 

            //PANTALLAS WEB
            this.pantallaWeb1.WebLoad();
            this.pantallaWeb2.WebLoad();
            this.pantallaWeb3.WebLoad();

            int x = (this.Width / 2);
            int y = (this.Height / 2);

            //RECURSOS
            this.recursosDisplay1.LoadRecursos(flowLayoutPanel4.Width, flowLayoutPanel4.Height);

            //BARCO

            this.barco1.loadBarco(this.flowLayoutPanel6.Width,this.flowLayoutPanel6.Height);
            this.barco2.loadBarco(this.flowLayoutPanel6.Width, this.flowLayoutPanel6.Height);
            this.barco2.Visible= false;
            this.BackgroundImage = Image.FromFile(this.path + @"\Recursos\Fondos\FondoHomeDos.jpg");

            //BARRA (INFERIOR)
            x = Convert.ToInt32(this.flowLayoutPanel1.Width / 3);
            y = this.flowLayoutPanel1.Height;

            
            this.turnero1.LoadTurnero(x, y);
            this.dados1.CargarTablero(x+100, y);

            //PROGRESSBAR
            this.progress.Width = this.Width;
            this.progress.Visible = true;
            this.progress.Minimum = 1;
            this.progress.Maximum = 100;
            this.progress.Value = 1;
            this.progress.Step = 1;
            #endregion

            this.turno = turnero1.getTurno();

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
            switch (accionHome) 
            {
                case 1:
                    this.notificador1.Mensaje("ORDENES CAPITAN!");
                    if (this.Rol == "Capitan")
                    {
                        Desicion();
                    }
                    break;

                case 2:
                    if (this.Rol != "Capitan")
                    {
                        Votacion();
                    }
                    else 
                    {
                        this.notificador1.Mensaje("Tus tripulantes estan decidiendo");
                    }
                    break;

                case 3:
                    if (votosRonda == 0)
                    {
                        EjecutarDesicion();
                    }
                    votosRonda = 0;
                    break;

                case 4:
                    EventoRandom();
                    HacerPaso();
                    break;

                case 5:
                    this.notificador1.Mensaje("El capitan debe decidir");
                    if (this.Rol == "Capitan")
                    {
                        Desicion();
                    }
                    break;

                case 6:
                    this.notificador1.Mensaje("Ronda de dados");
                    if (this.Rol == "Capitan")
                    {
                        this.dados1.setEnable(true);
                    }
                    this.accionHome = 1;
                    break;

            }
        }

        private void Update500ms_Tick(object sender, EventArgs e)
        {
            //Compartimos la informacion
            mandarImagenes();
            mandarInfoDados();
            this.segundos++;
        }

        private void Desicion() 
        {
            this.Update.Stop();
            if (this.Rol == "Capitan") 
            {
                do
                {
                    this.desicionCapitan = this.urnaCapitan1.ConsultarDesicion();
                } while (this.urnaCapitan1.ConsultarDesicion() == 0);
                this.urnaCapitan1.ReiniciarDesicion();
            }
            this.accionHome++;
            this.Update.Start();
        }

        private void EjecutarDesicion() 
        {
            switch(this.desicionCapitan)
            {
                case 1:
                    this.notificador1.Mensaje("El capitan dice: Al NORTE!");
                    break;

                case 2:
                    this.notificador1.Mensaje("El capitan dice: Al ESTE!");
                    break;

                case 3:
                    this.notificador1.Mensaje("El capitan dice: Al OESTE!");
                    break;

                case 4:
                    this.notificador1.Mensaje("El capitan dice: Al SUR!");
                    break;
            }
        }

        private void Votacion()
        {
            this.Update.Stop();
            this.notificador1.Mensaje("Consejo de Tripulantes");
            if (this.Rol != "Capitan") 
            {
                /*
                do
                {
                } while (this.urna1.ConsultarVoto() != 9);
                this.votosRonda += this.urna1.ConsultarVoto();
                this.urna1.reiniciarVoto();
                */
            }
            this.accionHome++;
            this.Update.Start();
        }

        private void EventoRandom() 
        {
            this.Update.Stop();
            Random x = new Random();
            int evento = x.Next(1, 3);

            switch (evento) 
            {
                case 1:
                    Viajar();
                    EncontrarIsla();
                    break;

                case 2:
                    Viajar();
                    EncontrarBarco();
                    break;

                case 3:
                    Viajar();
                    EncontrarMar();
                    break;
            }
            this.accionHome++;
            this.Update.Start();
        }

        private void Viajar() 
        {
            int cont = this.segundos;
            //this.BackgroundImage = giff;
            this.notificador1.Mensaje("Viajando");
            do
            {
            } while (cont + 10 != this.segundos);
        }

        private void EncontrarBarco() 
        {
            this.eventoRandom = "Barco";
            this.barco2.Visible = true;
            
        }

        private void EncontrarIsla() 
        {
            this.eventoRandom = "Isla";
            //this.BackgroundImage = fondo con isla
        }

        private void EncontrarMar() 
        {
            this.eventoRandom = "Nada";
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
            if (this.dados1.getEnable()) 
            {
                this.dados1.tirar();
                this.turnero1.Siguiente();
                this.turno = this.turnero1.getTurno();
                this.dados1.setEnable(false);
            }
        }

        private void ActivarDado(bool activar)
        {
            if (this.dados1.InvokeRequired)
            {
                try
                {
                    dados1.Invoke(new Action(() => dados1.setEnable(activar)));
                }
                catch { MessageBox.Show("No pudo tirar automaticamente los dados."); }
            }
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

        #region ENVIAR - Imagenes
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
            catch {  MessageBox.Show("Error en el envio de imagenes."); }
        }
        #endregion

        #region ENVIAR Click-Dado

        private async void mandarInfoDados()
        {
            string turn = this.turno.ToString();

            try
            {
                await HomeConection.InvokeAsync("SiguienteTurno",turn);
            }
            catch { MessageBox.Show("El cliente no pudo enviar el mensaje (dados)"); }
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

            HomeConection.On<string>("RecibirTurno", (turno) =>
            {
                int turnoX = Convert.ToInt32(turno);

                if (turnoX > this.turno)
                {
                    this.turno = turnoX;

                    if (this.dados1.InvokeRequired)
                    {
                        try
                        {
                            dados1.Invoke(new Action(() => dados1.tirar()));
                        }
                        catch { MessageBox.Show("No pudo tirar automaticamente los dados."); }
                    }

                    if (this.turnero1.InvokeRequired)
                    {
                        try
                        {
                            turnero1.Invoke(new Action(() => turnero1.setTurno(turnoX)));
                        }
                        catch { MessageBox.Show("No pudo cargar el turno en el turnero."); }
                    }
                }


                switch (obtenerTurno(turnoX))
                {
                    case 1:
                        if (this.Rol == "Capitan")
                        {
                            ActivarDado(true);
                        }
                        else 
                        {
                            ActivarDado(false);
                        }
                        break;
                    case 2:
                        if (this.Rol == "Carpintero")
                        {
                            ActivarDado(true);
                        }
                        else
                        {
                            ActivarDado(false);
                        }
                        break;
                    case 3:
                        if (this.Rol == "Mercader")
                        {
                            ActivarDado(true);
                        }
                        else
                        {
                            ActivarDado(false);
                        }
                        break;
                    case 4:
                        if (this.Rol == "Artillero")
                        {
                            ActivarDado(true);
                        }
                        else
                        {
                            ActivarDado(false);
                        }
                        break;
                    default:
                        break;
                }

            });
            #endregion
        }




        #endregion

        #endregion


        /// ///////////////////////////////////////////////////////////////

        #region LOADS

        //Funcion llamada desde la pantalla anterior, para definir el rol y el avatar del cliente.
        public void AsignarAvatar(Image avatar,string rol,bool jugarcam) 
        {
            this.Rol = rol;
            this.miAvatar = avatar;

            switch (rol)
            {
                case "Capitan":
                    this.Key = 1;
                    this.pantallaWeb1.CargarAvatar(this.miAvatar);
                    this.pantallaWeb1.jugarConCamara(jugarcam);
                    this.dados1.setEnable(false);
                    loadUrnas(true);
                    break;

                case "Carpintero":
                    this.Key = 2;
                    this.pantallaWeb2.CargarAvatar(this.miAvatar);
                    this.pantallaWeb2.jugarConCamara(jugarcam);
                    this.dados1.setEnable(false);
                    loadUrnas(false);
                    break;

                case "Mercader":
                    this.Key = 3;
                    this.pantallaWeb3.CargarAvatar(this.miAvatar);
                    this.pantallaWeb3.jugarConCamara(jugarcam);
                    this.dados1.setEnable(false);
                    loadUrnas(false);
                    break;

                case "Artillero":
                    this.Key = 4;
                    this.pantallaWeb4.CargarAvatar(this.miAvatar);
                    this.pantallaWeb4.jugarConCamara(jugarcam);
                    this.dados1.setEnable(false);
                    loadUrnas(false);
                    break;
            }
        }

        private void loadUrnas(bool x) 
        {
            int width = Convert.ToInt32(this.flowLayoutPanel1.Width / 3);
            int heigh = this.flowLayoutPanel1.Height;

            if (x)
            {
                this.urnaCapitan1.Enabled = true;
                this.urnaCapitan1.Visible = true;
                this.urnaCapitan1.Load_UrnaCapitan(width, heigh);
                this.urna1.Enabled = false;
                this.urna1.Visible = false;
            }
            else 
            {
                this.urnaCapitan1.Enabled = false;
                this.urnaCapitan1.Visible = false;
                this.urna1.Load_Urna(width,heigh);
                this.urna1.Enabled = true;
                this.urna1.Visible = true;
            }
            
        }
        private void barco1_Load(object sender, EventArgs e)
        {

        }

        private void dados1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        public int obtenerTurno(int turnoActual)
        {
            int turnoDevuelto = turnoActual;
            if (turnoDevuelto > 4)
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
