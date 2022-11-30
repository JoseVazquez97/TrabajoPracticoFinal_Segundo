namespace TrabajoPracticoFinalSegundo.UserControls
{
    public partial class Barco : UserControl
    {
        int Vida;
        int Danio;
        RecursosDisplay recDispley;
        int muni1;
        int muni4;
        int muni3;
        int muni2;

        public Barco()
        {
            InitializeComponent();
            this.Vida = 100;
        }

        private void cargarImagenes()
        {
            this.pictureBox1.Parent = this.pic_Barco;
            this.pictureBox2.Parent = this.pic_Barco;
            this.pictureBox3.Parent = this.pic_Barco;
            this.pictureBox4.Parent = this.pic_Barco;
            this.pictureBox1.Image = Image.FromFile(@".\Recursos\Caniones\CanionBaseDerecho.png");
            this.pictureBox2.Image = Image.FromFile(@".\Recursos\Caniones\CanionBaseDerecho.png");
            this.pictureBox3.Image = Image.FromFile(@".\Recursos\Caniones\CanionBaseIzquierdo.png");
            this.pictureBox4.Image = Image.FromFile(@".\Recursos\Caniones\CanionBaseIzquierdo.png");

        }

        public void loadBarco(ref RecursosDisplay x)
        {
            this.recDispley = x;
            this.pic_Barco.Image = Image.FromFile(@".\Recursos\BarcO\BARCO_BaseUno.png");
            cargarImagenes(); 
        }

        public void loadBarcoEnemigo()
        {
            this.pic_Barco.Image = Image.FromFile(@".\Recursos\BarcO\BARCO_BaseDos.png");
            cargarImagenes();
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

            if (this.muni1 == 1)
            {
                this.muni1 = 0;
                return true;
            }
            else if (this.muni2 == 1)
            {
                this.muni2 = 0;
                return true;
            }
            else if (this.muni3 == 1)
            {
                this.muni3 = 0;
                return true;
            }
            else if (this.muni4 == 1)
            {
                this.muni4 = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Recargar()
        {

            if (this.muni1 == 0)
            {
                this.recDispley.extraerRecurso("Bala", 1);
                this.muni1++;
                return true;
            }
            else if (this.muni2 == 0)
            {
                this.recDispley.extraerRecurso("Bala", 1);
                this.muni2++;
                return true;
            }
            else if (this.muni3 == 0)
            {
                this.recDispley.extraerRecurso("Bala", 1);
                this.muni3++;
                return true;
            }
            else if (this.muni4 == 0)
            {
                this.recDispley.extraerRecurso("Bala", 1);
                this.muni4++;
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
            mensaje = this.muni1 + "," + this.muni2 + "," + this.muni3 + "," + this.muni4 + "," + this.Vida + ",";
            return mensaje;
        }

        public void RecibirEstado(string estado)
        {
            string aux = "";
            int cont = 0;

            for (int i = 0; i < estado.Length; i++)
            {
                if (estado[i] != ',')
                {
                    aux += estado[i];
                }
                else
                {
                    cont++;
                    switch (cont)
                    {
                        case 1:
                            this.muni1 = int.Parse(aux);
                            break;

                        case 2:
                            this.muni2 = int.Parse(aux);
                            break;

                        case 3:
                            this.muni3 = int.Parse(aux);
                            break;

                        case 4:
                            this.muni4 = int.Parse(aux);
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
