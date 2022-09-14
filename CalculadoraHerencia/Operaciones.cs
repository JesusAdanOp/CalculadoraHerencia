using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraHerencia
{
    internal class Operaciones
    {
        protected double valor1;
        protected double resultado; 
        protected double valor2;

        public double Valor1
        {
            get { return valor1; }
            set { valor1 = value; }
        }
       
        public double Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }
        
        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

    }
}
