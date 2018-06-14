using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.ListasEnlazadas
{
    class Agenda
    {
        public int contador = 0;
        private Contacto inicio, aux;

        public void agregar(Contacto nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                contador++;
            }
            else
                agregar(nuevo, inicio);
        }

        public void eliminarPrimero()
        {
            if (inicio.Siguiente == null) inicio = null;
            else
                inicio = inicio.Siguiente;
            contador--;
        }

        public void eliminarUltimo()
        {
            aux = inicio;

            if (aux.Siguiente == null) aux = null;
            else
                while (aux != null)
                {
                    if (aux.Siguiente.Siguiente == null) aux.Siguiente = null;
                    aux = aux.Siguiente;
                }
            contador--;
        }

        public string reporteInverso()
        {
            string cadena = "";

            if (inicio.Siguiente == null) return cadena;
            else
            {
                int con = contador;
                while (con != 0)
                {
                    aux = inicio;
                    for (int x = 0; x < con - 1; x++) aux = aux.Siguiente;
                    cadena += aux.ToString() + Environment.NewLine;
                    con--;
                }
            }
            return cadena;
        }

        public void invertirLista()
        {
            Contacto inicioNuevo = null, ultimoNuevo = inicio;
            int con = contador;
            while (con != 0)
            {
                aux = inicio;
                Contacto sigNuevo = null;
                for (int x = 0; x < con - 1; x++)
                {
                    aux = aux.Siguiente;
                    if (x == contador - 2) inicioNuevo = aux;
                    if (x == con - 3) sigNuevo = aux;
                    if (con == 2) sigNuevo = ultimoNuevo;
                }
                aux.Siguiente = sigNuevo;
                con--;
            }
            inicio = inicioNuevo;
        }

        public void agregar(Contacto nuevo, Contacto x)
        {
            if (x.Siguiente == null)
            {
                x.Siguiente = nuevo;
                contador++;
            }
            else
                agregar(nuevo, x.Siguiente);
        }

        public Contacto buscar(string telefono)
        {
            aux = inicio;

            while (aux != null)
            {
                if (aux.Telefono == telefono) return aux;
                aux = aux.Siguiente;
            }

            return null;
        }

        public void eliminar(string telefono)
        {
            bool encontrado = false;
            aux = inicio;

            if (aux.Telefono == telefono) eliminarPrimero();
            else
            {
                while (aux != null && encontrado != true)
                {
                    if (aux.Siguiente.Telefono == telefono)
                    {
                        aux.Siguiente = aux.Siguiente.Siguiente;
                        encontrado = true;
                        contador--;
                    }
                    aux = aux.Siguiente;
                }
            }
        }

        public void insertar(int pos, Contacto con)
        {
            int posReal = pos - 1;
            aux = inicio;

            if (posReal == 0)
            {
                inicio = con;
                inicio.Siguiente = aux;
            }
            else
            {
                Contacto sigNuevo;
                for (int x = 0; x < posReal - 1; x++) aux = aux.Siguiente;
                sigNuevo = aux.Siguiente;
                con.Siguiente = sigNuevo;
                aux.Siguiente = con;
            }
        }

        public string listar()
        {
            aux = inicio;
            string cadena = "";

            while(aux != null)
            {
                cadena += aux.ToString() + Environment.NewLine;
                aux = aux.Siguiente;
            }

            return cadena;
        }
    }
}
