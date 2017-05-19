#if  !PARAMETROS
	#define	PROPIEDADES_
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    partial class Calculadora
    {
#region propiedades
#if PROPIEDADES_
        public decimal LongitudLado01Triangulo { get; set; }
        public decimal LongitudLado02Triangulo { get; set; }
        public decimal LongitudLado03Triangulo { get; set; }
#endif
        #endregion

#if PARAMETROS
        public decimal PerimetroTriangulo(
			decimal LongitudLado01Triangulo, 
			decimal LongitudLado02Triangulo,
			decimal LongitudLado03Triangulo)
        {
#elif PROPIEDADES_
        public decimal PerimetroTriangulo() { 
#endif 
            return LongitudLado01Triangulo + LongitudLado02Triangulo + LongitudLado03Triangulo;
        }
    }
}

