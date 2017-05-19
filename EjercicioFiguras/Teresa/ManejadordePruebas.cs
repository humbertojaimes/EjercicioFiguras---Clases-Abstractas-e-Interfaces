#define PROPIEDADES_TERE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora
{
    public partial class ManejadorDePruebas
    {
        double valor = 5.5;
        
        public void AreaCirculo()
        {
            Circulo circulo = new Circulo();

#if PARAMETROS
            var result = circulo.CalcularArea(valor);
#elif PROPIEDADES_TERE
            circulo.Radio = valor;
            var result = circulo.CalcularArea();
#endif
#if DEBUG
            Console.WriteLine($"Area del Circulo: {result}");
#endif
        }

        public void PerimetroCuadrado()
        {
            Cuadrado cuadrado = new Cuadrado();

#if PARAMETROS
            var result = cuadrado.CalcularPerimetro(valor);
#elif PROPIEDADES_TERE
            cuadrado.Lado = valor;
            var result = cuadrado.CalcularPerimetro();
#endif
#if DEBUG
            Console.WriteLine($"Perimetro del Cuadrado: {result}");
#endif
        }



    }
}
