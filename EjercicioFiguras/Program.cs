using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;

namespace EjercicioFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            //ManejadorDePruebas manejadordePruebas = new 
            //    ManejadorDePruebas();
            //manejadordePruebas.MostrarResultados();
            //manejadordePruebas.PruebaMisael();
            //manejadordePruebas.AreaCirculo();
            //manejadordePruebas.PerimetroCuadrado();
            //manejadordePruebas.Prueba_AreaCuadrado_PerimetroTriangulo();

            Pruebas();

            Console.ReadLine();
        }


        public static void Pruebas()
        {
            IList<IFigura> figuras = new List<IFigura>();

            Cuadrado cuadrado = new Cuadrado();
            cuadrado.Lado = 5;
            Triangulo triangulo = new Triangulo();
            triangulo.dAltura = 3;
            triangulo.dBase = 5;
            Pentagono pentagono = new Pentagono();
            pentagono.LongiLado = 5;
            pentagono.Constante = 2;
            pentagono.NroLado = 5;
            pentagono.Constante_hexagono = 6;
            Rombo rombo = new Rombo();
            rombo.dLado = 13;

            figuras.Add(rombo);
            figuras.Add(cuadrado);
            figuras.Add(triangulo);
            figuras.Add(pentagono);

            foreach (var figura in figuras)
            {
                var area = figura.CalcularArea();
                var perimetro = figura.CalcularPerimetro();
                Console.WriteLine($"Figura  {figura}");
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimetro: {perimetro}");

            }
            Console.ReadKey();
        }

    }
}
