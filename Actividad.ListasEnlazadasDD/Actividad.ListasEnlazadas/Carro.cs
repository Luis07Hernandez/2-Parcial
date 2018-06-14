using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.ListasEnlazadas
{
    class Carro
    {
        private string nombre = "", Modelo, Placa, Marca, Color;
        private Carro siguiente, anterior;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string mModelo
        {
            get { return Modelo; }
            set { Modelo = value; }
        }

        public string pPlaca
        {
            get { return Placa; }
            set { Placa = value; }
        }

        public string mMarca
        {
            get { return Marca; }
            set { Marca = value; }
        }

        public string cColor
        {
            get { return Color; }
            set { Color = value; }
        }

   

        public Carro Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

    
        public Carro Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }


        public override string ToString()
        {
           return "Nombre: " + Nombre + " Modelo: " + mModelo + " Placa: " + pPlaca + " Color: " + cColor +  " Marca: " + mMarca;
        }
    }
}
