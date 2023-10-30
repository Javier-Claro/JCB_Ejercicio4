using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCb_Ejercicio4.Servicios
{
    internal class PreguntaImpl : PreguntaIntfz
    {
        public bool preguntarSeguir()
        {
            bool seguir;
            string letra;

            do
            {

                Console.Write("\n\t¿Desea seguir con los cálculos? ('s' = si    'n' = no): ");
                letra = Convert.ToString(Console.ReadLine());

                if (letra == "s")
                    seguir = true;
                else
                    seguir = false;

            } while (letra != "s" && letra != "n");

            return seguir;
        }

        public int preguntarNum()
        {
            Console.Write("\n\t¿Que numero desea añadir a la lista de multiplicar:? ");
            int numMultiplicar = Convert.ToInt32(Console.ReadLine());

            return numMultiplicar;
        }
    }
}
