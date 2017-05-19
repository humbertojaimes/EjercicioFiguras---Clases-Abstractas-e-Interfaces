#if  !PARAMETROS
	#define	PROPIEDADES_VVJ
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
#if PROPIEDADES_VVJ
        public decimal LongitudLadoCuadrado { get; set; }
#endif
        #endregion

#if PARAMETROS
		public decimal AreaCuadrado(decimal LongitudLadoCuadrado)
        {
#elif PROPIEDADES_VVJ
        public decimal AreaCuadrado() { 
#endif 
            return LongitudLadoCuadrado * LongitudLadoCuadrado;
        }
    }
}

