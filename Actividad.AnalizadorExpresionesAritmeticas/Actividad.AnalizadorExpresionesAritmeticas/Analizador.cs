using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.AnalizadorExpresionesAritmeticas
{
    class Analizador
    {
        Nodo inicio, Auxiliar;

        public void agregarFinal(Nodo nNodo)
        {
            if (inicio == null) inicio = nNodo;
            else
                agregar(inicio, nNodo);
        }

        private void agregar(Nodo x, Nodo nuevo)
        {
            if (x.Siguiente == null)
            {
                x.Siguiente = nuevo;
                nuevo.Anterior = x;
            }
            else
                agregar(x.Siguiente, nuevo);
        }

        private void reproducir(Nodo padre) //crearHijos
        {
            padre.HijoIzquierda = padre.Anterior;
            padre.HijoDerecha = padre.Siguiente;
            padre.Anterior = padre.Anterior.Anterior;
            if (padre.HijoIzquierda == inicio) inicio = padre;
            else
                padre.Anterior.Siguiente = padre;
            padre.Siguiente = padre.Siguiente.Siguiente;
            if (padre.Siguiente != null) padre.Siguiente.Anterior = padre;
        }

        public string analizar()
        {
            Auxiliar = inicio;
            string pre = "", post = "";
            while (Auxiliar != null)
            {
                string c = Auxiliar.ToString();
                if (c == "/" || c == "*") reproducir(Auxiliar);
                Auxiliar = Auxiliar.Siguiente;
            }
            Auxiliar = inicio;
            while (Auxiliar != null)
            {
                string c = Auxiliar.ToString();
                if (c == "+" || c == "-") reproducir(Auxiliar);
                Auxiliar = Auxiliar.Siguiente;
            }
            preOrder(inicio, ref pre);
            postOrder(inicio, ref post);
            return "PREOrder" + pre + Environment.NewLine + "POSTOrder: " + post;
        }

        private void preOrder(Nodo x, ref string cadena)
        {
            if (x != null)
            {
                cadena += x.ToString() + " ";
                preOrder(x.HijoIzquierda, ref cadena);
                preOrder(x.HijoDerecha, ref cadena);
            }
        }

        private void postOrder(Nodo x, ref string cadena)
        {
            if (x != null)
            {
                postOrder(x.HijoIzquierda, ref cadena);
                postOrder(x.HijoDerecha, ref cadena);
                cadena += x.ToString() + " ";
            }
        }
    }
}
