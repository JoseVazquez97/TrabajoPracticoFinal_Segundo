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
        private bool checkRendimiento;
        private bool conectado;

        private int Key;
        private int turno;
        private string eventoActual;
        private int desicionCapitan;
        private string notificacion;
        private string accionRealizada;
        private string accionBot;

        private string eventoRandom;
        private int desicionIndividual;
        private string val1;
        private string val2;

        #endregion

        public Home()
        {
            InitializeComponent();
            this.conectado = false;
            
            #region ASIGNACION DE PARAMETROS INICIALES
            this.eventoActual = "Orden";
            this.eventoRandom = "Isla";
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.checkRendimiento = false;
            this.notificacion = "1";
            this.accionRealizada = "0";
            this.val1 = "0";
            this.val2 = "0";
            #endregion

            #region DECLARACION DEL HUB
            HomeConection = new HubConnectionBuilder().WithUrl(_url).Build();

            //Si te desconectas segui intentado.
            HomeConection.Closed +=
                async (error) => { System.Threading.Thread.Sleep(5000); await HomeConection.StartAsync(); };
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
            this.turno = turnero1.getTurno();
            this.escrutinio1.loadEscrutinio(this.flowLayoutPanel4.Width);
            this.escrutinio1.Visible = false;

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

                switch (this.eventoActual)
                {
                    case "Orden":
                        EnviarEstadoSR();
                        break;

                    case "Votacion":
                        EnviarEstadoSR();
                        break;

                    case "Batalla":
                        int letoca = obtenerTurno(this.turno);
                        HabilitarDados(letoca);
                        EnviarEstadoSR();

                        switch (letoca)
                        {
                            case 1:
                                if (letoca == this.Key) { if (this.dados1.LISTO) { EnviarDadosCL(); } }
                                break;
                            case 2:
                                if (letoca == this.Key) { if (this.dados1.LISTO) { EnviarDadosCL(); } }
                                break;
                            case 3:
                                if (letoca == this.Key) { if (this.dados1.LISTO) { EnviarDadosCL(); } }
                                break;
                            case 4:
                                if (letoca == this.Key) { if (this.dados1.LISTO) { EnviarDadosCL(); } }
                                break;
                        }
                        break;
                }
            }
        }
        #endregion

        #region IMPACTAR EN FORM
        private void ImpactarEnCliente(string user, List<string> parametros)
        {
            // Index de parametros
            // 0.Turno , 1.DesicionCapitan , 2.Notificacion , 3.EventoActual, 4.AccionRealizada, 5.DesicionIndividual, 6.AccionBot

            //Evento ORDEN
            if (this.turno < int.Parse(parametros[0])) //Si el turno de este cliente es menor del que me llega sucedio algo...
            {
                if (this.eventoActual == "Orden" && this.eventoActual == parametros[3]) //Si estamos en el evento orden
                {
                    if (user == "1") //Y el capitan nos envia mensaje.
                    {
                        this.turno = int.Parse(parametros[0]); //Igualamos el turno

                        if (this.Key != 1)
                        {
                            SiguienteTurno();
                        }

                        if (int.Parse(parametros[2]) != 0)
                        {
                            NotificarOrdenCap(int.Parse(parametros[2]));
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

            //Evento VOTACION
            if (parametros[3] == "Votacion" && parametros[3] == this.eventoActual)
            {
                SwitchEscrutinio(true);

                switch (this.Key)
                {
                    case 2:
                        MensajesVotacion(); //Escribe los mensajes Si capitan y No capitan en la urna1
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

                if (int.Parse(parametros[2]) != 0)
                {
                    switch (user)
                    {
                        case "2":
                            SpawnearNoti(2, true);
                            NotificarOrden(2, int.Parse(parametros[2]));
                            CargarVoto(1, int.Parse(parametros[2]));
                            SiguienteTurno();
                            break;

                        case "3":
                            SpawnearNoti(3, true);
                            NotificarOrden(3, int.Parse(parametros[2]));
                            CargarVoto(2, int.Parse(parametros[2]));
                            SiguienteTurno();
                            break;

                        case "4":
                            SpawnearNoti(4, true);
                            NotificarOrden(4, int.Parse(parametros[2]));
                            CargarVoto(3, int.Parse(parametros[2]));
                            SiguienteTurno();
                            break;
                    }


                    if (this.escrutinio1.confirmarVotacion() != 0)
                    {
                        this.eventoActual = "Batalla";
                        SwitchEscrutinio(false);
                        this.escrutinio1.reiniciarVotos();
                        this.escrutinio1.reiniciarCheck();
                        QuitarTodasLasNotis();
                    }
                }
            }

            //Evento BATALLA
            if (parametros[3] == "Batalla" && parametros[3] == this.eventoActual)
            {
                AparecerBarcoEnemigo();

                if (this.turno < int.Parse(parametros[0]))
                {
                    TirarDadosAuto();
                    SiguienteTurno();
                }

                switch (user)
                {
                    case "1":

                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":

                        break;
                }

            }

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
                        this.desicionCapitan = this.urnaCapitan1.ConsultarDesicion();
                        this.notificacion = this.urnaCapitan1.ConsultarDesicion().ToString();
                        this.urna1.reiniciarVoto();
                    }
                    break;

                case "Votacion":
                    this.notificacion = this.urna1.ConsultarVoto().ToString();
                    this.urna1.reiniciarVoto();
                    break;

                case "Batalla":
                    this.notificacion = this.urna1.ConsultarVoto().ToString();
                    SpawnearNoti(this.Key, true);
                    NotificarOrden(this.Key, int.Parse(this.notificacion));
                    break;
            }


            mensaje = this.turnero1.getTurno().ToString() + ";" + this.desicionCapitan + ";"
                + this.notificacion + ";" + this.eventoActual + ";" + this.accionRealizada + ";"
                + this.desicionIndividual + ";" + this.accionBot + ";";

            return mensaje;
        }
        #endregion

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

        #region ENVIAR - Dados
        private async void EnviarDadosCL()
        {
            ConsultarValorDado();

            string usr = this.Key.ToString();
            string val1 = this.val1;
            string val2 = this.val2; 
            

            try
            {
                await HomeConection.InvokeAsync("EnviarDados", usr, val1, val2);
            }
            catch { MessageBox.Show("Error en el envio de Dados."); }
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
                if (int.Parse(usr) != this.Key) 
                {
                    if (this.dados1.InvokeRequired)
                    {
                        if (this.dados1.LISTO) 
                        {
                            try 
                            {
                                this.dados1.Invoke(new Action(() => this.dados1.AsignarValores(val1,val2)));
                            } catch { }
                        }
                    }
                }
                
            });
            #endregion
        }

        #endregion

        #endregion

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
        public void AsignarAvatar(Image avatar, string rol, bool jugarcam)
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
        #endregion

        private void AparecerBarcoEnemigo()
        {
            /*
            if (this.barco2.InvokeRequired)
            {
                try
                {
                    barco2.Invoke(new Action(() => this.barco2.Visible = true));
                }
                catch { }
            }
            */
        }

        private void HabilitarDados(int x)
        {
            switch (x)
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

        private void MensajesVotacion()
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

        private void loadUrnas(bool x) //Funcion para hacer los componentes del hud responsivos.
        {
            int width = Convert.ToInt32(this.flowLayoutPanel1.Width / 3);
            int heigh = this.flowLayoutPanel1.Height;

            if (x)
            {
                this.urnaCapitan1.Enabled = true;
                this.urnaCapitan1.Visible = true;
                this.urnaCapitan1.Load_UrnaCapitan(width, heigh, ref this.noti_Cap, ref this.turnero1, ref this.notificacion);
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

        private void CargarVoto(int key, int accion) 
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

        private void dados1_Load(object sender, EventArgs e)
        {

        }

        private List<string> obternerParam(string msg) 
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

        private void NotificarOrdenCap(int x) 
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

        private void NotificarOrden(int quien, int x) 
        {
            switch (quien) 
            {
                case 1:
                    if (this.noti_Cap.InvokeRequired)
                    {
                        try
                        {
                            this.noti_Cap.Invoke(new Action(() => noti_Cap.MensajeArmado(x)));
                        }
                        catch { }
                    }
                    break;
                case 2:
                    if (this.noti_Carp.InvokeRequired)
                    {
                        try
                        {
                            this.noti_Carp.Invoke(new Action(() => noti_Carp.MensajeArmado(x)));
                        }
                        catch { }
                    }
                    break;
                case 3:
                    if (this.noti_Mer.InvokeRequired)
                    {
                        try
                        {
                            this.noti_Mer.Invoke(new Action(() => noti_Mer.MensajeArmado(x)));
                        }
                        catch { }
                    }
                    break;
                case 4:
                    if (this.noti_Ar.InvokeRequired)
                    {
                        try
                        {
                            this.noti_Ar.Invoke(new Action(() => noti_Ar.MensajeArmado(x)));
                        }
                        catch { }
                    }
                    break;
            }
        }

        private void TirarDadosAuto() 
        {
            if (this.dados1.InvokeRequired) 
            {
                try 
                {
                    this.dados1.Invoke(new Action(() => this.dados1.tirar()));
                } catch { }
            }
        }

        private void SiguienteTurno() 
        {
            try
            {
                if (this.turnero1.InvokeRequired)
                {
                    this.turnero1.Invoke(new Action(() => this.turnero1.Siguiente()));
                    this.turnero1.Invoke(new Action(() => this.turno = this.turnero1.getTurno()));
                }
            }
            catch { }
        }

        private int ConsultarDesicion()
        {
            int desicion = 0;
            if (this.urna1.InvokeRequired)
            {
                try
                {
                    this.urna1.Invoke(new Action(() => desicion = this.urna1.ConsultarVoto()));
                }
                catch { }
            }
            return desicion;
        }

        private void activarDados(int key)
        {
            if (this.Key == key)
            {
                this.dados1.setEnable(true);
            }
            else { this.dados1.setEnable(false); }
        }

        private void SpawnearNoti(int rol, bool visible)
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

        private void SwitchEscrutinio(bool cual)
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

        private void QuitarTodasLasNotis()
        {
            SpawnearNoti(1, false);
            SpawnearNoti(2, false);
            SpawnearNoti(3, false);
            SpawnearNoti(4, false);
        }

        private void SwitchUrnaCap(bool cual)
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

        private void EventoRandom()
        {
            Random x = new Random();
            int evento = x.Next(1, 5);

            switch (2)
            {
                case 1:
                    //EncontrarIsla();
                    break;

                case 2:
                    //EncontrarBarco();
                    break;

                case 3:
                    //EncontrarMar();
                    break;

                case 4:
                    this.eventoRandom = "Null";
                    break;
            }
        }

        #endregion
        private void ConsultarValorDado() 
        {
            try
            {
                this.dados1.Invoke(new Action(() => this.val1 = this.dados1.V1.ToString()));
                this.dados1.Invoke(new Action(() => this.val2 = this.dados1.V2.ToString()));
            }
            catch { }
        }

        
    }
}
