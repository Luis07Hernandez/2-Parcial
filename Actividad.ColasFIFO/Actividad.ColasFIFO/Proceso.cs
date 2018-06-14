using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.ColasFIFO
{
    class Proceso
    {
        int ciclos;
        Proceso siguiente;

        public Proceso(int t)
        {
            ciclos = t;
        }

        public int Ciclos
        {
            get { return ciclos; }
            set { ciclos = value; }
        }

        public Proceso Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
