using System;

namespace progr
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear una aplicacion que muestre la tabla de multiplicar del (7), tips usar ciclo while*/

            int numero = 0;
            while (numero<=84)
            {
                Console.WriteLine("Esto es un numero de la tabla del 7:  " + numero);
                numero += 7;
            }

            Console.ReadKey();
        }
    }
}