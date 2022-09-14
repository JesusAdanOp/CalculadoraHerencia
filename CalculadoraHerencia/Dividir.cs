using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraHerencia
{
    internal class Dividir : Operaciones
    {
        public double operar(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 / v2;
            return Resultado;
        }
    }
}

