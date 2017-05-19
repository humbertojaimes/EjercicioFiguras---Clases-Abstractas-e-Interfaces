//#define PARAMETROS
#define PROPIEDADES_TERE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioFiguras;

namespace Calculadora
{
    public partial class Circulo: Figura, IFigura
    {
        #region propiedades

#if PROPIEDADES_TERE
            public double Radio { get; set; }     
#endif

        #endregion



#if PARAMETROS
        public double CalcularArea(double Radio)
#elif PROPIEDADES_TERE
        public override double CalcularArea()
#endif

        {
            return Math.PI * Math.Pow(Radio, 2);
        }


    }



}
