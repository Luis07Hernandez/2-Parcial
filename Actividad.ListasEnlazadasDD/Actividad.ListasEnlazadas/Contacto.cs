using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.ListasEnlazadas
{
    class Contacto
    {
        private string nombre = "", aPaterno, aMaterno, email, telefono, edad;
        private Contacto siguiente;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string APaterno
        {
            get { return aPaterno; }
            set { aPaterno = value; }
        }

        public string AMaterno
        {
            get { return aMaterno; }
            set { aMaterno = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public Contacto Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public override string ToString()
        {
            return "N: " + Nombre + " AP: " + APaterno + " AM: " + AMaterno + " T: " + Telefono + " E: " + Edad + " Em: " + Email;
        }
    }
}
