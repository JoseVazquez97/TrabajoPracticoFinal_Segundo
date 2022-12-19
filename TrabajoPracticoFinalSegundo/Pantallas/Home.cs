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
using System.Media;
using System.Diagnostics.Metrics;
using NAudio.Wave;
using System.Diagnostics;

namespace TrabajoPracticoFinalSegundo.Pantallas
{
    public partial class Home : Form
    {

        #region ATRIBUTOS DEL FORM CLIENTE

        private string _url = "https://localhost:7170/homeHubNew";
        HubConnection HomeConection;

        private string Rol;
        private string miAvatar;
        private bool conectado;

        private int Key;
        private int Turno;
        private string eventoActual;
        private string notificacion;
        private string eventoRandom;
        private int desCap;
        private int desicion;
        private int quien;

        private bool accionFlag; //Flag de danio
        private bool eFlag; //Flag de evento random
        private bool movFlag; // Flag de movimiento
        private bool mFlag; // Flag de mapa
        private bool fotoFlag;
        private bool startFlag;
        private bool batallaFlag;
        private bool votaFlag;
        private bool eventoFlag;
        private bool NoAlSpam;


        private WaveOut salidaFondo = new WaveOut();
        private WaveStream stream1;

        private WaveOut salidaVoz = new WaveOut();
        private WaveStream stream2;
        


        #endregion

        public Home()
        {
            InitializeComponent();

            this.conectado = false;

            #region ASIGNACION DE PARAMETROS INICIALES
            this.eventoActual = "Orden";
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.desCap = 0;
            this.movFlag = false;
            this.mFlag = false;
            this.eFlag = false;
            this.eventoFlag = false;
            this.accionFlag = false;
            this.startFlag = false;
            this.batallaFlag = false;
            this.votaFlag = true;
            this.NoAlSpam = false;
            this.desicion = 0;
            this.quien = 0;
            this.eventoRandom = "I";
            #endregion

            #region LOADS DE COMPONENTES 
            ReSizeFormControls();
            #region FONDOS
            this.BackgroundImage = Image.FromFile(@".\Recursos\Fondos\Madera.jpg");
            Navio_Page.BackgroundImage = Image.FromFile(@".\Recursos\Fondos\FondoHomeDos.jpg");
            Navegacion_Page.BackgroundImage = Image.FromFile(@".\Recursos\Fondos\mapax.png");
            int loc1 = this.flpLateralIzq.Width;
            int loc2 = this.flpSuperior.Height;
            this.Barco_Page.SelectTab(0);
            #endregion

            #region PANTALLAS WEB
            this.pantallaWeb1.WebLoad(this.flpLateralIzq.Size);
            this.pantallaWeb2.WebLoad(this.flpLateralIzq.Size);
            this.pantallaWeb3.WebLoad(this.flpLateralIzq.Size);
            this.pantallaWeb4.WebLoad(this.flpLateralIzq.Size);
            #endregion

            #endregion

            #region BARCOS
            this.barco1.loadBarco(ref this.recursosDisplay1);
            this.barco2.loadBarcoEnemigo();
            this.barco2.Visible = false;
            #endregion

            #region BARRA (INFERIOR)
            int x = Convert.ToInt32(this.flpInferior.Width / 3);
            int y = this.flpInferior.Height;

            #region TURNERO
            this.turnero1.LoadTurnero(x, y);
            #endregion
            #endregion

            #region NOTIFICADORES
            Point locati;
            this.flpLateralIzq.Parent = this;

            this.noti_Cap.Load_Notificador();
            this.noti_Cap.Visible = false;
            this.noti_Cap.Parent = this;
            locati = this.pantallaWeb1.Location;

            this.noti_Carp.Load_Notificador();
            this.noti_Carp.Visible = true;
            this.noti_Carp.Parent = this;
            locati = this.pantallaWeb2.Location;
            this.noti_Carp.Mensaje("Ordenes capitan!");

            this.noti_Mer.Load_Notificador();
            this.noti_Mer.Visible = false;
            this.noti_Mer.Parent = this;
            locati = this.pantallaWeb3.Location;

            this.noti_Ar.Load_Notificador();
            this.noti_Ar.Visible = false;
            this.noti_Ar.Parent = this;
            locati = this.pantallaWeb4.Location;
            #endregion

            #region ESCRUTINIO
            //FlowLayout4 (Recursos y escrutinio)
            this.flpSuperior.Padding = new System.Windows.Forms.Padding() { Left = this.flpSuperior.Width / 3 + 100 };


            this.Turno = turnero1.getTurno();
            this.escrutinio1.loadEscrutinio(this.flpSuperior.Width);
            this.escrutinio1.Visible = false;
            #endregion

            #region RECURSOS Y CAMBIOS DE PAG
            this.recursosDisplay1.LoadRecursos(flpSuperior.Width, flpSuperior.Height);
            #endregion

            #region MUSICA
            this.stream1 = new AudioFileReader(@".\Recursos\Musica\elBueno.wav");
            this.salidaFondo = new();
            this.salidaFondo.Volume = 0.5f;
            this.salidaFondo.Init(stream1);

            this.stream2 = new AudioFileReader(@".\Recursos\Musica\yohoho.wav");
            this.salidaVoz = new();
            this.salidaVoz.Volume = 0.5f;
            this.salidaVoz.Init(stream2);
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
                EnviarNotificacion();
                AsegurarOrden();

                switch (this.eventoActual)
                {
                    #region EJECUCION cada 100ms durante ORDEN
                    case "Orden":
                        #region LISTO
                        if (!this.fotoFlag)
                        {
                            this.fotoFlag = true;
                            EnviarPathX();
                        }

                        if (this.Key == 1)
                        {
                            if (this.mFlag == false)
                            {
                                this.mFlag = true;
                                EnviarCambiosMapa();
                                ucMapa1.CargarImagenBarco();
                            }
                        }
                        else
                        {
                            if (this.mFlag == false)
                            {
                                this.mFlag = true;
                                ConsultarMapa();
                                ucMapa1.CargarImagenBarco();
                            }
                        }
                        #endregion


                        break;
                    #endregion

                    #region EJECUCION cada 100ms durante VOTACION
                    case "Votacion":
                        if (this.escrutinio1.confirmarVotacion() != 0)
                        {
                            this.escrutinio1.reiniciarVotos();
                            this.escrutinio1.reiniciarCheck();

                            if (this.Key == 1)
                            {
                                EnviarMovimiento(this.desCap);
                                this.desCap = 0;
                            }

                            SwitchEscrutinio(false);
                        }
                        break;
                    #endregion

                    #region EJECUCION cada 100ms durante BATALLA
                    case "Batalla":
                        if (this.batallaFlag == false)
                        {
                            this.batallaFlag = true;
                            this.barco2.Visible = true;
                            SwitchEscrutinio(false);
                        }

                        EjecutarAccion();

                        break;
                        #endregion
                }
            }
        }
        #endregion


        #region IMPACTAR CLIENTE - //Esta funcion se encarga de hacer los cambios principales en el cambio de evento.

        private void ImpactarAccion(int quien, int noti, int turno)
        {
            if (noti != 0)
            {
                switch (this.eventoActual)
                {
                    case "Orden":
                        switch (quien)
                        {
                            case 1:
                                if (this.Key == 1)
                                {
                                    this.desCap = noti;
                                }
                                SiguienteTurno();
                                SwitchEscrutinio(true);
                                SpawnearNoti(2, false);
                                SpawnearNoti(3, false);
                                SpawnearNoti(4, false);
                                MensajesVotacion();
                                this.eventoActual = "Votacion";
                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                        }
                        break;


                    case "Votacion":
                        switch (quien)
                        {
                            case 1:

                                break;
                            case 2:
                                CargarVoto(quien, noti);
                                SiguienteTurno();
                                break;
                            case 3:
                                CargarVoto(quien, noti);
                                SiguienteTurno();
                                break;
                            case 4:
                                CargarVoto(quien, noti);
                                SiguienteTurno();
                                break;

                        }
                        break;

                    case "Batalla":
                        if (!this.batallaFlag)
                        {
                            this.batallaFlag = true;
                            SwitchEscrutinio(false);
                        }

                        if (quien != this.Key)
                        {
                            this.desicion = noti;
                        }
                        break;

                    case "Pezca":
                        SwitchEscrutinio(true);
                        switch (quien)
                        {
                            case 1:

                                break;

                            case 2:

                                break;

                            case 3:

                                break;

                            case 4:

                                break;
                        }
                        break;
                }
            }

        }
        #endregion

        #endregion


        #region SIGNAL R

        #region ENVIO DE MENSAJES Y CONSULTAS

        #region ENVIAR - Imagenes
        private async void EnviarPathX()
        {
            string quien = this.Key.ToString();
            string path = this.miAvatar;

            try
            {
                await HomeConection.InvokeAsync("EnviarPath", quien, path);
            }
            catch { MessageBox.Show("Error en el envio de imagenes."); }
        }

        private async void ConsultarPathX()
        {
            try
            {
                await HomeConection.InvokeAsync("ConsultarPath");
            }
            catch { MessageBox.Show("Error en el consultar las imagenes."); }
        }
        #endregion

        #region ENVIAR - Notificacion
        private async void EnviarNotificacion()
        {
            int usr = this.Key;
            int msg = 0;
            int turno = this.turnero1.getTurno();

            if (this.Key == 1)
            {
                if (this.eventoActual == "Orden")
                {
                    msg = this.urnaCapitan1.ConsultarDesicion();
                    this.urnaCapitan1.ReiniciarDesicion();
                }
                else
                {
                    msg = this.urna1.ConsultarVoto();
                    this.urna1.reiniciarVoto();
                }
            }
            else
            {
                msg = this.urna1.ConsultarVoto();
                this.urna1.reiniciarVoto();
            }

            try
            {
                await HomeConection.InvokeAsync("EnviarNoti", usr, msg, turno);
            }
            catch 
            {
                NoAlSpam = true;
                if(!NoAlSpam) MessageBox.Show("Error en el envio de Notificacion."); 
            }
        }
        #endregion

        #region CONSULTAR - Notificacion

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

        #region CONSULTA - Dados
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
        private async void EnviarEventoX()
        {
            if (this.Key == 1)
            {
                string eventox = this.eventoRandom;
                int rol = this.Key;

                try
                {
                    await HomeConection.InvokeAsync("EnviarEvento", rol, eventox);
                }
                catch { MessageBox.Show("Error en el envio del Evento."); }
            }

        }
        #endregion

        #region ENVIAR - Barcos
        private async void EnviarEB()
        {
            string b1 = this.barco1.ConsultarEstado();
            string b2 = this.barco2.ConsultarEstado();

            try
            {
                await HomeConection.InvokeAsync("EnviarBarcos", b1, b2);
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

            HomeConection.On<string, string>("RecibirPath", (quien, path) =>
            {

                if (int.Parse(quien) != this.Key)
                {
                    switch (quien)
                    {
                        case "1":
                            try
                            {
                                pantallaWeb1.Invoke(new Action(() => this.pantallaWeb1.CargarAvatar(path)));
                            }
                            catch { MessageBox.Show($"No se pudo recibir el path de {quien} que es : {path}"); }
                            break;
                        case "2":
                            try
                            {
                                pantallaWeb2.Invoke(new Action(() => this.pantallaWeb2.CargarAvatar(path)));
                            }
                            catch { MessageBox.Show($"No se pudo recibir el path de {quien} que es : {path}"); }
                            break;
                        case "3":
                            try
                            {
                                pantallaWeb3.Invoke(new Action(() => this.pantallaWeb3.CargarAvatar(path)));
                            }
                            catch { MessageBox.Show($"No se pudo recibir el path de {quien} que es : {path}"); }
                            break;
                        case "4":
                            try
                            {
                                pantallaWeb4.Invoke(new Action(() => this.pantallaWeb4.CargarAvatar(path)));
                            }
                            catch { MessageBox.Show($"No se pudo recibir el path de {quien} que es : {path}"); }
                            break;
                    }
                }
                else
                {
                    ConsultarPathX();
                }
            });

            HomeConection.On<string>("RecibirCPath", (msg) =>
            {
                List<string> paths = new List<string>();
                paths = obternerParam(msg);

                for (int i = 0; i < paths.Count; i++)
                {
                    if (paths[i] != "0")
                    {
                        switch (i)
                        {
                            case 0:
                                try
                                {
                                    pantallaWeb1.Invoke(new Action(() => this.pantallaWeb1.CargarAvatar(paths[i])));
                                }
                                catch { MessageBox.Show($"No se pudo recibir el path de {1} que es : {paths[i]}"); }
                                break;

                            case 1:
                                try
                                {
                                    pantallaWeb2.Invoke(new Action(() => this.pantallaWeb2.CargarAvatar(paths[i])));
                                }
                                catch { MessageBox.Show($"No se pudo recibir el path de {2} que es : {paths[i]}"); }
                                break;

                            case 2:
                                try
                                {
                                    pantallaWeb3.Invoke(new Action(() => this.pantallaWeb3.CargarAvatar(paths[i])));
                                }
                                catch { MessageBox.Show($"No se pudo recibir el path de {3} que es : {paths[i]}"); }
                                break;

                            case 3:
                                try
                                {
                                    pantallaWeb4.Invoke(new Action(() => this.pantallaWeb4.CargarAvatar(paths[i])));
                                }
                                catch { MessageBox.Show($"No se pudo recibir el path de {4} que es : {paths[i]}"); }
                                break;
                        }
                    }
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

            #region DADOS-COM
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

            HomeConection.On<string>("RecibirMov", (mov) =>
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
                            QuitarTodasLasNotis();
                        }
                        catch { MessageBox.Show("No pudo mostrarse el mapa"); }
                    }

                    if (this.Key == 1)
                    {
                        this.eventoRandom = enventoRandom();
                        if (this.eventoFlag == false)
                        {
                            this.eventoFlag = true;
                            EnviarEventoX();
                        }
                    }
                }
                catch { ConsultarMovimiento(); }
            });
            #endregion

            #region EVENTO-COM

            HomeConection.On<int, string>("RecibirEvento", (rol, val1) =>
            {
                if (rol == 1)
                {
                    switch (val1)
                    {
                        case "M10":
                            this.eventoActual = "Orden";
                            this.eventoFlag = false;
                            break;

                        case "M11":
                            this.eventoActual = "Batalla";

                            try
                            {
                                this.urna1.Invoke(new Action(() => this.urna1.Batalla(this.Key) ));
                            }
                            catch { }
                           
                            switch (this.Key) 
                            {
                                case 1:
                                    SwitchUrnaCap(true);
                                    break;

                                case 2:
                                    break;

                                case 3:
                                    break;

                                case 4:
                                    break;
                            }
                            break;
                    }
                }

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

            #region NOTI-COM
            HomeConection.On<int, int, int>("RecibirNoti", (quien, noti, turno) =>
            {
                ImpactarAccion(quien, noti, turno);

                if (noti != 0)
                {
                    switch (quien)
                    {
                        case 1:
                            NotificarOrden(quien, noti);
                            break;
                        case 2:
                            NotificarOrden(quien, noti);
                            break;
                        case 3:
                            NotificarOrden(quien, noti);
                            break;
                        case 4:
                            NotificarOrden(quien, noti);
                            break;

                    }
                }

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
        public void AsignarAvatar(string avatar, string rol) //Funcion ejecutada desde la pantalla anterior
        {
            this.Rol = rol;
            this.miAvatar = avatar;

            switch (rol)
            {
                case "Capitan":
                    this.Key = 1;
                    DalePower();
                    this.pantallaWeb1.CargarAvatar(this.miAvatar);
                    this.dados1.setEnable(false);
                    ucMapa1.GenerarMapa();
                    loadUrnas(true);
                    break;

                case "Carpintero":
                    this.Key = 2;
                    this.pantallaWeb2.CargarAvatar(this.miAvatar);
                    this.dados1.setEnable(false);
                    loadUrnas(false);
                    break;

                case "Mercader":
                    this.Key = 3;
                    this.pantallaWeb3.CargarAvatar(this.miAvatar);
                    this.dados1.setEnable(false);
                    loadUrnas(false);
                    break;

                case "Artillero":
                    this.Key = 4;
                    this.pantallaWeb4.CargarAvatar(this.miAvatar);
                    this.dados1.setEnable(false);
                    loadUrnas(false);
                    break;
            }

            #region DADOS
            int x = Convert.ToInt32(this.flpInferior.Width / 3);
            int y = this.flpInferior.Height;
            this.dados1.CargarTablero(x + 100, y, this.Key);
            #endregion
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

        #endregion

        #region NOTIFICACIONES

        private void QuitarTodasLasNotis() //Quita todas las notificaciones del form, y establece el atributo a 0
        {
            SpawnearNoti(1, false);
            SpawnearNoti(2, false);
            SpawnearNoti(3, false);
            SpawnearNoti(4, false);
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
                    try
                    {
                        noti_Cap.Invoke(new Action(() => { noti_Cap.Visible = visible; }));
                        if (visible) Voz();
                    }
                    catch { }
                    break;

                case 2:
                    try
                    {
                        noti_Carp.Invoke(new Action(() => { noti_Carp.Visible = visible; }));
                        if (visible) Voz();
                    }
                    catch { }
                    break;

                case 3:
                    try
                    {
                        noti_Mer.Invoke(new Action(() => { noti_Mer.Visible = visible; }));
                        if (visible) Voz();
                    }
                    catch { }
                    break;

                case 4:
                    try
                    {
                        noti_Ar.Invoke(new Action(() => { noti_Ar.Visible = visible; }));
                        if (visible) Voz();
                    }
                    catch { }
                    break;
            }
        }

        private void NotificarOrden(int quien, int x) //Establece el mensaje de la notificacion, teniendo en cuenta el evento.
        {
            switch (quien)
            {
                case 1:
                    try
                    {
                        if (this.eventoActual == "Votacion")
                        {
                            this.noti_Cap.Invoke(new Action(() => noti_Cap.MensajeArmadoCap(x)));
                        }
                        else
                        {
                            this.noti_Cap.Invoke(new Action(() => noti_Cap.MensajeArmado(quien, x, this.eventoActual)));
                        }
                    }
                    catch { }
                    break;

                case 2:
                    try
                    {
                        this.noti_Carp.Invoke(new Action(() => noti_Carp.MensajeArmado(quien, x, this.eventoActual)));
                    }
                    catch { }
                    break;
                case 3:
                    try
                    {
                        this.noti_Mer.Invoke(new Action(() => noti_Mer.MensajeArmado(quien, x, this.eventoActual)));
                    }
                    catch { }
                    break;
                case 4:
                    try
                    {
                        this.noti_Ar.Invoke(new Action(() => noti_Ar.MensajeArmado(quien, x, this.eventoActual)));
                    }
                    catch { }
                    break;
            }
            SpawnearNoti(quien, true);
        }
        #endregion

        #region URNAS

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
            int width = Convert.ToInt32(this.flpInferior.Width / 3);
            int heigh = this.flpInferior.Height;

            if (x)
            {
                this.urnaCapitan1.Enabled = true;
                this.urnaCapitan1.Visible = true;
                this.urnaCapitan1.Load_UrnaCapitan(ref this.noti_Cap, ref this.turnero1);
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
                this.Turno++;
            }
            catch { }
        }

        #endregion

        #region ESCRUTINIO
        private void SwitchEscrutinio(bool cual) // Intercambia visibiliadad entre el escrutinio y los recursos
        {
            //TRUE ES --> ABRIR VOTACION
            try
            {
                this.escrutinio1.Invoke(new Action(() => this.escrutinio1.Visible = cual));
            }
            catch { }

            try
            {
                recursosDisplay1.Invoke(new Action(() => recursosDisplay1.Visible = !cual));
            }
            catch { }
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

                case "M2":
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

                case "M3":
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

                default:
                    MessageBox.Show("El mapa devolvio un lugar raro");
                    break;
            }
            return eventoX;
        }

        #endregion

        #region BARCO

        private void daniarBarco() 
        {
            this.barco2.RecibirDanio(10);
            this.quien = 0;
            this.desicion = 0;
        }

        private void recargarBarco() 
        {
            this.quien = 0;
            this.desicion = 0;
        }

        #endregion

        #region MUSICA

        private void DalePower()
        {
            if (this.salidaFondo.PlaybackState is PlaybackState.Playing) salidaFondo.Stop();
            stream1.CurrentTime = new TimeSpan(0L);
            this.salidaFondo.Play();
        }
        private void Voz()
        {
            if (this.salidaVoz.PlaybackState is PlaybackState.Playing) salidaVoz.Stop();
            stream2.CurrentTime = new TimeSpan(0L);
            this.salidaVoz.Play();
        }

        #endregion

        #region ACCION DADOS
        private void EjecutarAccion() 
        {
            if (this.dados1.LISTO)
            {
                this.dados1.LISTO = false;

                if (this.desicion != 0 && this.quien != 0) 
                {
                    switch (this.quien) 
                    {
                        case 1:
                            switch (this.desicion) 
                            {
                                case 1:
                                    daniarBarco();
                                    break;

                                case 2:
                                    recargarBarco();
                                    break;
                            }
                            break;
                        case 2:
                            switch (this.desicion)
                            {
                                case 1:
                                    daniarBarco();
                                    break;

                                case 2:
                                    recargarBarco();
                                    break;
                            }
                            break;
                        case 3:
                            switch (this.desicion)
                            {
                                case 1:
                                    daniarBarco();
                                    break;

                                case 2:
                                    recargarBarco();
                                    break;
                            }
                            break;
                        case 4:
                            switch (this.desicion)
                            {
                                case 1:
                                    daniarBarco();
                                    break;

                                case 2:
                                    recargarBarco();
                                    break;
                            }
                            break;
                    }
                }
            }
        }

        #endregion

        #region ASEGURAR ORDEN

        private void AsegurarOrden() 
        {
            if (obtenerTurno(this.Turno) != this.Key)
            {
                this.dados1.setEnable(false);
                this.urna1.Enabled = false;
                this.urnaCapitan1.Enabled = false;
            }
            else 
            {
                if (this.eventoActual == "Batalla" || this.eventoActual == "Pezca") 
                {
                    this.dados1.setEnable(true);
                }
                
                this.urna1.Enabled = true;

                if (this.Key == 1) 
                {
                    this.urnaCapitan1.Enabled = true;
                }
            }
        }
        #endregion

        #endregion



        private void ReSizeFormControls()  //Funcion para ajustar controles al tamaño de pantalla del usuario
        {
            
            foreach (Control item in this.Controls)
            {
                AdjustSize(item);
                AdjustLocation(item);

                if (item.GetType() == new FlowLayoutPanel().GetType() || item.GetType() == new TabPage().GetType())
                {
                    foreach (Control FLPitem in item.Controls)
                    {
                        AdjustSize(FLPitem);
                        AdjustLocation(FLPitem);
                    }
                }
            }
            
            this.noti_Cap.Location = new Point(pantallaWeb1.Location.X + pantallaWeb1.Width, pantallaWeb1.Location.Y - 10);
            this.noti_Carp.Location = new Point(pantallaWeb2.Location.X + pantallaWeb2.Width, pantallaWeb2.Location.Y - 10);
            this.noti_Ar.Location = new Point(pantallaWeb3.Location.X + pantallaWeb3.Width, pantallaWeb3.Location.Y - 10);
            this.noti_Mer.Location = new Point(pantallaWeb4.Location.X + pantallaWeb4.Width, pantallaWeb4.Location.Y - 10);
            

        }

        private void AdjustSize(Control control)
        {
            int x = 0, y = 0;
            y = (this.Height * control.Height) / 1080;
            x = (this.Width * control.Width) / 1920;
            control.Size = new Size(x, y);
        }
        private void AdjustLocation(Control control)
        {
            int x = 0, y = 0;
            y = (this.Height * control.Location.X) / 1080;
            x = (this.Width * control.Location.Y) / 1920;
            control.Location = new Point(x, y);
        }
    }
}
