using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.ListasCircularesProcesos
{
    class Proceso
    {
        Proceso siguiente, anterior;
        int ciclos;

        public Proceso(int c)
        {
            ciclos = c;
        }

        public int Ciclos
        {
            set { ciclos = value; }
            get { return ciclos; }
        }

        public Proceso Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public Proceso Siguiente
        {
            set { siguiente = value; }
            get { return siguiente; }
        }
    }
}
