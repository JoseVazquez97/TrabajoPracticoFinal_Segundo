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

        #region ATRIBUTOS DEL FORM CLIENTE

        private string _url = "https://localhost:7170/Hubs/HomeHub.cs";
        HubConnection HomeConection;

        string Rol;
        Image miAvatar;
        string path;
        string eventoRandom;
        string eventoRandomActual;

        bool checkRendimiento;
        bool accionRealizada;
        
        int Key;
        int turno;
        int accionHome;
        int votosRonda;
        int desicionCapitan;
        int eventoActual;
        int segundos;
        private string val1;
        private string val2;

        #endregion

        public Home()
        {
            InitializeComponent();

            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();

            #region ASIGNACION DE PARAMETROS INICIALES
            this.eventoActual = 1;
            this.segundos= 0;
            this.eventoRandom = "Null";
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.checkRendimiento = false;
            this.accionRealizada = false;
            #endregion

            #region LOADS DE COMPONENTES 

            //FONDO
            this.BackgroundImage = Image.FromFile(this.path + @"\Recursos\Fondos\FondoHomeDos.jpg");
            this.pBox_Fondo.Width = this.Width - this.flowLayoutPanel2.Width -this.flowLayoutPanel3.Width;
            this.pBox_Fondo.Height = this.Height - this.flowLayoutPanel4.Height - this.flowLayoutPanel1.Height;
            int loc1 = this.flowLayoutPanel2.Width;
            int loc2 = this.flowLayoutPanel4.Height;
            this.pBox_Fondo.Location = new Point(loc1,loc2);
            this.pBox_Fondo.BackColor = Color.Transparent;
            this.pBox_Fondo.Parent = this;

            //PANTALLAS WEB
            this.pantallaWeb1.WebLoad();
            this.pantallaWeb2.WebLoad();
            this.pantallaWeb3.WebLoad();

            int x = (this.Width / 2);
            int y = (this.Height / 2);

            //RECURSOS
            this.recursosDisplay1.LoadRecursos(flowLayoutPanel4.Width, flowLayoutPanel4.Height);

            //BARCO

            x = this.Width - 325 - 70;

            this.barco1.loadBarco();
            this.barco2.loadBarcoEnemigo();
           
            this.barco2.Visible = false;
            this.barco1.Parent = this.pBox_Fondo;
            this.barco2.Parent = this.pBox_Fondo;

            //BARRA (INFERIOR)
            x = Convert.ToInt32(this.flowLayoutPanel1.Width / 3);
            y = this.flowLayoutPanel1.Height;
            
            //TURNERO
            this.turnero1.LoadTurnero(x, y);

            //DADOS
            this.dados1.CargarTablero(x+100, y);

            //PROGRESSBAR
            this.progress.Width = this.Width;
            this.progress.Visible = true;
            this.progress.Minimum = 1;
            this.progress.Maximum = 100;
            this.progress.Value = 1;
            this.progress.Step = 1;

            //NOTIFICADORES
            Point locati;
            this.flowLayoutPanel2.Parent = this;

            this.noti_Cap.Load_Notificador();
            this.noti_Cap.Visible = false;
            this.noti_Cap.Parent = this;
            locati = this.pantallaWeb1.Location;
            this.noti_Cap.Location = new Point(locati.X + 255, locati.Y + 20);

            this.noti_Carp.Load_Notificador();
            this.noti_Carp.Visible = true;
            this.noti_Carp.Parent = this;
            locati = this.pantallaWeb2.Location;
            this.noti_Carp.Location = new Point(locati.X + 255, locati.Y+20);
            this.noti_Carp.Mensaje("Ordenes capitan!");

            this.noti_Mer.Load_Notificador();
            this.noti_Mer.Visible = false;
            this.noti_Mer.Parent = this;
            locati = this.pantallaWeb3.Location;
            this.noti_Mer.Location = new Point(locati.X + 255, locati.Y + 20);

            this.noti_Ar.Load_Notificador();
            this.noti_Ar.Visible = false;
            this.noti_Ar.Parent = this;
            locati = this.pantallaWeb4.Location;
            this.noti_Ar.Location = new Point(locati.X + 255, locati.Y + 20);

            //ESCRUTINIO
            this.turno = turnero1.getTurno();
            this.escrutinio1.loadEscrutinio(this.flowLayoutPanel5.Width);
            this.escrutinio1.Visible = false;

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
        }

        private void Update500ms_Tick(object sender, EventArgs e)
        {
            //Compartimos la informacion
            mandarInfoTurnero();
            mandarImagenes();
            mandarInfoDados();
            mandarInfoEvento();
            mandarInfoVoto();
            mandarInfoEventoRandom();
            mandarInfoDesicion();
            this.segundos++;
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

        private async void mandarInfoTurnero()
        {
            string turn = this.turno.ToString();

            try
            {
                await HomeConection.InvokeAsync("SiguienteTurno",turn);
            }
            catch { MessageBox.Show("El cliente no pudo enviar el mensaje (dados)"); }
        }

        #endregion

        #region INFORMAR - Evento
        private async void mandarInfoEvento()
        {
            string evento = Convert.ToString(this.eventoActual);

            try
            {
                await HomeConection.InvokeAsync("EnviarEvento", evento);
            }
            catch { MessageBox.Show("El cliente no pudo enviar el mensaje (evento)"); }
        }
        #endregion

        #region INFORMAR - Voto
        private async void mandarInfoVoto()
        {
            string voto = "9";
            string rol = this.Rol;

            if (this.urna1.ConsultarVoto() != 9) 
            {
                voto = Convert.ToString(this.urna1.ConsultarVoto());
                this.urna1.reiniciarVoto();
            }
            
            try
            {
                await HomeConection.InvokeAsync("EnviarVoto", rol, voto);
            }
            catch { MessageBox.Show("El cliente no pudo enviar el mensaje (evento)"); }
        }
        #endregion

        #region INFORMAR - Evento Random
        private async void mandarInfoEventoRandom()
        {
            string evento = this.eventoRandom;

            try
            {
                await HomeConection.InvokeAsync("EnviarEventoRandom", evento);
            }
            catch { MessageBox.Show("El cliente no pudo enviar el mensaje (evento)"); }
        }
        #endregion

        #region INFORMAR - Desicion Capitan
        private async void mandarInfoDesicion()
        {
            string orden;
            if (this.Rol == "Capitan")
            {
                orden = Convert.ToString(this.desicionCapitan);
            }
            else { orden = "0"; }
            
            try
            {
                await HomeConection.InvokeAsync("EnviarOrden", orden);
            }
            catch { MessageBox.Show("El cliente no pudo enviar el mensaje (orden)"); }
        }
        #endregion

        #region INFORMAR - Ultimos Dados
        private async void mandarInfoDados()
        {
            string val1 = "0";
            string val2 = "0";
            int leToca;

            if (this.turnero1.getTurno() == 1)
            {
                leToca = obtenerTurno(this.turnero1.getTurno());
            }
            else 
            {
                leToca = obtenerTurno(this.turnero1.getTurno()-1);
            }
            
            switch (leToca) 
            {
                case 1:
                    if (this.Rol == "Capitan") 
                    {
                        if (this.dados1.LISTO)
                        {
                            val1 = Convert.ToString(this.dados1.V1);
                            val2 = Convert.ToString(this.dados1.V2);
                        }
                    }
                    break;
                case 2:
                    if (this.Rol == "Carpintero") 
                    {
                        if (this.dados1.LISTO)
                        {
                            val1 = Convert.ToString(this.dados1.V1);
                            val2 = Convert.ToString(this.dados1.V2);
                        }
                    }
                    
                    break;
                case 3:
                    if (this.Rol == "Mercader")
                    {
                        if (this.dados1.LISTO)
                        {
                            val1 = Convert.ToString(this.dados1.V1);
                            val2 = Convert.ToString(this.dados1.V2);
                        }
                    }
                    break;
                case 4:
                    if (this.Rol == "Artillero")
                    {
                        if (this.dados1.LISTO)
                        {
                            val1 = Convert.ToString(this.dados1.V1);
                            val2 = Convert.ToString(this.dados1.V2);
                        }
                    }
                    break;
            }
                
            try
            {
                await HomeConection.InvokeAsync("EnviarDados", val1,val2);
            }
            catch { MessageBox.Show("El cliente no pudo enviar el mensaje (orden)"); }
        }
        #endregion

        #endregion

        ////////////////////////////////////////////////////

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

                if (this.eventoActual == 4) //Si el evento es el evento de guerra.
                {
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
                }

            });
            #endregion

            #region DADOS-COM
            HomeConection.On<string, string>("RecibirDados", (val1, val2) =>
            {
                if (val1 != "0" && val2 != "0") 
                {
                    if (this.dados1.InvokeRequired)
                    {
                        if (this.dados1.LISTO)
                        {
                            try
                            {
                                dados1.Invoke(new Action(() => dados1.AsignarValores(val1, val2)));
                            }
                            catch { }
                        }
                    }
                }
            });
            #endregion

            #region EVENTO ACTUAL

            HomeConection.On<string>("RecibirEvento", (evento) =>
            {

                if ((int.Parse(evento) > this.eventoActual) || (this.eventoActual == 7 && int.Parse(evento) == 1) || (this.eventoActual == 1 && this.Rol == "Capitan") || (this.eventoActual == 2) || (this.eventoActual == 3))
                {
                    if (this.eventoActual < int.Parse(evento) || this.eventoActual == 7 && int.Parse(evento) == 1) 
                    {
                        this.eventoActual = Convert.ToInt32(evento);
                    }

                    switch (this.eventoActual)
                    {
                        #region DESICION CAPITAN DIRECCION
                        case 1:
                            if (this.urnaCapitan1.ConsultarDesicion() != 0) 
                            {
                                this.desicionCapitan = this.urnaCapitan1.ConsultarDesicion();
                                this.eventoActual++;

                                if (this.noti_Carp.InvokeRequired)
                                {
                                    try 
                                    {
                                        noti_Carp.Invoke(new Action(() => { noti_Carp.Visible = false; }));
                                    } catch { }
                                }

                                if (this.noti_Cap.InvokeRequired)
                                {
                                    try
                                    {
                                        noti_Cap.Invoke(new Action(() => { noti_Cap.Visible = true; }));
                                    }
                                    catch { }
                                }

                                switch (this.desicionCapitan) 
                                {
                                    case 1:
                                        if (this.noti_Cap.InvokeRequired)
                                        {
                                            try
                                            {
                                                noti_Cap.Invoke(new Action(() => { noti_Cap.Mensaje("Al Norte!"); }));
                                            }
                                            catch { }
                                        }
                                        break;
                                    case 2:
                                        if (this.noti_Cap.InvokeRequired)
                                        {
                                            try
                                            {
                                                noti_Cap.Invoke(new Action(() => { noti_Cap.Mensaje("Al Este!"); }));
                                            }
                                            catch { }
                                        }
                                        break;
                                    case 3:
                                        if (this.noti_Cap.InvokeRequired)
                                        {
                                            try
                                            {
                                                noti_Cap.Invoke(new Action(() => { noti_Cap.Mensaje("Al Oeste!"); }));
                                            }
                                            catch { }
                                        }
                                        break;
                                    case 4:
                                        if (this.noti_Cap.InvokeRequired)
                                        {
                                            try
                                            {
                                                noti_Cap.Invoke(new Action(() => { noti_Cap.Mensaje("Al Sur!"); }));
                                            }
                                            catch { }
                                        }
                                        break;
                                }

                            }
                            break;
                        #endregion

                        #region VOTACION DE TRIPULANTES
                        case 2:
                            
                            int resultados = 0;

                            if (this.escrutinio1.InvokeRequired)
                            {
                                try
                                {
                                    escrutinio1.Invoke(new Action(() => escrutinio1.Visible = true));
                                }
                                catch { }
                            }

                            if (this.flowLayoutPanel5.InvokeRequired)
                            {
                                try
                                {
                                    flowLayoutPanel5.Invoke(new Action(() => flowLayoutPanel5.Height = 75));
                                }
                                catch { }
                            }


                            if (this.escrutinio1.InvokeRequired)
                            {
                                try
                                {
                                    escrutinio1.Invoke(new Action(() => resultados = escrutinio1.confirmarVotacion()));
                                }
                                catch { }
                            }

                            if (resultados != 0) 
                            {
                                if (resultados >= 2)
                                {
                                    this.eventoActual++;
                                }
                                else 
                                {
                                    this.eventoActual++;
                                }
                            }
                  
                            break;
                        #endregion

                        #region SELECCION DE EVENTO RANDOM

                        case 3:
                            
                            if (this.checkRendimiento == false) 
                            {
                                if (this.Rol == "Capitan") { EventoRandom(); }


                                if (this.urnaCapitan1.InvokeRequired)
                                {
                                    try
                                    {
                                        urnaCapitan1.Invoke(new Action(() => urnaCapitan1.ReiniciarDesicion()));
                                        urnaCapitan1.Invoke(new Action(() => this.desicionCapitan = urnaCapitan1.ConsultarDesicion()));
                                    }
                                    catch { }
                                }

                                if (this.escrutinio1.InvokeRequired)
                                {
                                    try
                                    {
                                        escrutinio1.Invoke(new Action(() => escrutinio1.reiniciarVotos()));
                                        escrutinio1.Invoke(new Action(() => escrutinio1.reiniciarCheck()));
                                        escrutinio1.Invoke(new Action(() => escrutinio1.Visible = false));
                                    }
                                    catch { }
                                }

                                if (this.noti_Cap.InvokeRequired)
                                {
                                    try
                                    {
                                        noti_Cap.Invoke(new Action(() => { noti_Cap.Visible = false; }));
                                    }
                                    catch { }
                                }

                                if (this.noti_Carp.InvokeRequired)
                                {
                                    try
                                    {
                                        noti_Carp.Invoke(new Action(() => { noti_Carp.Visible = false; }));
                                    }
                                    catch { }
                                }

                                if (this.noti_Mer.InvokeRequired)
                                {
                                    try
                                    {
                                        noti_Mer.Invoke(new Action(() => { noti_Mer.Visible = false; }));
                                    }
                                    catch { }
                                }

                                if (this.noti_Ar.InvokeRequired)
                                {
                                    try
                                    {
                                        noti_Ar.Invoke(new Action(() => { noti_Ar.Visible = false; }));
                                    }
                                    catch { }
                                }

                                if (this.flowLayoutPanel5.InvokeRequired)
                                {
                                    try
                                    {
                                        flowLayoutPanel5.Invoke(new Action(() => { flowLayoutPanel5.Height = 0; }));
                                    }
                                    catch { }
                                }

                                if (this.pBox_Fondo.InvokeRequired)
                                {
                                    try
                                    {
                                        //pBox_Fondo.Invoke(new Action(() => pBox_Fondo.Image = Image.FromFile(this.path + @"\Recursos\Fondos\Viajando.gif")));
                                    }
                                    catch { }
                                }

                                this.checkRendimiento = true;
                                this.eventoActual++;
                            }
                        break;
                        #endregion

                        #region PRIMER TIRADA DE DADOS
                        case 4:
                            this.checkRendimiento = false;

                            switch (this.eventoRandomActual) 
                            {
                                case "Barco":
                                    this.eventoRandomActual = "Barco";
                                    
                                    break;
                            }

                            break;
                        #endregion

                        case 5:

                            break;

                        case 6:

                            break;

                        case 7:

                            break;
                    }
                }
            });

            #endregion

            #region VOTOS-COM

            HomeConection.On<string,string>("RecibirVoto", (rol,voto) =>
            {
                int vValor = int.Parse(voto);

                if (vValor != 9) 
                {
                    if (this.escrutinio1.InvokeRequired)
                    {
                        try
                        {
                            escrutinio1.Invoke(new Action(() => escrutinio1.recibirVoto(rol, vValor)));
                        }
                        catch { MessageBox.Show("No pudo asignar el voto"); }
                    }

                    #region MOSTRAR RESPUESTA!
                    switch (rol)
                    {
                        case "Carpintero":
                            if (vValor == 0)
                            {
                                if (this.noti_Carp.InvokeRequired) 
                                {
                                    try 
                                    {
                                        noti_Carp.Invoke(new Action(() => { noti_Carp.Visible = true; }));
                                        noti_Carp.Invoke(new Action(() => { noti_Carp.Mensaje("Ni loco!"); }));
                                    } catch { }
                                }
                            }
                            else
                            {
                                if (this.noti_Carp.InvokeRequired)
                                {
                                    try
                                    {
                                        noti_Carp.Invoke(new Action(() => { noti_Carp.Visible = true; }));
                                        noti_Carp.Invoke(new Action(() => { noti_Carp.Mensaje("SI CAPITAN!"); }));
                                    }
                                    catch { }
                                }
                            }
                            break;

                        case "Mercader":
                            if (vValor == 0)
                            {
                                if (this.noti_Mer.InvokeRequired)
                                {
                                    try
                                    {
                                        noti_Mer.Invoke(new Action(() => { noti_Mer.Visible = true; }));
                                        noti_Mer.Invoke(new Action(() => { noti_Mer.Mensaje("Ni loco!"); }));
                                    }
                                    catch { }
                                }
                            }
                            else
                            {
                                if (this.noti_Mer.InvokeRequired)
                                {
                                    try
                                    {
                                        noti_Mer.Invoke(new Action(() => { noti_Mer.Visible = true; }));
                                        noti_Mer.Invoke(new Action(() => { noti_Mer.Mensaje("SI CAPITAN!"); }));
                                    }
                                    catch { }
                                }
                            }
                            break;

                        case "Artillero":
                            if (vValor == 0)
                            {
                                if (this.noti_Ar.InvokeRequired)
                                {
                                    try
                                    {
                                        noti_Ar.Invoke(new Action(() => { noti_Ar.Visible = true; }));
                                        noti_Ar.Invoke(new Action(() => { noti_Ar.Mensaje("Ni loco!"); }));
                                    }
                                    catch { }
                                }
                            }
                            else
                            {
                                if (this.noti_Ar.InvokeRequired)
                                {
                                    try
                                    {
                                        noti_Ar.Invoke(new Action(() => { noti_Ar.Visible = true; }));
                                        noti_Ar.Invoke(new Action(() => { noti_Ar.Mensaje("SI CAPITAN!"); }));
                                    }
                                    catch { }
                                }
                            }
                            break;
                    }
                    #endregion
                }

            });
            #endregion

            #region EVENTO RANDOM-COM

            HomeConection.On<string>("RecibirEventoRandom", (evento) =>
            {
                if (this.Rol != "Capitan") { this.eventoRandom = evento; }

                int leToca = 0;
                int aux = 0;
                int val1;
                int val2;


                if (this.turnero1.InvokeRequired)
                {
                    try
                    {
                        turnero1.Invoke(new Action(() => aux = turnero1.getTurno()));
                    }
                    catch { }
                }

                if (aux == 1)
                {
                    leToca = obtenerTurno(aux);
                }
                else
                {
                    leToca = obtenerTurno(aux - 1);
                }
               
                switch (evento)
                {
                    case "Barco":
                        this.eventoRandomActual = "Barco";
                        if (this.barco2.InvokeRequired)
                        {
                            try
                            {
                                barco2.Invoke(new Action(() => barco2.Visible = true));
                            }
                            catch { }
                        }

                        switch (leToca) 
                        {
                            case 1:
                                if (this.Rol == "Capitan") 
                                {

                                }
                            break;

                            case 2:
                                if (this.Rol == "Carpintero")
                                {

                                }
                                break;

                            case 3:
                                if (this.Rol == "Mercader")
                                {

                                }
                                else 
                                {
                                    this.accionRealizada = false;
                                }
                                break;

                            case 4:
                                if (this.Rol == "Artillero")
                                {
                                    if (this.dados1.InvokeRequired) 
                                    {
                                        if (this.dados1.LISTO) 
                                        {
                                            try
                                            {
                                                val1 = this.dados1.V1;
                                                val2 = this.dados1.V2;
                                            }
                                            catch { }

                                            if (this.accionRealizada == false) 
                                            {
                                                if (this.barco2.InvokeRequired)
                                                {
                                                    try
                                                    {
                                                        barco2.Invoke(new Action(() => barco2.RecibirDanio(10)));
                                                        this.accionRealizada = true;
                                                    }
                                                    catch { }
                                                }
                                            }
                                            
                                        }
                                    }
                                }
                                break;
                        }

                        break;
                    case "Isla":
                        break;
                    case "Nada":
                        break;
                    case "Null":
                        break;
                }
            });
            #endregion

            #region DESICION CAPITAN

            HomeConection.On<string>("RecibirOrden", (orden) =>
            {
                if (orden != "Null" && orden != "0") 
                {
                    switch (orden) 
                    {
                        case "1":
                            if (this.noti_Cap.InvokeRequired)
                            {
                                try
                                {
                                    noti_Cap.Invoke(new Action(() => { noti_Cap.Visible = true; }));
                                    noti_Cap.Invoke(new Action(() => { noti_Cap.Mensaje("Al Norte!"); }));
                                }
                                catch { }
                            }
                            break;
                        case "2":
                            if (this.noti_Cap.InvokeRequired)
                            {
                                try
                                {
                                    noti_Cap.Invoke(new Action(() => { noti_Cap.Visible = true; }));
                                    noti_Cap.Invoke(new Action(() => { noti_Cap.Mensaje("Al Este!"); }));
                                }
                                catch { }
                            }
                            break;
                        case "3":
                            if (this.noti_Cap.InvokeRequired)
                            {
                                try
                                {
                                    noti_Cap.Invoke(new Action(() => { noti_Cap.Visible = true; }));
                                    noti_Cap.Invoke(new Action(() => { noti_Cap.Mensaje("Al Oeste!"); }));
                                }
                                catch { }
                            }
                            break;
                        case "4":
                            if (this.noti_Cap.InvokeRequired)
                            {
                                try
                                {
                                    noti_Cap.Invoke(new Action(() => { noti_Cap.Visible = true; }));
                                    noti_Cap.Invoke(new Action(() => { noti_Cap.Mensaje("Al Sur!"); }));
                                }
                                catch { }
                            }
                            break;
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

        private void loadUrnas(bool x) //Funcion para hacer los componentes del hud responsivos.
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

        /// ////////////////////////////////////////////////////////////////

        #region FUNCIONES PRIVADAS DEL FORM
        private int obtenerTurno(int turnoActual)
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

        private void EventoRandom()
        {
            Random x = new Random();
            int evento = x.Next(1, 5);

            switch (2)
            {
                case 1:
                    EncontrarIsla();
                    break;

                case 2:
                    EncontrarBarco();
                    break;

                case 3:
                    EncontrarMar();
                    break;

                case 4:
                    this.eventoRandom = "Null";
                    break;
            }
        }

        private void Viajar()
        {
            this.eventoRandom = "Viajando";
        }

        private void EncontrarBarco()
        {
            this.eventoRandom = "Barco";
        }

        private void EncontrarIsla()
        {
            this.eventoRandom = "Isla";
        }

        private void EncontrarMar()
        {
            this.eventoRandom = "Mar";
        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

    }
}
