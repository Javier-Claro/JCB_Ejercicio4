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
            int segundoNum;
            long resultado;

            resultado = preguntar.preguntarNum();
            segundoNum = preguntar.preguntarNum();

            do
            {
                Console.Clear();

                resultado = calcular.calculoNumero(resultado, segundoNum);

                seguir = preguntar.preguntarSeguir();

                if (seguir == true)
                {
                    Console.Clear();
                    segundoNum = preguntar.preguntarNum();
                }

            } while (seguir != false);
        }
    }
}