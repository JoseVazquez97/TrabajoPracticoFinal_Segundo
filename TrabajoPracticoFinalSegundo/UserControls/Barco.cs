namespace TrabajoPracticoFinalSegundo.UserControls
{
    public partial class Barco : UserControl
    {
        int Vida;
        int Acciones;

        RecursosDisplay recDispley;
        int muni1;
        int muni4;
        int muni3;
        int muni2;

        public Barco()
        {
            InitializeComponent();
            this.Vida = 100;
            this.Acciones = 0;
            int muni1 = 1;
            int muni4 = 1;
            int muni3 = 1;
            int muni2 = 1;

            int Danio = 10;
        }

        private void cargarImagenes()
        {
            /*
            this.pictureBox1.Parent = this.pic_Barco;
            this.pictureBox2.Parent = this.pic_Barco;
            this.pictureBox3.Parent = this.pic_Barco;
            this.pictureBox4.Parent = this.pic_Barco;
           // this.pictureBox1.Image = Image.FromFile(@".\Recursos\Caniones\CanionBaseDerecho.png");
            //this.pictureBox2.Image = Image.FromFile(@".\Recursos\Caniones\CanionBaseDerecho.png");
           // this.pictureBox3.Image = Image.FromFile(@".\Recursos\Caniones\CanionBaseIzquierdo.png");
           // this.pictureBox4.Image = Image.FromFile(@".\Recursos\Caniones\CanionBaseIzquierdo.png");
            */
        }

        public void loadBarco(ref RecursosDisplay x)
        {
            this.recDispley = x;
            this.pic_Barco.Image = Image.FromFile(@".\Recursos\Barco\BarcoGrande.png");
            this.pic_Barco.SizeMode = PictureBoxSizeMode.StretchImage;
            cargarImagenes(); 
        }

        public void loadBarcoEnemigo()
        {
            this.pic_Barco.Image = Image.FromFile(@".\Recursos\Barco\BarcoGrande.png");
            this.pic_Barco.SizeMode = PictureBoxSizeMode.StretchImage;
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
            mensaje = $"{muni4}-{muni3}-{muni2}-{muni1}-{Vida}-{Acciones}-";
            return mensaje;
        }

        private List<string> obternerParam(string msg) // Desglosa el mensaje recibido de otros clientes
        {
            List<string> parametros = new List<string>();
            string aux = "";

            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] != '-')
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

        public void RecibirEstado(string estado)
        {
            List<string> parametros = obternerParam(estado);
            for (int i = 0; i < parametros.Count; i++)
            {
                switch (i) 
                {
                    case 0:
                        this.muni1 = int.Parse(parametros[i]);
                        break;

                    case 1:
                        this.muni2 = int.Parse(parametros[i]);
                        break;

                    case 2:
                        this.muni3 = int.Parse(parametros[i]);
                        break;

                    case 3:
                        this.muni4 = int.Parse(parametros[i]);
                        break;

                    case 4:
                        try
                        {
                            this.Vida = int.Parse(parametros[i]);
                        }
                        catch { this.Vida = 100; }
                        break;

                    case 5:
                        this.Acciones = int.Parse(parametros[i]);
                        break;
                        
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
