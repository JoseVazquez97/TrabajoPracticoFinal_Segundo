using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinalSegundo.Clases
{
    internal class Almacen
    {
        double tesoro;
        int maderas;
        int municion;
        int planoBarco;

        public double TESOROS { get {return this.tesoro; } set {this.tesoro = value; } }
        public int MADERAS { get { return this.maderas; } set { this.maderas = value; } }
        public int MUNICIONES { get { return this.municion; } set { this.municion = value; } }
        public int PLANOS { get { return this.planoBarco; } set { this.planoBarco = value; } }

        public Almacen() 
        {

        }

        
    }
}
