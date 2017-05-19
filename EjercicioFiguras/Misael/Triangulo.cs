#define PROPIEDADES_MISAEL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioFiguras;


namespace Calculadora
{
    public partial class Triangulo: Figura, IFigura
    {
        #region Propiedades
#if PROPIEDADES_MISAEL
        public double dBase { get; set; }
        public double dAltura { get; set; }

#endif

        #endregion

#if PARAMETROS
        public double CalculaArea(double dBase, double dAltura)
#elif PROPIEDADES_MISAEL
        public override double CalcularArea()
#endif
        {
            return (dBase * dAltura) / 2;
        }

      
    }
}
