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
        public enum Movimiento
        {
            Subir,
            Bajar,
            Quieto
        }
        public enum Evento
        {
            Barco,
            Pesca,
            Isla,
            Nada
        }
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

        public void loadBarco(int ancho, int alto, ref RecursosDisplay x)
        {
            this.recDispley = x;
            this.Width = ancho;
            this.Height = alto;
            this.pic_Barco.Width = ancho / 2;
            this.pic_Evento.Width = ancho / 2;
            this.pic_Evento.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Barco.Image = Image.FromFile(@".\Recursos\Gifs\Barco\BarcoQuieto.png");
            this.pic_Evento.Image = Image.FromFile(@".\Recursos\Gifs\Muelles\MuelleFinal.png");
            this.pBarBarco.Location = new Point(0, this.Height - pBarBarco.Height);
            this.pBarEnemigo.Location = new Point(2000, 2000);
        }

        public void ejecutarEvento(int x) 
        {
            switch (x)
            {
                case 1:
                    MovimientoBarco(Movimiento.Subir);
                    ImagenEvento(Evento.Isla);
                    break;
            }
        }

        public bool Curar()
        {

            if (this.pBarBarco.Value <= this.Vida - 10)
            {
                this.pBarBarco.Value = this.Vida + 10;
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
                this.pBarBarco.Value = this.Vida;
            }
            else
            {
                this.pBarBarco.Value = 0;
            }

        }

        public void ReiniciarVida()
        {
            this.Vida = 100;
            this.pBarBarco.Value = 100;
        }

        
        public void MovimientoBarco(Movimiento move)
        {
            switch (move)
            {
                case Movimiento.Subir:
                    this.pic_Barco.Image = Image.FromFile(@".\Recursos\Gifs\Barco\Salir.gif");
                    break;
                case Movimiento.Bajar:
                    this.pic_Barco.Image = Image.FromFile(@".\Recursos\Gifs\Barco\Entrar.gif");
                    break;
                case Movimiento.Quieto:
                    this.pic_Barco.Image = Image.FromFile(@".\Recursos\Gifs\Barco\BarcoQuieto.png");
                    break;
                default:
                    break;
            }
        }
        
        public async void ImagenEvento(Evento evento)
        {
            this.pBarEnemigo.Location = new Point(2000, 2000);
            MovimientoBarco(Movimiento.Subir);
            await Task.Delay(4000);


            switch (evento)
            {
                case Evento.Barco:
                    this.pic_Evento.Image = Image.FromFile(@".\Recursos\Gifs\Barco\BarcoQuieto.png");
                    this.pBarEnemigo.Location = new Point(this.Width - pBarEnemigo.Width, this.Height - pBarEnemigo.Height);
                    break;
                case Evento.Pesca:
                    this.pic_Evento.Image = Image.FromFile(@".\Recursos\Gifs\Pezca\pezfinal.png");
                    break;
                case Evento.Isla:
                    this.pic_Evento.Image = Image.FromFile(@".\Recursos\Gifs\Muelles\MuelleFinal.png");
                    break;
                case Evento.Nada:
                    this.pic_Evento.Image = null;
                    break;
                default:
                    break;
            }

            MovimientoBarco(Movimiento.Bajar);
            await Task.Delay(2500);
            MovimientoBarco(Movimiento.Quieto);

        }



        
    }
}
