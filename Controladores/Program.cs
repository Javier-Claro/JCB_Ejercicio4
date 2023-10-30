using JCb_Ejercicio4.Servicios;

namespace Ejercicio4.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {
            PreguntaIntfz preguntar = new PreguntaImpl();
            CalculoIntfz calcular = new CalculoImpl();

            bool seguir;
            int num;

            num = preguntar.preguntarNum();

            do
            {
                Console.Clear();

                calcular.calculoNumero(num);

                seguir = preguntar.preguntarSeguir();

                if (seguir == true)
                {
                    Console.Clear();
                    num = preguntar.preguntarNum();
                }

            } while (seguir != false);
        }
    }
}