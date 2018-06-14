using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.ListasEnlazadas
{
    class Catalogo
    {
        private Carro inicio, aux;

        public void agregar(Carro nuevo, string placa)
        {
            int pla = int.Parse(placa);
            if (inicio == null) inicio = nuevo;
            else if (pla < int.Parse(inicio.pPlaca))
            {
                aux = inicio;
                inicio = nuevo;
                aux.Anterior = inicio;
                inicio.Siguiente = aux;
            }
            else
                agregar(nuevo, inicio, pla);
        }

        public void agregar(Carro nuevo, Carro x, int placa)
        {
            if (x == null)
            {
                aux.Siguiente = nuevo;
                nuevo.Anterior = aux;
            }
            else if (int.Parse(x.pPlaca) > placa)
            {
                nuevo.Anterior = x.Anterior;
                nuevo.Siguiente = x;
                x.Anterior.Siguiente = nuevo;
                x.Anterior = nuevo;
            }
            else
            {
                aux = x;
                agregar(nuevo, x.Siguiente, placa);
            }
        }

        public Carro buscar(string placa)
        {
            aux = inicio;
            int pla = int.Parse(placa);
            bool breaq = false;

            while (aux != null && breaq != true)
            {
                if (int.Parse(aux.pPlaca) >= pla)
                {
                    breaq = true;
                    if (int.Parse(aux.pPlaca) == pla) return aux;
                }
                aux = aux.Siguiente;
            }
            return null;
        }

        public void eliminar(string placa)
        {
            int pla = int.Parse(placa);
            bool encontrado = false;
            aux = inicio;

            if (aux.pPlaca == placa) eliminarPrimero();
            else
            {
                while (aux != null && encontrado != true)
                {
                    if (int.Parse(aux.Siguiente.pPlaca) >= pla)
                    {
                        encontrado = true;
                        if (int.Parse(aux.Siguiente.pPlaca) == pla)
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
