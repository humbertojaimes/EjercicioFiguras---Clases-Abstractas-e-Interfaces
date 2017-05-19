#define PROPIEDADES_TERE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioFiguras;

namespace Calculadora
{
    public partial class Cuadrado:Figura, IFigura
    {
        public double CalcularArea()
        {
            return 0;
        }

    

        #region propiedades

#if PROPIEDADES_TERE
            public double Lado { get; set; }
#endif

        #endregion


#if PARAMETROS
        public double CalcularPerimetro(double Lado)
        #elif PROPIEDADES_TERE
        public double CalcularPerimetro()
        #endif

        {
            return 4 * Lado;
        }



}
}
