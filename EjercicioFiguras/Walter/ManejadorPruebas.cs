using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
	public partial class ManejadorDePruebas
    {
		public void Prueba_AreaCuadrado_PerimetroTriangulo()
        {
            var calculadora = new Calculadora();
            decimal result = 0;

            decimal longitudLadoCuadrado = 10;
#if PARAMETROS
            result = calculadora.AreaCuadrado(longitudLadoCuadrado);
#else
            calculadora.LongitudLadoCuadrado = longitudLadoCuadrado;
            result = calculadora.AreaCuadrado();
#endif

#if DEBUG
            Console.WriteLine("Longitud de lado de cuadrado : {0}", longitudLadoCuadrado.ToString());
            Console.WriteLine("Area de cuadrado : {0}", result.ToString());
#endif

            decimal longitudLado01Triangulo = 10;
            decimal longitudLado02Triangulo = 20;
            decimal longitudLado03Triangulo = 30;
#if PARAMETROS
            result = calculadora.PerimetroTriangulo(longitudLado01Triangulo, longitudLado02Triangulo, longitudLado03Triangulo);
#else
            calculadora.LongitudLado01Triangulo = longitudLado01Triangulo;
            calculadora.LongitudLado02Triangulo = longitudLado02Triangulo;
            calculadora.LongitudLado03Triangulo = longitudLado03Triangulo;
            result = calculadora.PerimetroTriangulo();
#endif

#if DEBUG
            Console.WriteLine();
            Console.WriteLine("Longitud de lado 01 de triangulo : {0}", longitudLado01Triangulo.ToString());
            Console.WriteLine("Longitud de lado 02 de triangulo : {0}", longitudLado02Triangulo.ToString());
            Console.WriteLine("Longitud de lado 03 de triangulo : {0}", longitudLado03Triangulo.ToString());
            Console.WriteLine("Perimetro de Triangulo : {0}", result.ToString());
#endif 
        }
    }
}
