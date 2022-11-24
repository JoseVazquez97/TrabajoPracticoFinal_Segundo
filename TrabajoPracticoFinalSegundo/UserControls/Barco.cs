using TrabajoPracticoFinalSegundo.Clases;

namespace TrabajoPracticoFinalSegundo.UserControls
{
    public partial class Barco : UserControl
    {
        Almacen almacen;
        string path;
        int Vida;
        int Danio;
        RecursosDisplay recDispley;

        public Barco()
        {

            InitializeComponent();
            this.almacen = new Almacen();
            this.Vida = 100;
            this.path = Directory.GetParent(Directory.GetParent(@"..").ToString()).ToString();

        }

        public void loadBarcoEnemigo()
        {
            this.pic_Barco.Image = Image.FromFile(this.path + @"\Recursos\BarcO\BARCO_BaseDos.png");

            this.canon1.esDerecho();
            this.canon2.esDerecho();
            this.canon3.esIzquierdo();
            this.canon4.esIzquierdo();

            this.canon1.Parent = this.pic_Barco;
            this.canon2.Parent = this.pic_Barco;
            this.canon3.Parent = this.pic_Barco;
            this.canon4.Parent = this.pic_Barco;
        }

        public bool Curar()
        {

            if (this.progressBar1.Value <= this.Vida - 10)
            {
                this.progressBar1.Value = this.Vida + 10;
                this.recDispley.extraerRecurso("Madera", 1);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Disparar()
        {
  
            if (this.canon1.consultarMuni() == 1)
            {
                this.canon1.gastarMuni();
                return true;
            }
            else if (this.canon2.consultarMuni() == 1)
            {
                this.canon2.gastarMuni();
                return true;
            }
            else if (this.canon3.consultarMuni() == 1)
            {
                this.canon3.gastarMuni();
                return true;
            }
            else if (this.canon4.consultarMuni() == 1)
            {
                this.canon4.gastarMuni();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Recargar()
        {
            
            if (this.canon1.consultarMuni() == 0)
            {
                this.recDispley.extraerRecurso("Bala", 1);
                this.canon1.regargarMuni();
                return true;
            }
            else if (this.canon2.consultarMuni() == 0)
            {
                this.recDispley.extraerRecurso("Bala", 1);
                this.canon2.regargarMuni();
                return true;
            }
            else if (this.canon3.consultarMuni() == 0)
            {
                this.recDispley.extraerRecurso("Bala", 1);
                this.canon3.regargarMuni();
                return true;
            }
            else if (this.canon4.consultarMuni() == 0)
            {
                this.recDispley.extraerRecurso("Bala", 1);
                this.canon4.regargarMuni();
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ConsultarEstado()
        {
            string mensaje = "";
            mensaje = this.canon1.consultarMuni() + ";" + this.canon2.consultarMuni() + ";" + this.canon3.consultarMuni() + ";" + this.canon4.consultarMuni() + ";" + this.Vida + ";";
            return mensaje;
        }

        public void RecibirEstado(string estado)
        {
            string aux = "";
            int cont = 0;

            for (int i = 0; i < estado.Length; i++)
            {
                if (estado[i] != ';')
                {
                    aux += estado[i];
                }
                else
                {
                    cont++;
                    switch (cont)
                    {
                        case 1:
                            this.canon1.setMuni(aux);
                            break;

                        case 2:
                            this.canon2.setMuni(aux);
                            break;

                        case 3:
                            this.canon3.setMuni(aux);
                            break;

                        case 4:
                            this.canon4.setMuni(aux);
                            break;

                        case 5:
                            this.Vida = int.Parse(aux);
                            this.progressBar1.Value = this.Vida;
                            break;
                    }
                    aux = "";
                }
            }
        }

        public void RecibirDanio(int danio)
        {
            this.Vida -= danio;
            if (this.Vida >= 0)
            {
                this.progressBar1.Value = this.Vida;
            }
            else
            {
                this.progressBar1.Value = 0;
            }

        }

        public void ReiniciarVida()
        {
            this.Vida = 100;
            this.progressBar1.Value = 100;
        }

        public int ConsultarDanio()
        {
            return this.Danio;
        }

        public void loadBarco(ref RecursosDisplay x)
        {
            this.recDispley = x;
            this.pic_Barco.Image = Image.FromFile(this.path + @"\Recursos\BarcO\BARCO_BaseUno.png");

            this.canon1.esDerecho();
            this.canon2.esDerecho();
            this.canon3.esIzquierdo();
            this.canon4.esIzquierdo();

            this.canon1.Parent = this.pic_Barco;
            this.canon2.Parent = this.pic_Barco;
            this.canon3.Parent = this.pic_Barco;
            this.canon4.Parent = this.pic_Barco;
        }

        private void canon1_Load(object sender, EventArgs e)
        {

        }

        private void pic_Barco_Click(object sender, EventArgs e)
        {

        }

        private void canon2_Load(object sender, EventArgs e)
        {

        }

        private void canon5_Load(object sender, EventArgs e)
        {

        }

        private void canon1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
