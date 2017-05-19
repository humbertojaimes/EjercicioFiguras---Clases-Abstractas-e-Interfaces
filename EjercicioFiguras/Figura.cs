using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguras
{
    public abstract class Figura
    {
        public virtual double CalcularArea()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            return rnd.Next(6);
        }

        public virtual double CalcularPerimetro()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            return rnd.Next(6);
        }

        //public abstract void Obligatorio();

    }
}
