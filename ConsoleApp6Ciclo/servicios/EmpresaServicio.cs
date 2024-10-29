using ConsoleApp6Ciclo.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6Ciclo.servicios
{
    internal class EmpresaServicio
    {
        public static void Mostrar(Empresa empresa)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{empresa.Nombre} {empresa.Rubro} {empresa.Ganancia}");            
        }
        public static void MostrarListado(List<Empresa> empresas)
        {
            empresas.ForEach(emp => Mostrar(emp));
            Console.WriteLine("------------------------------");
        }
        // quiero sumar todas las ganancaias
        public static int Sumar(List<Empresa> empresas)
        {
            var resultado = 0;
            resultado = empresas.Sum(emp => emp.Ganancia);
            return resultado;
        }
        public static int SumarNoLinq(List<Empresa> empresas)
        {
            var resultado = 0;
            foreach(var emp in empresas)
            {
                resultado = resultado + emp.Ganancia;
            }            
            return resultado;
        }
        // filtrar las empresas que son de retail
        public static List<Empresa> FiltrarRetail(List<Empresa> empresas)
        {
            var resultados = new List<Empresa>();
            resultados = empresas.Where(emp => emp.Rubro == "retail").ToList();
            return resultados;
        }
        // filtrar las empresas con ganancias mayor a 5000
        public static List<Empresa> FiltrarPorGanancia(List<Empresa> empresas)
        {
            var resultados = new List<Empresa>();
            resultados = empresas.Where(emp=>emp.Ganancia>5000).ToList();
            return resultados;
        }
        // filtrar las empresas con ganancias mayor a 5000 y ademas construccion
        public static List<Empresa> FiltrarPorGananciaYRubro(List<Empresa> empresas)
        {
            var resultados = new List<Empresa>();
            resultados = empresas.
                Where(emp => emp.Ganancia > 5000).
                Where(emp => emp.Rubro == "construccion").
                ToList();
            return resultados;
        }
        public static List<Empresa> Ordenar(List<Empresa> empresas)
        {
            var resultados = new List<Empresa>();
            resultados = empresas.OrderByDescending(emp => emp.Ganancia).ToList();
            return resultados;
        }
        // buscar la empresa llamada homecenter
        public static Empresa Buscar(List<Empresa> empresas)
        {
            var resultado = new Empresa();
            resultado = empresas.Where(emp => emp.Nombre == "Sodimac").FirstOrDefault();
            return resultado;
        }
    }
}
