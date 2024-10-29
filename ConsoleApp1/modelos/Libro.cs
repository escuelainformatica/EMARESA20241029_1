using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.modelos
{
    internal class Libro
    {
        public string Titulo { set; get; }
        public string Genero { set; get; }
        public int CantPagina { set; get; }
        public int Precio { set; get; }
        public int Stock { set; get; }

        public Libro()
        {
        }

        public Libro(string titulo, string genero, int cantPagina, int precio, int stock)
        {
            Titulo = titulo;
            Genero = genero;
            CantPagina = cantPagina;
            Precio = precio;
            Stock = stock;
        }
    }
}
