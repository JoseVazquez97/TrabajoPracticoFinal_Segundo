using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoFinalSegundo.UserControls
{ 
    public partial class Dados : UserControl
    {

        private int tiradas;
        private int d1;
        private int d2;
        private bool cerradura;
        private bool Listo;
        private int Key;

        public int V1 { get { return this.d1; } }
        public int V2 { get { return this.d2; } }
        public bool LISTO { get { return this.Listo; } set { this.Listo = value; } }


        private string _url = "https://localhost:7170/homeHubNew";
        HubConnection HomeConection;


        public Dados()
        {
            InitializeComponent();

            #region DECLARACION DEL HUB
            HomeConection = new HubConnectionBuilder().WithUrl(_url).Build();

            //Si te desconectas segui intentado.
            HomeConection.Closed +=
                async (error) => { System.Threading.Thread.Sleep(5000); await HomeConection.StartAsync(); };
            #endregion
        }


        #region  LOADS

        public void LoadTablero(object sender, EventArgs e)
        {
            this.Listo = false;
            anim1.Visible = false;
            anim2.Visible = false;
            anim1.BackColor = Color.Red;
            anim2.BackColor = Color.Red;

            dado1.Image = Image.FromFile(@".\Recursos\Dados\Dado1.bmp");
            dado2.Image = Image.FromFile(@".\Recursos\Dados\Dado2.bmp");
        }

        public void setEnable(bool x) 
        {
            this.anim1.Enabled=x;
            this.anim2.Enabled=x;
            this.dado1.Enabled=x;
            this.dado2.Enabled=x;
            this.Enabled = x;

            cerradura = x;
        }

        public void reiniciarListo() 
        {
            this.LISTO = false;
        }

        public bool getEnable() 
        {
            return cerradura;
        }

        public void CargarTablero(int tamaTotal, int altoTotal, int key)
        {
            this.Key = key;
            this.Width = tamaTotal;
            this.Height = altoTotal;

            anim1.Visible = false;
            anim2.Visible = false;
            anim1.BackColor = Color.Red;
            anim2.BackColor = Color.Red;

            dado1.Image = Image.FromFile(@".\Recursos\Dados\Dado1.bmp");
            dado2.Image = Image.FromFile(@".\Recursos\Dados\Dado2.bmp");

            int x = Convert.ToInt32(this.Width / 2);

            anim1.Location = new Point(x-70, 32);
            anim2.Location = new Point(x+55, 32);

            dado1.Location = new Point(x-65, 38);
            dado2.Location = new Point(x+60, 38);
        }
        #endregion

        #region FUNCIONALIDAD
        private Image Tirada(int dado)
        {
            return Image.FromFile(@".\Recursos\Dados\Dado"+ dado + ".bmp");
        }

        private int Suerte() 
        {
            int d;
            return d = new Random().Next(1, 7);
        }

        public void tirar()
        {
            this.Listo = false;
            tiradas = 0;
            TirandoDados.Interval = 50;
          
            TirandoDados.Start();
        }


        private void Dados_Try() 
        {
            this.d1 = Suerte();
            this.d2 = Suerte();

            EnviarDadosCL(this.d1, this.d2);

            this.dado1.Image = Tirada(this.d1);
            this.dado2.Image = Tirada(this.d2);

            if(anim1.Visible)
            {
                anim1.Visible = false;
                anim2.Visible = false;
            }
            else
            {
                anim1.Visible = true;
                anim2.Visible = true;
            }
        }

        private void Dados_Try2(string val1, string val2)
        {
            this.d1 = int.Parse(val1);
            this.d2 = int.Parse(val2);

            try
            {
                this.dado1.Invoke(new Action(() => this.dado1.Image = Tirada(this.d1)));
                this.dado2.Invoke(new Action(() => this.dado2.Image = Tirada(this.d2)));

                if (anim1.Visible)
                {
                    this.anim1.Invoke(new Action(() => anim1.Visible = false));
                    this.anim2.Invoke(new Action(() => anim2.Visible = false));
                }
                else
                {
                    this.anim1.Invoke(new Action(() => anim1.Visible = true));
                    this.anim2.Invoke(new Action(() => anim2.Visible = true));
                }
            }
            catch { MessageBox.Show("Problemas al establecer los valores de los dados"); }
        }

        private void TerminarTirada()
        {
            anim1.Visible = false;
            anim2.Visible = false;
            this.Listo = true;
        }

        public void AsignarValores(string val1, string val2) 
        {
            this.dado1.Image = Tirada(this.d1);
            this.dado2.Image = Tirada(this.d2);
            TerminarTirada();
        }

        public void AsignarValores2(string val1, string val2)
        {
            this.dado1.Invoke(new Action(() => this.dado1.Image = Tirada(int.Parse(val1))));
            this.dado2.Invoke(new Action(() => this.dado2.Image = Tirada(int.Parse(val2))));
        }

        private void TirandoDados_Tick(object sender, EventArgs e)
        {
            Dados_Try();

            if (tiradas < 8) 
            {
                TirandoDados.Interval += 70;
            }
            else TirandoDados.Interval += 300;

            tiradas++;

            if (tiradas >= 10)
            {
                TirandoDados.Stop();
                TerminarTirada();
            }
        }

        #endregion


        private async void EnviarDadosCL(int d1, int d2)
        {
            string usr = this.Key.ToString();
            string val1 = d1.ToString();
            string val2 = d2.ToString();

            try
            {
                await HomeConection.InvokeAsync("EnviarDados", usr, val1, val2);
            }
            catch { MessageBox.Show("Error en el envio de dados."); }
        }


        private async void Dados_Load(object sender, EventArgs e)
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

            HomeConection.On<string, string, string>("RecibirDados", (usr, val1, val2) =>
            {
                if (int.Parse(usr) != this.Key) 
                {
                    try
                    {
                        Dados_Try2(val1, val2);
                    }
                    catch { MessageBox.Show($"Error al cargar los valores {val1} y {val2} en los dados"); }
                }
            });
        }
    }
}
