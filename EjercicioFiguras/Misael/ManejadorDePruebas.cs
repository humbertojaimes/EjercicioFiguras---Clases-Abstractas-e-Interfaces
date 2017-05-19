#define PROPIEDADES_MISAEL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public partial class ManejadorDePruebas
    {
        public void PruebaMisael()
        {
            Triangulo triangulo = new Triangulo();
            Rombo rombo = new Rombo();
            double AreaTriangulo;
            double PerimetroRombo;



#if PARAMETROS
          AreaTriangulo = triangulo.CalculaArea(2,3);
          PerimetroRombo = rombo.CalculaPerimetro(4);
#elif PROPIEDADES_MISAEL
          triangulo.dAltura = 4;
          triangulo.dBase = 3;
          AreaTriangulo = triangulo.CalcularArea();

          rombo.dLado=3;
          PerimetroRombo = rombo.CalcularPerimetro();
#endif
#if DEBUG
            Console.WriteLine($"El area del triangulo es {AreaTriangulo}");
            Console.WriteLine($"El perimetro del rombo es {PerimetroRombo}");
#endif
        }
    }
}
