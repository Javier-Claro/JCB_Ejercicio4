using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCb_Ejercicio4.Servicios
{
    internal class CalculoImpl : CalculoIntfz
    {
        public void calculoNumero(int num) { 

        long resultado = 1;

        for (int i = 1; i <= num; i++)
            {
                resultado = resultado * i;
            }
            Console.WriteLine("\n\tEl resultado es: {0}", resultado);
        }
    }
}
