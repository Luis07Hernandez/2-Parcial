using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadGraficoPorTortuga
{
    class Tortuga
    {
        private int[,] tablero = new int[20, 20];
        bool escribir;
        int x, y, sentido; // 1: arriba, 2: derecha, 3: abajo, 4: izquierda
        
        public Tortuga()
        {
            escribir = false;
            sentido = 2;
            x = 0;
            y = 0;
        }

        public void subirPluma()
        {
            escribir = false;
        }

        public void bajarPluma()
        {
            escribir = true;
            tablero[x, y] = 1;
        }

        public void girarADerecha()
        {
            if (sentido == 1) sentido = 2;
            else if (sentido == 2) sentido = 3;
            else if (sentido == 3) sentido = 4;
            else sentido = 1;
        }

        public void girarAIzquierda()
        {
            if (sentido == 1) sentido = 4;
            else if (sentido == 4) sentido = 3;
            else if (sentido == 3) sentido = 2;
            else sentido = 1;
        }

        public void avanzar(int p)
        {
            if (sentido == 2 && (y + p) <= 19)
            {
                if (escribir == true)
                    for (int z = y; z <= (y + p); z++) tablero[x, z] = 1;
                y += p;
            }
            
            if (sentido == 1 && (x - p) >= 0)
            {
                if (escribir == true)
                    for (int z = x; z >= (x - p); z--) tablero[z, y] = 1;
                x -= p;
            }

            if (sentido == 3 && (x + p) <= 19)
            {
                if (escribir == true)
                    for (int z = x; z <= (x + p); z++) tablero[z, y] = 1;
                x += p;
            }

            if (sentido == 4 && (y - p) >= 0)
            {
                if (escribir == true)
                    for (int z = y; z >= (y - p); z--) tablero[x, z] = 1;
                y -= p;
            }
        }

        public void fin()
        {
            for (int a = 0; a < 20; a++)
                for (int b = 0; b < 20; b++)
                    tablero[a, b] = 0;
        }

        public override string ToString()
        {
            string cadena = "";

            for (int a = 0; a < 20; a++)
                for (int b = 0; b < 20; b++)
                {
                    if (tablero[a, b] == 1) cadena += "*";
                    else cadena += "";
                    if (b == 19) cadena += Environment.NewLine;
                    else cadena += " , ";
                }

            return cadena;
        }
    }
}
