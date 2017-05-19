//#define PARAMETROS
#define PROPIEDADES_FIDEL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;
using EjercicioFiguras;

namespace Calculadora
{
    public partial class Pentagono:IFigura
    {

        #region propiedades
        #if PROPIEDADES_FIDEL
              public double LongiLado { get; set; }
              public double NroLado { get; set; }
              public double Constante { get; set; }
              public double Constante_hexagono { get; set; }  
            

              public Pentagono()
              {
                  
                
              }
          
        #endif
        #endregion

        #if PARAMETROS
             public double AreaPentagono(double LongiLado,double NroLado, double Constante)
         #elif PROPIEDADES_FIDEL
              public  double CalcularArea()
        #endif
           {
               double Perimetro = (NroLado * LongiLado);
               double Ap = Math.Sqrt(Math.Pow(LongiLado, 2) + Math.Pow((LongiLado / Constante), 2));
               double Area = (Perimetro * Ap) / Constante;             
               return Area;
           }




        #if PARAMETROS  
             public double Perimetro_Hexagono(double LongiLado, double Constante_hexagono)
        #elif PROPIEDADES_FIDEL
             public  double CalcularPerimetro()
        #endif
          {
              double perimetro = LongiLado * Constante_hexagono;
             return perimetro;
          }

    }
}
