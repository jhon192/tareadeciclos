using System;

namespace progr
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear una aplicacion que muestre la tabla de multiplicar del (7), tips usar ciclo while*/

            int numero = 0;
            int numero2 = 0;
            while (numero<=84 && numero2<=12)
            {
                Console.WriteLine("7x{0} = {1}", numero2, numero);
                numero += 7;
                numero2 += 1;
            }

            Console.ReadKey();
        }
    }
}
