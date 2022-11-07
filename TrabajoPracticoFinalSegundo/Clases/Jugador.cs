using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinalSegundo.Clases
{
    abstract class Jugador
    {

        int id;
        string dirIp;
        string name;
        Image foto;

        public string NOMBRE { get { return this.name; } }

        public virtual void Votar() 
        {

        }

        public virtual void Motin() 
        {

        }


    }
}
