using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Actividad.ListasCircularesProcesos
{
    class Procesador
    {
        Proceso inicio, final, auxiliar, actual;
        static Random num = new Random();

        private void agregarFinal(Proceso p)
        {
            if (inicio == null)
            {
                inicio = p;
                final = p;
                inicio.Siguiente = final;
                inicio.Anterior = final;
                actual = inicio;
            }
            else
            {
                final.Siguiente = p;
                p.Siguiente = inicio;
                p.Anterior = final;
                inicio.Anterior = p;
                final = p;
            }
        }

        private void eliminarInicio()
        {
            final.Siguiente = inicio.Siguiente;
            inicio.Siguiente.Anterior = final;
            inicio = inicio.Siguiente;
        }

        private void eliminarFinal()
        {
            inicio.Anterior = final.Anterior;
            final.Anterior.Siguiente = inicio;
            final = final.Anterior;
        }

        private void eliminarActual()
        {
            if (actual == inicio) eliminarInicio();
            else if (actual == final) eliminarFinal();
            else
            {
                actual.Anterior.Siguiente = actual.Siguiente;
                actual.Siguiente.Anterior = actual.Anterior;
            }
        }

        public string procesar()
        {
            int ciclosVacios = 0, procesosPendientes = 0, procesosAtendidos = 0, ciclosPendientes = 0;
            for (int x = 0; x < 20; x++)
            {
                int n = num.Next(1, 101);
                if (n <= 5)
                {
                    n = num.Next(2, 8);
                    auxiliar = new Proceso(n);
                    agregarFinal(auxiliar);
                }
                if (inicio != null)
                {
                    actual.Ciclos--;
                    if (actual.Ciclos < 0)
                        n = 0;
                    if (actual.Ciclos == 0)
                    {
                        eliminarActual();
                        procesosAtendidos++;
                    }
                    actual = actual.Siguiente;
                }
                else
                    ciclosVacios++;
            }
            auxiliar = inicio;
            do{
                procesosPendientes++;
                ciclosPendientes += auxiliar.Ciclos;
                auxiliar = auxiliar.Siguiente;
            } while (auxiliar != inicio);

            ciclosPendientes = Math.Abs(ciclosPendientes);
        
            return "Ciclos Vacios: " + ciclosVacios + Environment.NewLine + "Procesos Pendientes: " + procesosPendientes + Environment.NewLine + "Ciclos Pendientes: " + (double)ciclosPendientes + Environment.NewLine + "Procesos Atendidos: " + procesosAtendidos;
        }
    }
}
