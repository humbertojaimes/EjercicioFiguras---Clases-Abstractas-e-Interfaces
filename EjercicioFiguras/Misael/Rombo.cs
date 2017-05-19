#define PROPIEDADES_MISAEL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioFiguras;

namespace Calculadora
{
    public partial class Rombo: Figura, IFigura
    {
        #region Propiedades
        #if PROPIEDADES_MISAEL
        public double dLado { get; set; }

        

#endif

        #endregion

#if PARAMETROS
         public double CalculaPerimetro(double dLado)
#elif PROPIEDADES_MISAEL
        public override double CalcularPerimetro()
        #endif
        {
            return dLado*4;
        }

      

    }
}
