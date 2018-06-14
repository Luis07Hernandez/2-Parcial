using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.ListasEnlazadasDobles
{
    class Agenda
    {
        private Contacto inicio, aux;

        public void agregar(Contacto nuevo, string telefono)
        {
            int tel = int.Parse(telefono);
            if (inicio == null) inicio = nuevo;
            else if (tel < int.Parse(inicio.Telefono))
            {
                aux = inicio;
                inicio = nuevo;
                aux.Anterior = inicio;
                inicio.Siguiente = aux;
            }
            else
                agregar(nuevo, inicio, tel);
        }

        public void agregar(Contacto nuevo, Contacto x, int telefono)
        {
            if (x == null)
            {
                aux.Siguiente = nuevo;
                nuevo.Anterior = aux;
            }
            else if (int.Parse(x.Telefono) > telefono)
            {
                nuevo.Anterior = x.Anterior;
                nuevo.Siguiente = x;
                x.Anterior.Siguiente = nuevo;
                x.Anterior = nuevo;
            }
            else
            {
                aux = x;
                agregar(nuevo, x.Siguiente, telefono);
            }
        }

        public Contacto buscar(string telefono)
        {
            aux = inicio;
            int tel = int.Parse(telefono);
            bool breaq = false;

            while (aux != null && breaq != true)
            {
                if (int.Parse(aux.Telefono) >= tel)
                {
                    breaq = true;
                    if (int.Parse(aux.Telefono) == tel) return aux;
                }
                aux = aux.Siguiente;
            }
            return null;
        }

        public void eliminar(string telefono)
        {
            int tel = int.Parse(telefono);
            bool encontrado = false;
            aux = inicio;

            if (aux.Telefono == telefono) eliminarPrimero();
            else
            {
                while (aux != null && encontrado != true)
                {
                    if (int.Parse(aux.Siguiente.Telefono) >= tel)
                    {
                        encontrado = true;
                        if (int.Parse(aux.Siguiente.Telefono) == tel)
                        {
                            aux.Siguiente = aux.Siguiente.Siguiente;
                            aux.Siguiente.Anterior = aux;
                        }
                    }
                    aux = aux.Siguiente;
                }
            }
        }

        public void eliminarPrimero()
        {
            if (inicio.Siguiente == null) inicio = null;
            else
            {
                inicio = inicio.Siguiente;
                inicio.Anterior = null;
            }
        }

        public void eliminarUltimo()
        {
            aux = inicio;

            if (aux.Siguiente == null) aux = null;
            else
                while (aux.Siguiente != null) aux = aux.Siguiente;
            aux.Anterior.Siguiente = null;
        }

        public string reporteInverso()
        {
            aux = inicio;
            string cadena = "";

            while (aux.Siguiente != null) aux = aux.Siguiente;
            while (aux.Anterior != null)
            {
                cadena += aux.ToString() + Environment.NewLine;
                aux = aux.Anterior;
            }
            cadena += inicio.ToString();
            return cadena;
            /*string cadena = "";

            if (inicio.Siguiente == null) cadena += inicio.ToString();
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
            return cadena;*/
        }

        public string listar()
        {
            aux = inicio;
            string cadena = "";

            while (aux != null)
            {
                cadena += aux.ToString() + Environment.NewLine;
                aux = aux.Siguiente;
            }

            return cadena;
        }
    }
}
