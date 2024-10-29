using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6Ciclo.modelos
{
    internal class Empresa
    {
        public string Nombre { set; get; }
        public string Rubro { set; get; }
        public int Ganancia { set; get; }

        public Empresa()
        {
        }

        public Empresa(string nombre, string rubro, int ganancia)
        {
            Nombre = nombre;
            Rubro = rubro;
            Ganancia = ganancia;
        }
    }
}
