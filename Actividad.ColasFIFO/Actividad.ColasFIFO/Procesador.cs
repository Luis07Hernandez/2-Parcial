using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.ColasFIFO
{
    class Procesador
    {
        Proceso inicio, aux;
        static Random num = new Random();

        private void agregarFinal(Proceso p)
        {
            if (inicio == null) inicio = p;
            else
                agregar(p, inicio);
        }

        private void agregar(Proceso nuevo, Proceso x)
        {
            if (x.Siguiente == null)
            {
                x.Siguiente = nuevo;
            }
            else
                agregar(nuevo, x.Siguiente);
        }

        private void eliminarInicio()
        {
            if (inicio.Siguiente == null) inicio = null;
            else
                inicio = inicio.Siguiente;
        }

        public string procesar()
        {
            int ciclosVacio = 0, procesosAtendidos = 0, procesosPendientes = 0, ciclosPendientes = 0;
            for (int x = 0; x < 300; x++)
            {
                int n = num.Next(1, 101);
                if (n <= 35)
                {
                    n = num.Next(4, 15);
                    aux = new Proceso(n);
                    agregarFinal(aux);
                }
                if (inicio != null)
                {
                    inicio.Ciclos--;
                    if (inicio.Ciclos == 0)
                    {
                        eliminarInicio();
                        procesosAtendidos++;
                    }
                }
                else ciclosVacio++;
            }
            aux = inicio;
            if (inicio != null)
                while (aux != null)
                {
                    procesosPendientes++;
                    ciclosPendientes += aux.Ciclos;
                    aux = aux.Siguiente;
                }
            return "Ciclos Vacio: " + ciclosVacio + Environment.NewLine + "Procesos Atendidos: " + procesosAtendidos + Environment.NewLine + "Procesos Pendientes: " + procesosPendientes + Environment.NewLine + "Ciclos Pendientes: " + ciclosPendientes;
        }
    }
}
