//#define PARAMETROS
#define PROPIEDADES_FIDEL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora
{

    public partial class ManejadorDePruebas
    {


        Pentagono claseP = new Pentagono();

#if PARAMETROS
                  double LongiLado = 5;
                  double NroLado = 5;
                  double Constante=2;
                  double Constante_hexagono = 6;
#endif
        public void MostrarResultados()
        {
            double AreaPentagono, Perime_Hexagono;
#if PROPIEDADES_FIDEL
            claseP.LongiLado = 5;
            claseP.NroLado = 5;
            claseP.Constante = 2;
            claseP.Constante_hexagono = 6;
            AreaPentagono = claseP.CalcularArea();
            Perime_Hexagono = claseP.CalcularPerimetro();
#elif PARAMETROS
             AreaPentagono = claseP.CalcularArea(LongiLado, NroLado, Constante);
             Perime_Hexagono = claseP.CalcularArea(LongiLado, Constante_hexagono);
#endif

#if DEBUG
            Console.WriteLine("Area Pentagono: {0}", AreaPentagono);
            Console.WriteLine("Perimero Hexagono: {0}", Perime_Hexagono);
#endif
        }

    }
}
