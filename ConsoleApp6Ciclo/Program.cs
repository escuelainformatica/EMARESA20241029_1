// List<*>

using ConsoleApp6Ciclo.modelos;
using ConsoleApp6Ciclo.servicios;

var paises = new List<string> { "Chile", "Argentina", "Peru","Bolivia" };

// el mas flexible, pero requiere mas trabajo
Console.WriteLine("For:");
for (int i=0;i<4;i++)
{
    Console.WriteLine(paises[i]);
}
// lo podemos utilizar cuando tenemos un listado (arreglo o similar)
// no tiene tanta flexibilidad como el caso anterior.
Console.WriteLine("Foreach:");
foreach (var pais in paises)
{
    Console.WriteLine(pais);
}
// do/while: se usa cuando no tenemos un listado y no sabemos cuando va a terminar el ciclo
var texto = "";
Console.WriteLine("Escriba algo para salir:");
/*
while(texto=="")
{
    Console.Write("Ingrese un texto :");
    texto = Console.ReadLine();
}*/

// LINQ:
// LAMBDA alias =>(entonces) se hace algo
// LAMBDA (alias,alias) => ....
Console.WriteLine("LINQ:");
paises.ForEach(pais => Console.WriteLine(pais)); // esta funcion va a realizar una operacion por cada elemento del listado

// 2003 .net
//      para conectarse a la base de datos, se usa ado.net
// 2008 ado.net => LINQ2SQL sirve para conectarse a la base de datos.
//                          esta tecnologia es limitada.
//                          esto es una tecnologia MUERTA.
//                          LINQ sigue viva (sirve para base de datos y ademas para arreglos y listados)
// 2010 ado.net => LINQ2SQL => Entity Frameworks.
//                             LINQ + ADO.NET = Entity Frameworks.

Console.WriteLine("---Ejemplo Empresa-----------");
var empresas = new List<Empresa>
{
    new Empresa("Sodimac","construccion",5555),
    new Empresa("Easy","construccion",3000),
    new Empresa("Construmart","construccion",3000),
    new Empresa("Falabella","retail",7000),
    new Empresa("Paris","retail",9000),
};
EmpresaServicio.Mostrar(empresas[0]);
EmpresaServicio.MostrarListado(empresas);
Console.WriteLine("Empresas retail:");
EmpresaServicio.MostrarListado(EmpresaServicio.FiltrarRetail(empresas));
Console.WriteLine("Empresas ordenadas por ganancias:");
EmpresaServicio.MostrarListado(EmpresaServicio.Ordenar(empresas));
Console.WriteLine("Buscar empresa:");
EmpresaServicio.Mostrar(EmpresaServicio.Buscar(empresas));