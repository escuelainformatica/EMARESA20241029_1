using ConsoleApp1.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.servicios
{
    internal class LibroSrv
    {
        // filtrar libro por genero   List<Libro> ======funcion ======> List<Libro>
        public static List<Libro> FiltrarPorGenero(List<Libro> libros,string genero)
        {
            var resultados = new List<Libro>();
            resultados = libros.Where(lib => lib.Genero == genero).ToList();
            return resultados;
        }
        // filtrar por libro por cantidad de paginas y que este en stock
        public static List<Libro> FiltrarPaginaStock(List<Libro> libros, int numPagina)
        {
            var resultados = new List<Libro>();
            resultados = libros.
                Where(lib => lib.CantPagina > numPagina).
                Where(lib=> lib.Stock > 0).
                ToList();
            //resultados = libros.Where(lib => lib.CantPagina > numPagina && lib.Stock > 0).ToList();
            return resultados;
        }
        // obtener el promedio de precio que estan en stock.
        public static double ObtenerPromedioConStock(List<Libro> libros)
        {
            var resultado =0.0;
            resultado = libros.
                Where(lib => lib.Stock > 0).
                Average(lib => lib.Precio);
            return resultado;
        }



    }
}
