using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorMapa
{

    public interface IMapa
    {
        public void Movimiento(int d);

        /*
         *  PRIMERO CARGAR LA IMAGEN DEL BARCO
         *  LUEGO GENERAR MAPA,
         *  CARGAR MAPA RECIBE EL STRING TAL CUAL
         *  SALE DE OBTENERMAPA
         *  
         *  SET DE MOVIMIETNO (1 NORTE | 2 ESTE | 3 OESTE | 4 SUR) 
         *  SI SE QUIERA CAMBIAR ESTE ORDEN, IR A LA FUNCION Y CAMBIAR LOS NUMEROS DEL SEGUNDO SWITCH
         *  ESO ES TODO...
         * 
		 * Utilizar ObteLugaActua para ver en que celda ah caido el barco.
         */
        public void CargarImagenBarco();
        public void GenerarMapa();
        public void CargarMapa(string mapa);
        public string ObtenerMapa();
		public string ObteLugaActua();
    }
    public partial class UCMapa : UserControl, IMapa
    {
        #region Enum
        enum TipoGeneracion
        {
            Isla,
            IslaF,
            M1,
            M2,
            M3,
            Barco,
            Null
        }

        enum Direccion
        {
            Norte,
            Sur,
            Este,
            Oeste
        }

        #endregion

        private TipoGeneracion lugarActual;
        private string mapa;
        private sbyte posX;
        private sbyte posY;
        Image barco;
        Direccion direccionActual;


        #region Constructores
        public UCMapa()
        {
            InitializeComponent();
            this.mapa = "";
            
        }

        public void CargarImagenBarco()
        {
            this.barco = Image.FromFile(@".\Recursos\Barco\BarcoChiquito.png");
            this.direccionActual = Direccion.Norte;
        }

        public string ObtenerMapa()
        {
            return this.mapa;
        }

        public void CargarMapa(string mapa)
        {
            this.mapa = mapa;
            string[] m = mapa.Split(';');
            tblMapa.Controls.Clear();

            #region Pre-Generacion Vacia
            for (sbyte y = 0; y < 10; y++)
            {
                for (sbyte x = 0; x < 10; x++)
                {
                    Control celda = new Control();
                    celda.Location = new Point(1, 1);
                    celda.Dock = DockStyle.Fill;
                    celda.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    tblMapa.Controls.Add(celda, x, y);
                }
            }
            #endregion

            this.posX = sbyte.Parse(m[100]);
            this.posY = sbyte.Parse(m[101]);
            this.lugarActual = obtenerTipo(m[102]);
            GenerarMapa(lugarActual, posX, posY, true);

            int aux = 0;
            for (sbyte y = 0; y < 10; y++)
            {
                for (sbyte x = 0; x < 10; x++)
                {
                    TipoGeneracion tg = obtenerTipo(m[aux]);
                    GenerarMapa(tg, x, y, true);
                    aux++;
                }
            }
            
        }

        #endregion

        #region Movimiento Direccional
        private bool Norte()
        {
            sbyte posXA = posX;
            sbyte posYA = posY;

            if (posY > 0)
            {
                posY--;
                GenerarMapa(lugarActual, posXA, posYA, true);
                GenerarMapa(TipoGeneracion.Barco, posX, posY, true);
                
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Oeste()
        {
            sbyte posXA = posX;
            sbyte posYA = posY;

            if (posX > 0)
            {
                posX--;
                GenerarMapa(lugarActual, posXA, posYA, true);
                GenerarMapa(TipoGeneracion.Barco, posX, posY, true);

                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Este()
        {
            sbyte posXA = posX;
            sbyte posYA = posY;

            if (posX < 9)
            {
                posX++;
                GenerarMapa(lugarActual, posXA, posYA, true);
                GenerarMapa(TipoGeneracion.Barco, posX, posY, true);

                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Sur()
        {
            sbyte posXA = posX;
            sbyte posYA = posY;

            if (posY < 9)
            {
                posY++;
                GenerarMapa(lugarActual, posXA, posYA, true);
                GenerarMapa(TipoGeneracion.Barco, posX, posY, true);

                return true;
            }
            else
            {
                return false;
            }
        }


        public void Movimiento(int d)
        {
           
            switch (d)
            {
                case 1:
                    Norte();
                    direccionActual = Direccion.Norte;
                    break;
                case 2:
                    barco.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    Este();
                    direccionActual = Direccion.Este;
                    break;
                case 3:
                    barco.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    Oeste();
                    direccionActual = Direccion.Oeste;
                    break;
                case 4:
                    barco.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    Sur();
                    direccionActual = Direccion.Sur;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
            switch (direccionActual)
            {
                case Direccion.Norte:
                    break;
                case Direccion.Sur:
                    barco.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case Direccion.Este:
                    barco.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                case Direccion.Oeste:
                    barco.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                default:
                    break;
            }

            this.mapa = "";
            for (sbyte y = 0; y < 10; y++)
            {
                for (sbyte x = 0; x < 10; x++)
                {
                    this.mapa += tblMapa.GetControlFromPosition(x, y).Text + ";";
                }
            }

            this.mapa += this.posX + ";" + this.posY + ";" + ObteLugaActua();
        }


        public string ObteLugaActua()
        {
            switch (lugarActual)
            {
                case TipoGeneracion.Isla:
                    return "I";
                case TipoGeneracion.IslaF:
                    return "F";
                case TipoGeneracion.M1:
                    return "M1";
                case TipoGeneracion.M2:
                    return "M2";
                case TipoGeneracion.M3:
                    return "M3";
                case TipoGeneracion.Barco:
                    return "B";
                default:
                    return "";
            }
        }
        #endregion

        #region GeneracionMapa

        private TipoGeneracion obtenerTipoCelda(sbyte x, sbyte y)
        {
            return obtenerTipo(tblMapa.GetControlFromPosition(x, y).Text);
        }

        #region Generacion Aleatoria Mapa
        public void GenerarMapa()
        {
            Random nroRandom = new Random();
            sbyte genPosIsla(sbyte isAntX)
            {

                sbyte x = (sbyte)(nroRandom.Next(0, 10));
                if (x > isAntX + 2 || x < isAntX - 2) return x;
                else return genPosIsla(isAntX);
            }
            byte aux = 0;
            bool islasGeneradas = false;
            sbyte xAnterior = 100;
            sbyte yAnterior = 100;
            List<sbyte> islas = new List<sbyte>();
            islas.Add(0);
            islas.Add(3);
            islas.Add(5);
            islas.Add(7);
            islas.Add(9);
            #region Pre-Generacion Vacia
            for (sbyte y = 0; y < 10; y++)
            {
                for (sbyte x = 0; x < 10; x++)
                {
                    Control celda = new Control();
                    celda.Location = new Point(1, 1);
                    celda.Dock = DockStyle.Fill;
                    celda.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    tblMapa.Controls.Add(celda, x, y);
                }
            }
            #endregion

            

            for (sbyte y = 0; y < 10; y++)
            {
                islasGeneradas = false;
                sbyte posIsla = genPosIsla(xAnterior);

                for (sbyte x = 0; x < 10; x++)
                {
                    if (x == posIsla && islas.Contains(y) && !islasGeneradas)
                    {
                        xAnterior = x;
                        yAnterior = y;
                        if (y == 0)
                        {
                            GenerarMapa(TipoGeneracion.IslaF, x, y, false);
							GenerarAlredorIsla(TipoGeneracion.M2,x, y);
                        }
                        else if (y == 9)
                        {
                            GenerarMapa(TipoGeneracion.Isla, x, y, false);
							GenerarAlredorIsla(TipoGeneracion.M1,x, y);
                            GenerarMapa(TipoGeneracion.Barco, x, y, false);
                            this.posX = x;
                            this.posY = y;
                        }
                        else
                        {
                            GenerarMapa(TipoGeneracion.Isla, x, y, false);
							GenerarAlredorIsla(TipoGeneracion.M1,x, y);
                        }
                    }
                    else
                    {
                        GenerarMapa(TipoGeneracion.M2, x, y, false);
                    }
                    aux++;
                }
            }

            //Post generacion para generar mar profundo

            for (sbyte x = 0; x < 10; x++)
            {
                for (sbyte y = 0; y < 10; y++)
                {
                    bool genM3 = true;

                    
                    if(x > 0 && (obtenerTipoCelda((sbyte)(x - 1), y) == TipoGeneracion.M1 || obtenerTipoCelda((sbyte)(x - 1), y) == TipoGeneracion.IslaF))
                    {
                        genM3 = false;
                    }
                    if (x < 9 && (obtenerTipoCelda((sbyte)(x + 1), y) == TipoGeneracion.M1 || obtenerTipoCelda((sbyte)(x + 1), y) == TipoGeneracion.IslaF))
                    {
                        genM3 = false;
                    }
                    if (y > 0 && (obtenerTipoCelda(x, (sbyte)(y - 1)) == TipoGeneracion.M1 || obtenerTipoCelda(x, (sbyte)(y - 1)) == TipoGeneracion.IslaF))
                    {
                        genM3 = false;
                    }
                    if (y < 9 && (obtenerTipoCelda(x, (sbyte)(y + 1)) == TipoGeneracion.M1 || obtenerTipoCelda(x, (sbyte)(y + 1)) == TipoGeneracion.IslaF))
                    {
                        genM3 = false;
                    }
                    if (obtenerTipoCelda(x,y) == TipoGeneracion.M1 || obtenerTipoCelda(x, y) == TipoGeneracion.Isla || obtenerTipoCelda(x, y) == TipoGeneracion.IslaF)
                    {
                        genM3 = false;
                    }

                    if (genM3)
                    {
                        GenerarMapa(TipoGeneracion.M3, x, y, true);
                    }

                }
            }


            for (sbyte y = 0; y < 10; y++)
            {
                for (sbyte x = 0; x < 10; x++)
                {
                    this.mapa += tblMapa.GetControlFromPosition(x, y).Text + ";";
                }
            }

            this.mapa += this.posX + ";" + this.posY + ";" + ObteLugaActua();


        }

        #endregion


        //Genera una celda del mapa
        private void GenerarMapa(TipoGeneracion g, sbyte x, sbyte y, bool rePaint)
        {
            if (x >= 0 && x <= 9 && y >= 0 && y <= 9)
            {

                Control celda = tblMapa.GetControlFromPosition(x, y);
                celda.BackgroundImage = null;
                
                switch (g)
                {
                    case TipoGeneracion.Isla:
                        celda.BackColor = Color.LightGreen;
                        celda.Text = "I";
                        break;
                    case TipoGeneracion.M1:
                        celda.BackColor = Color.LightBlue;
                        celda.Text = "M1";
                        break;
                    case TipoGeneracion.M2:
                        if (celda.Text == "" || rePaint)
                        {
                            celda.BackColor = Color.DeepSkyBlue;
                            celda.Text = "M2";
                        }
                        break;
                    case TipoGeneracion.M3:
                        celda.BackColor = Color.DarkSlateBlue;
                        celda.Text = "M3";
                        break;
                    case TipoGeneracion.IslaF:
                        celda.BackColor = Color.LightGreen;
                        celda.Text = "F";
                        break;
                    case TipoGeneracion.Barco:
                        lugarActual = obtenerTipo(celda.Text);
                        //celda.BackColor = Color.Transparent;
                        celda.BackgroundImage = barco;
                        celda.BackgroundImageLayout = ImageLayout.Stretch;
                        celda.Text = "B";
                        break;
                    default:
                        break;
                }
            }
        }

        //Recibe el texto de la celda, y lo convierte en su respectivo tipo
        private TipoGeneracion obtenerTipo(string tipo = "")
        {
            switch (tipo)
            {
                case "I":
                    return TipoGeneracion.Isla;
                case "M1":
                    return TipoGeneracion.M1;
                case "M2":
                    return TipoGeneracion.M2;
                case "M3":
                    return TipoGeneracion.M3;
                case "F":
                    return TipoGeneracion.IslaF;
                case "B":
                    return TipoGeneracion.Barco;
                default:
                    return TipoGeneracion.Null;
            }
        }

        //cuando se genera una isla, genera aguas diferentes a su alrededor
        private void GenerarAlredorIsla(TipoGeneracion tipoAlrededor, sbyte xIsla, sbyte yIsla)
        {
            Random r = new Random();

            sbyte x = xIsla;
            x--;
            for (int i = 0; i < 3; i++)
            {
                sbyte y = yIsla;
                y--;
                for (int z = 0; z < 3; z++)
                {
                    if (y != yIsla || x != xIsla)
                    {
                        if ((i == 2 || i == 0) && (z == 2 || z == 0))
                        {
                            if (r.Next(2, 5) == 4)
                            {
                                GenerarMapa(tipoAlrededor, x, y, false);
                            }
                        }
                        else
                        {
                            GenerarMapa(tipoAlrededor, x, y, false);
                        }
                        
                    }
                    y++;
                }
                x++;
            }



        }


        #endregion
        
    }
}
