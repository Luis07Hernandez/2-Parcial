using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.AnalizadorExpresionesAritmeticas
{
    class Nodo
    {
        Nodo anterior, siguiente, hijoIzquierda, hijoDerecha;
        string dato;

        public Nodo(string c)
        {
            dato = c;
        }

        public Nodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo HijoIzquierda
        {
            get { return hijoIzquierda; }
            set { hijoIzquierda = value; }
        }

        public Nodo HijoDerecha
        {
            get { return hijoDerecha; }
            set { hijoDerecha = value; }
        }

        public override string ToString()
        {
            return dato;
        }
    }
}
