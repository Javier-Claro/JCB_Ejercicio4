using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCb_Ejercicio4.Servicios
{
    internal class CalculoImpl : CalculoIntfz
    {
        public long calculoNumero(long num1, int num2) { 

        long resultado;

        resultado = num1 * num2;
            Console.WriteLine("\n\tEl resultado es: {0}", resultado);
            return resultado;
        }
    }
}
