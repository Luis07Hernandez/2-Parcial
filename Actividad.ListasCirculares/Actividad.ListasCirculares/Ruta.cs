using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.ListasCirculares
{
    class Ruta
    {
        Base inicio, fin, aux;

        public void agregarFinal(Base b)
        {
            if (inicio == null)
            {
                inicio = b;
                inicio.Siguiente = b;
                inicio.Anterior = b;
                fin = b;
            }
            else
            {
                fin.Siguiente = b;
                b.Anterior = fin;
                b.Siguiente = inicio;
                inicio.Anterior = b;
                fin = b;
            }
        }

        public Base buscar(string n)
        {
            aux = inicio.Siguiente;
            if (inicio.Siguiente != inicio)
                if (inicio.Nombre == n) return inicio;
                else
                    while (aux != inicio)
                    if (aux.Nombre == n) return aux;
                        else aux = aux.Siguiente;
           return null;
        }
        
        public Base eliminarUltimo()
        {
            Base eliminada = fin;
            aux = inicio;
            aux.Anterior = fin.Anterior;
            fin.Anterior.Siguiente = inicio;
            fin = fin.Anterior;
            return eliminada;
        }
        
        public Base eliminarInicio()
        {
            Base eliminada = inicio;
            aux = inicio;
            fin.Siguiente = aux.Siguiente;
            aux.Siguiente.Anterior = fin;
            inicio = aux.Siguiente;
            return eliminada;
        }
        
        public Base eliminar(string n)
        {
            Base eliminado;
            aux = inicio.Siguiente;
            if (inicio.Nombre == n)
            {
                eliminado = inicio;
                eliminarInicio();
                return eliminado;
            }
            else
                while (aux != inicio)
                    if (aux.Nombre == n)
                    {
                        eliminado = aux;
                        if (aux == fin) eliminarUltimo();
                        else
                        {
                            aux.Anterior.Siguiente = aux.Siguiente;
                            aux.Siguiente.Anterior = aux.Anterior;
                        }
                        return eliminado;
                    }
                    else aux = aux.Siguiente;
            return null;
        }
        
        public string Listar()
        {
            aux = inicio.Siguiente;
            string cadena = string.Format("{0, -20} {1, -15}", "Base", "Minutos");
            cadena += Environment.NewLine + inicio.ToString() + Environment.NewLine;

            while (aux != inicio)
            {
                cadena += aux.ToString() + Environment.NewLine;
                aux = aux.Siguiente;
            }

            return cadena;
        }

        public void insertar(Base b, int p)
        {
            aux = inicio;
            for (int x = 0; x < p - 1; x++) aux = aux.Siguiente;
            b.Siguiente = aux;
            b.Anterior = aux.Anterior;
            aux.Anterior = b;
            b.Anterior.Siguiente = b;
            if (p == 1) inicio = b;
        }

        public string ruta(Base b, DateTime horaI, DateTime horaF)
        {
            string cadena = "";
            aux = inicio;
            
            while (aux.Nombre != b.Nombre) aux = aux.Siguiente;

            cadena += "BASE " + "HORA" + Environment.NewLine + aux.Nombre + "   " + horaI.Hour + ":" + horaI.Minute + Environment.NewLine;

            while (horaI < horaF)
            {
                aux = aux.Siguiente;
                horaI = horaI.AddMinutes(aux.Minutos);
                cadena += aux.Nombre + "    " + horaI.Hour + ":" + horaI.Minute + Environment.NewLine;
            }

            return cadena;
        }
    }
}
