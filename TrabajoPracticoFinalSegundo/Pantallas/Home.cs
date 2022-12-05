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

        private string _url = "https://localhost:7170/homeHubNew";
        HubConnection HomeConection;

        private string Rol;
        private Image miAvatar;
        private bool conectado;

        private int Key;
        private int Turno;
        private string bar1;
        private string bar2;
        private string eventoActual;
        private string notificacion;
        private string accionBot;

        private bool enventoFlag; //Flag de evento
        private bool accionFlag; //Flag de danio
        private bool eFlag; //Flag de evento random
        private bool movFlag; // Flag de movimiento
        private bool mFlag; // Flag de mapa

        private string val1;
        private string val2;
        private string estadoBarco;
        private string estadoBarco2;

        #endregion

        public Home()
        {
            InitializeComponent();
            this.conectado = false;

            #region ASIGNACION DE PARAMETROS INICIALES
            this.eventoActual = "Orden";
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.notificacion = "1";
            this.movFlag = false;
            this.mFlag = false;
            this.eFlag = false;
            this.enventoFlag = false;
            this.accionFlag = false;
            this.val1 = "0";
            this.val2 = "0";
            #endregion

            #region LOADS DE COMPONENTES 
            //FlowLayout4 (Recursos y escrutinio)
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding() { Left = this.flowLayoutPanel4.Width / 3 + 100 };

            //FONDOS
            this.BackgroundImage = Image.FromFile(@".\Recursos\Fondos\Madera.jpg");
            Navio_Page.BackgroundImage = Image.FromFile(@".\Recursos\Fondos\FondoHomeDos.jpg");
            Navegacion_Page.BackgroundImage = Image.FromFile(@".\Recursos\Fondos\mapax.png");
            int loc1 = this.flowLayoutPanel2.Width;
            int loc2 = this.flowLayoutPanel4.Height;
            this.Barco_Page.SelectTab(0);

            //PANTALLAS WEB
            this.pantallaWeb1.WebLoad();
            this.pantallaWeb2.WebLoad();
            this.pantallaWeb3.WebLoad();

            int x = (this.Width / 2);
            int y = (this.Height / 2);

            //RECURSOS Y CAMBIOS DE PAG
            this.recursosDisplay1.LoadRecursos(flowLayoutPanel4.Width, flowLayoutPanel4.Height);

            //BARCOS
            this.barco1.loadBarco(ref this.recursosDisplay1);
            this.barco2.loadBarcoEnemigo();
            this.barco2.Visible = false;

            //BARRA (INFERIOR)
            x = Convert.ToInt32(this.flowLayoutPanel1.Width / 3);
            y = this.flowLayoutPanel1.Height;

            //TURNERO
            this.turnero1.LoadTurnero(x, y);

            //DADOS
            this.dados1.CargarTablero(x + 100, y);


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
            this.noti_Carp.Location = new Point(locati.X + 255, locati.Y + 20);
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
            this.Turno = turnero1.getTurno();
            this.escrutinio1.loadEscrutinio(this.flowLayoutPanel4.Width);
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

        #region JUEGO

        #region UPDATE-GAME (LOOP PRINCIPAL)
        private void Update500ms_Tick(object sender, EventArgs e)
        {
            if (conectado)
            {
                mandarImagenes();
                this.notificacion = ConsultarDesicion();

                switch (this.eventoActual)
                {
                    case "Orden":
                        EnviarEstadoSR();
                        if (this.Key == 1)
                        {
                            if (!this.mFlag)
                            {
                                ucMapa1.CargarImagenBarco();
                                EnviarCambiosMapa();
                                this.mFlag = true;
                            }
                        }
                        else
                        {
                            if (!this.mFlag)
                            {
                                ConsultarMapa();
                                ucMapa1.CargarImagenBarco();
                                this.mFlag = true;
                            }
                        }
                        break;

                    case "Votacion":
                        EnviarEstadoSR();
                        break;

                    case "Batalla":
                        if (this.Key == 1 && !this.eFlag)
                        {
                            string envetoRandom = enventoRandom();

                            EnviarEventoX(envetoRandom);

                            this.eFlag = true;
                        }

                        if (!this.enventoFlag)
                        {
                            ConsultarEve();
                            this.enventoFlag = true;
                        }

                        HabilitarDados();

                        if (this.dados1.getEnable())
                        {
                            if (this.dados1.LISTO)
                            {
                                this.dados1.LISTO = false;
                                EnviarDadosCL();
                            }
                        }
                        else
                        {
                            if (this.dados1.LISTO)
                            {
                                ConsultarDadosCL();
                            }
                        }

                        ConsultarEB();
                        EnviarEstadoSR();
                        break;
                }
            }
        }
        #endregion

        #region IMPACTAR EN FORM
        private void ImpactarEnCliente(string user, List<string> parametros)
        {
            // Index de parametros
            // 0.Turno , 1.Notificacion , 2.EventoActual

            int key = int.Parse(user);
            int turno = int.Parse(parametros[0]);
            int noti = int.Parse(parametros[1]);

            #region EVENTO ORDEN
            if (this.Turno < turno) //Si el turno de este cliente es menor del que me llega sucedio algo...
            {
                if (this.eventoActual == "Orden" && this.eventoActual == parametros[2]) //Si estamos en el evento orden
                {
                    this.Turno = turno; //Igualamos el turno

                    if (user == "1") //Y si el capitan nos envia mensaje.
                    {
                        if (this.Key != 1)
                        {
                            SiguienteTurno();
                        }

                        if (noti != 0)
                        {
                            NotificarOrdenCap(noti);
                        }

                        SpawnearNoti(1, true);
                        SpawnearNoti(2, false);
                        SpawnearNoti(3, false);
                        SpawnearNoti(4, false);
                        SwitchUrnaCap(true);

                        this.eventoActual = "Votacion";
                    }
                }
            }
            #endregion

            #region EVENTO VOTACION
            if (parametros[2] == "Votacion" && parametros[2] == this.eventoActual)
            {
                SwitchEscrutinio(true); //Cambia el user control de recursos por el de votacion.

                #region actualizacion de urna //Escribe los mensajes Si capitan y No capitan en la urna1
                switch (this.Key)
                {
                    case 2:
                        MensajesVotacion();
                        break;

                    case 3:
                        MensajesVotacion();
                        break;

                    case 4:
                        MensajesVotacion();
                        break;

                    default:
                        break;
                }
                #endregion

                if (noti != 0)
                {
                    switch (user)
                    {
                        case "2":
                            RecibirNotificacion(key, noti);
                            SiguienteTurno();
                            CargarVoto(1, noti);
                            break;

                        case "3":
                            RecibirNotificacion(key, noti);
                            SiguienteTurno();
                            CargarVoto(2, noti);
                            break;

                        case "4":
                            RecibirNotificacion(key, noti);
                            SiguienteTurno();
                            CargarVoto(3, noti);
                            break;
                    }

                    if (this.escrutinio1.confirmarVotacion() != 0)
                    {
                        this.eventoActual = "Batalla";

                        if (this.Key == 1)
                        {
                            int x = urnaCapitan1.ConsultarDesicion();
                            EnviarMovimiento(x);
                        }
                        else
                        {
                            ConsultarMovimiento();
                        }

                        SwitchEscrutinio(false);
                        this.escrutinio1.reiniciarVotos();
                        this.escrutinio1.reiniciarCheck();
                        this.notificacion = "0";
                        QuitarTodasLasNotis();
                    }
                }
            }
            #endregion

            #region EVENTO BATALLA
            if (parametros[2] == "Batalla" && parametros[2] == this.eventoActual)
            {
                if (turno > this.Turno && key == obtenerTurno(this.turnero1.getTurno()) && obtenerTurno(turno) != 1)
                {
                    this.Turno = turno;

                    try
                    {
                        this.turnero1.Invoke(new Action(() => this.turnero1.setTurno(turno)));
                    }
                    catch { }

                    try
                    {
                        this.dados1.Invoke(new Action(() => this.dados1.tirar()));
                    }
                    catch { }
                }

                if (noti != 0)
                {
                    RecibirNotificacion(key, noti);
                }
            }
            #endregion
        }
        #endregion

        #region GENERAR - MENSAJE
        private string GenerarEstado()
        {
            string mensaje = "";

            switch (this.eventoActual) //Segun el evento donde me encuentro
            {
                case "Orden":
                    if (this.Key == 1)
                    {
                        this.notificacion = this.urnaCapitan1.ConsultarDesicion().ToString();
                        this.urna1.reiniciarVoto();
                    }
                    break;

                case "Votacion":
                    this.notificacion = this.urna1.ConsultarVoto().ToString();
                    this.urna1.reiniciarVoto();
                    break;

                case "Batalla":
                    break;
            }

            mensaje = this.turnero1.getTurno().ToString() + ";" + this.notificacion + ";" + this.eventoActual + ";";
            return mensaje;
        }
        #endregion

        #endregion

        #region SIGNAL R

        #region ENVIO DE MENSAJES Y CONSULTAS

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
            catch { MessageBox.Show("Error en el envio de imagenes."); }
        }
        #endregion

        #region ENVIAR - EstadoActual
        private async void EnviarEstadoSR()
        {
            string usr = this.Key.ToString();
            string msg = GenerarEstado();

            try
            {
                await HomeConection.InvokeAsync("EnviarEstado", usr, msg);
            }
            catch { MessageBox.Show("Error en el envio de Estado."); }
        }
        #endregion


        #region ENVIAR - Mapa
        private async void EnviarCambiosMapa()
        {
            string usr = this.Key.ToString();
            string mapa = ucMapa1.ObtenerMapa();

            try
            {
                await HomeConection.InvokeAsync("EnviarMapa", usr, mapa);
            }
            catch { MessageBox.Show("Error en el envio del Mapa."); }

        }
        #endregion

        #region CONSULTAR - Mapa
        private async void ConsultarMapa()
        {
            try
            {
                await HomeConection.InvokeAsync("ConsultarMap");
            }
            catch { MessageBox.Show("Error en la consulta del mapa"); }
        }
        #endregion


        #region ENVIAR - Dados
        private async void EnviarDadosCL()
        {
            string usr = this.Key.ToString();
            string val1 = "";
            string val2 = "";

            val1 = this.dados1.V1.ToString();
            val2 = this.dados1.V2.ToString();

            if (val1 != "0" && val2 != "0" && this.Key == obtenerTurno(this.turnero1.getTurno()))
            {
                try
                {
                    await HomeConection.InvokeAsync("EnviarDados", usr, val1, val2);
                }
                catch { MessageBox.Show("Error en el envio de dados."); }
            }
        }

        private async void ConsultarDadosCL()
        {
            if (this.Key != obtenerTurno(this.turnero1.getTurno()))
            {
                try
                {
                    await HomeConection.InvokeAsync("ConsultarDados");
                }
                catch { MessageBox.Show("Error al consultar los dados."); }
            }
        }

        #endregion


        #region ENVIAR - DesicionCap
        private async void EnviarMovimiento(int x)
        {
            string mov = x.ToString();

            try
            {
                await HomeConection.InvokeAsync("EnviarMov", mov);
            }
            catch { MessageBox.Show("Error en el envio del Movimiento."); }
        }
        #endregion

        #region CONSULTAR - DesicionCap
        private async void ConsultarMovimiento()
        {
            try
            {
                await HomeConection.InvokeAsync("ConsultarMov");
            }
            catch { MessageBox.Show("Error en la consulta del Movimiento"); }
        }
        #endregion


        #region ENVIAR - Evento
        private async void EnviarEventoX(string x)
        {
            try
            {
                await HomeConection.InvokeAsync("EnviarEvento", x);
            }
            catch { MessageBox.Show("Error en el envio del Evento."); }
        }
        #endregion

        #region CONSULTAR - Evento
        private async void ConsultarEve()
        {
            try
            {
                await HomeConection.InvokeAsync("ConsultarEv");
            }
            catch { MessageBox.Show("Error en la consulta del Ev"); }
        }
        #endregion

        #region ENVIAR - Barcos
        private async void EnviarEB() 
        {
            string b1 = this.barco1.ConsultarEstado();
            string b2 = this.barco2.ConsultarEstado();

            try
            {
                await HomeConection.InvokeAsync("EnviarBarcos",b1,b2);
            }
            catch { MessageBox.Show("Error en la consulta del Ev"); }
        }
        #endregion

        #region CONSULTAR - Barcos
        private async void ConsultarEB()
        {

            try
            {
                await HomeConection.InvokeAsync("ConsutarBarcos");
            }
            catch { MessageBox.Show("Error en la consulta del Ev"); }
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

            this.conectado = true;

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

            #region MAPA-COM
            HomeConection.On<string, string>("RecibirMapa", (key, mapa) =>
            {
                
            });
            
            HomeConection.On<string>("RecibirCMapa", (mapa) =>
            {
                try
                {
                    this.ucMapa1.Invoke(new Action(() => this.ucMapa1.CargarMapa(mapa)));
                }
                catch { MessageBox.Show("No pudo asignar el mapa!"); }
            });
            #endregion

            #region ESTADO-COM

            HomeConection.On<string, string>("RecibirEstado", (usr, msg) =>
            {
                List<string> parametros = obternerParam(msg);

                ImpactarEnCliente(usr, parametros);
            });
            #endregion

            #region DADOS-COM
            HomeConection.On<string, string, string>("RecibirDados", (usr, val1, val2) =>
            {
                AccionesDados(val1, val2);
                EnviarEB();
            });

            HomeConection.On<string, string>("RecibirCDados", (val1, val2) =>
            {
                if (this.dados1.LISTO) 
                {
                    try
                    {
                        this.dados1.Invoke(new Action(() => this.dados1.AsignarValores(val1, val2)));
                    }
                    catch { MessageBox.Show($"Error al cargar los valores {val1} y {val2} en los dados"); }
                }
                
            });
            #endregion

            #region MOVIMIENTO-COM

            HomeConection.On<string>("RecibirMov", (mapa) =>
            {

            });

            HomeConection.On<string>("RecibirCMov", (mov) =>
            {
                try 
                {
                    int x = 0;
                    x = int.Parse(mov);

                    if (!movFlag)
                    {
                        try
                        {
                            this.ucMapa1.Invoke(new Action(() => this.ucMapa1.Movimiento(x)));
                            this.movFlag = true;
                        }
                        catch { MessageBox.Show("No pudo mostrarse el mapa"); }
                    }
                }
                catch { ConsultarMovimiento(); }
            });

            #endregion

            #region EVENTO-COM

            HomeConection.On<string>("RecibirEvento", (val2) =>
            {
            });

            HomeConection.On<string>("RecibirCEvento", (val1) =>
            {
                try
                {
                    switch (val1)
                    {
                        case "M10":
                            this.eventoActual = "Orden";
                            break;

                        case "M11":
                            try
                            {
                                this.barco2.Invoke(new Action(() => this.barco2.Visible = true));
                            }
                            catch { }
                            break;
                    }
                }
                catch { MessageBox.Show(val1); }
                
            });

            #endregion

            #region BARCOS-COM
            HomeConection.On<string, string>("RecibirBarcos", (val1, val2) =>
            {


            });

            HomeConection.On<string, string>("RecibirCBarcos", (val1, val2) =>
            {
                try
                {
                    this.barco1.Invoke(new Action(() => this.barco1.RecibirEstado(val1)));
                }
                catch { MessageBox.Show("No se pudo asignar el estado al barco1 {0}", val1); }

                try
                {
                    this.barco2.Invoke(new Action(() => this.barco2.RecibirEstado(val2)));
                }
                catch { MessageBox.Show("No se pudo asignar el estado al barco2 {0}", val2); }

            });
            #endregion

        }

        #endregion

        #endregion

        /// 
        ///    
        ///       FUNCIONES PRIVADAS DEL FORM!
        /// 
        /// 

        #region FUNCIONES PRIVADAS DEL FORM

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

        #region ASIGNACION AVATAR
        public void AsignarAvatar(Image avatar, string rol, bool jugarcam) //Funcion ejecutada desde la pantalla anterior
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
                    ucMapa1.GenerarMapa();
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
        #endregion

        #region DADOS

        #region Click
        private void dados_Click(object sender, EventArgs e)
        {
            if (this.dados1.getEnable())
            {
                this.dados1.tirar();
                this.Turno++;
                SiguienteTurno();
            }
        }
        #endregion

        #region Activacion
        private void activarDados(int key) // Activa el user control dados, segun la key
        {
            if (this.Key == key)
            {
                this.dados1.setEnable(true);
            }
            else { this.dados1.setEnable(false); }
        }

        private void HabilitarDados() //Habilita el UC dados segun a quien le toca
        {
            int turno = obtenerTurno(this.turnero1.getTurno());

            switch (turno)
            {
                case 1:
                    activarDados(1);
                    break;

                case 2:
                    activarDados(2);
                    break;

                case 3:
                    activarDados(3);
                    break;

                case 4:
                    activarDados(4);
                    break;
            }
        }
        #endregion

        #region Acciones
        private void AccionesDados(string v1, string v2)
        {
            int v1I = int.Parse(v1);
            int V2I = int.Parse(v2);

            switch (this.eventoActual) 
            {
                case "Batalla":
                    try
                    {
                        this.barco2.Invoke(new Action(() => this.barco2.RecibirDanio(v1I + V2I)));
                        if (!this.accionFlag) 
                        {
                            EnviarEB();
                            this.accionFlag = true;
                        }
                    }
                    catch { }
                    break;
            }

        }
        #endregion



        #endregion

        #region NOTIFICACIONES
        private void QuitarTodasLasNotis() //Quita todas las notificaciones del form, y establece el atributo a 0
        {
            SpawnearNoti(1, false);
            SpawnearNoti(2, false);
            SpawnearNoti(3, false);
            SpawnearNoti(4, false);
        }

        private void RecibirNotificacion(int usr, int parametro) //Hace visible y muestra el mensaje que llega por parametro las notificaciones
        {
            NotificarOrden(usr, parametro);
            SpawnearNoti(usr, true);
        }

        private void MensajesVotacion() //Establece los mensajes de las urnas
        {
            if (this.urna1.InvokeRequired)
            {
                try
                {
                    this.urna1.Invoke(new Action(() => this.urna1.Votacion()));
                }
                catch { }
            }
        }

        private void SpawnearNoti(int rol, bool visible) //Hace visible o invisible una notificacion especificada en parametros
        {
            switch (rol)
            {
                case 1:
                    if (this.noti_Cap.InvokeRequired)
                    {
                        try
                        {
                            noti_Cap.Invoke(new Action(() => { noti_Cap.Visible = visible; }));
                        }
                        catch { }
                    }
                    break;

                case 2:
                    if (this.noti_Carp.InvokeRequired)
                    {
                        try
                        {
                            noti_Carp.Invoke(new Action(() => { noti_Carp.Visible = visible; }));
                        }
                        catch { }
                    }
                    break;

                case 3:
                    if (this.noti_Mer.InvokeRequired)
                    {
                        try
                        {
                            noti_Mer.Invoke(new Action(() => { noti_Mer.Visible = visible; }));
                        }
                        catch { }
                    }
                    break;

                case 4:
                    if (this.noti_Ar.InvokeRequired)
                    {
                        try
                        {
                            noti_Ar.Invoke(new Action(() => { noti_Ar.Visible = visible; }));
                        }
                        catch { }
                    }
                    break;
            }
        }

        private void NotificarOrdenCap(int x) //Establece un mensaje prearmado en la notificacion del capitan
        {
            if (this.noti_Cap.InvokeRequired)
            {
                try
                {
                    this.noti_Cap.Invoke(new Action(() => noti_Cap.MensajeArmadoCap(x)));
                }
                catch { }
            }
        }

        private void NotificarOrden(int quien, int x) //Establece el mensaje de la notificacion, teniendo en cuenta el evento.
        {
            switch (quien)
            {
                case 1:
                    if (this.noti_Cap.InvokeRequired)
                    {
                        try
                        {
                            this.noti_Cap.Invoke(new Action(() => noti_Cap.MensajeArmado(x, this.eventoActual)));
                        }
                        catch { }
                    }
                    break;
                case 2:
                    if (this.noti_Carp.InvokeRequired)
                    {
                        try
                        {
                            this.noti_Carp.Invoke(new Action(() => noti_Carp.MensajeArmado(x, this.eventoActual)));
                        }
                        catch { }
                    }
                    break;
                case 3:
                    if (this.noti_Mer.InvokeRequired)
                    {
                        try
                        {
                            this.noti_Mer.Invoke(new Action(() => noti_Mer.MensajeArmado(x, this.eventoActual)));
                        }
                        catch { }
                    }
                    break;
                case 4:
                    if (this.noti_Ar.InvokeRequired)
                    {
                        try
                        {
                            this.noti_Ar.Invoke(new Action(() => noti_Ar.MensajeArmado(x, this.eventoActual)));
                        }
                        catch { }
                    }
                    break;
            }
        }
        #endregion

        #region URNAS
        private string ConsultarDesicion() // Asigna al atributo del form "notificacion", la seleccion de la urna
        {
            string DES = "0";
            DES = this.urna1.ConsultarVoto().ToString();
            return DES;
        }

        private void SwitchUrnaCap(bool cual) // Intercambia visibilidad entre la urna normal y la de capitan
        {
            if (this.urnaCapitan1.InvokeRequired)
            {
                try
                {
                    urnaCapitan1.Invoke(new Action(() => urnaCapitan1.Visible = !cual));
                    urnaCapitan1.Invoke(new Action(() => urnaCapitan1.Enabled = !cual));
                }
                catch { }
            }

            if (this.urna1.InvokeRequired)
            {
                try
                {
                    urna1.Invoke(new Action(() => urna1.Visible = cual));
                    urna1.Invoke(new Action(() => urna1.Enabled = cual));
                    urna1.Invoke(new Action(() => urna1.reiniciarVoto()));
                    urna1.Invoke(new Action(() => urna1.DesicionesNuevas(this.Rol)));
                }
                catch { }
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
                this.urnaCapitan1.Load_UrnaCapitan(width, heigh, ref this.noti_Cap, ref this.turnero1, ref this.notificacion);
                this.urna1.Load_Urna(width, heigh, ref this.noti_Cap);
                this.urna1.Enabled = false;
                this.urna1.Visible = false;
            }
            else
            {
                this.urnaCapitan1.Enabled = false;
                this.urnaCapitan1.Visible = false;

                switch (this.Key)
                {
                    case 2:
                        this.urna1.Load_Urna(width, heigh, ref this.noti_Carp);
                        break;

                    case 3:
                        this.urna1.Load_Urna(width, heigh, ref this.noti_Mer);
                        break;

                    case 4:
                        this.urna1.Load_Urna(width, heigh, ref this.noti_Ar);
                        break;
                }
                this.urna1.Enabled = true;
                this.urna1.Visible = true;
            }
        }

        private void CargarVoto(int key, int accion) //Carga los votos al escrutinio
        {
            if (this.escrutinio1.InvokeRequired)
            {
                try
                {
                    escrutinio1.Invoke(new Action(() => this.escrutinio1.recibirVoto(key, accion)));
                }
                catch { }
            }
        }
        #endregion

        #region DESGLOSAR MENSAJE
        private List<string> obternerParam(string msg) // Desglosa el mensaje recibido de otros clientes
        {
            List<string> parametros = new List<string>();
            string aux = "";

            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] != ';')
                {
                    aux += msg[i];
                }
                else
                {
                    parametros.Add(aux);
                    aux = "";
                }
            }

            return parametros;
        }
        #endregion

        #region TURNERO
        private int obtenerTurno(int turnoActual) // Sin importar el numero de turno, devuelve 1,2,3 o 4
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

        private void SiguienteTurno() // Hace que el form avance al siguiente turno
        {
            try
            {
                this.turnero1.Invoke(new Action(() => this.turnero1.Siguiente()));
            }
            catch { }
        }

        #endregion

        #region ESCRUTINIO
        private void SwitchEscrutinio(bool cual) // Intercambia visibiliadad entre el escrutinio y los recursos
        {
            //TRUE ES --> ABRIR VOTACION
            if (this.escrutinio1.InvokeRequired)
            {
                try
                {
                    escrutinio1.Invoke(new Action(() => escrutinio1.Visible = cual));
                }
                catch { }
            }

            if (this.recursosDisplay1.InvokeRequired)
            {
                try
                {
                    recursosDisplay1.Invoke(new Action(() => recursosDisplay1.Visible = !cual));
                }
                catch { }
            }
        }
        #endregion

        #region EVENTO-RANDOM

        private string enventoRandom() 
        {
            string eventoX = "0";
            Random x = new Random();
            int evento = x.Next(1, 3);

            string variante = this.ucMapa1.ObteLugaActua();

            switch (variante)
            {
                case "I":
                    return "I";
                case "F":
                    return "F";
                case "M1":
                    switch (2) 
                    {
                        case 1:
                            eventoX = "M10";
                            break;

                        case 2:
                            eventoX = "M11";
                            break;
                    }
                    break;
            }


            return eventoX;
        }

        #endregion

        #region BARCO
        private void spawnearBarco() 
        {

        }

        #endregion

        #endregion
    }
}
