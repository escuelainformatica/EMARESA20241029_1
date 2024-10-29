using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.modelos
{
    internal class Cliente
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }

        public Cliente(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public Cliente()
        {
        }
    }
}

