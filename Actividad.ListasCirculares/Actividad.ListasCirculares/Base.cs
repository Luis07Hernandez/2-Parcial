using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.ListasCirculares
{
    class Base
    {
        string nombre;
        int minutos;
        Base siguiente, anterior;

        public Base(string n, int m)
        {
            nombre = n;
            minutos = m;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public int Minutos
        {
            get { return minutos; }
        }

        public Base Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Base Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public override string ToString()
        {
            return string.Format("{0, -20} {1, -15}", Nombre, Minutos);
        }
    }
}
