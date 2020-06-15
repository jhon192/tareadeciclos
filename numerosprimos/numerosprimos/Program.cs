using System;

namespace numerosprimos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear una aplicacion que le pida al usuario un numero positivo y el sistema identifique si es primo o no.*/
            
            Console.WriteLine("Numeros primo");
            int num = 1;
            Console.Write("Ingrese un numero primo: ");
            num = Convert.ToInt32(Console.ReadLine());
            
            if (num % 2 == 1 || num == 2)
            {
                Console.WriteLine("Este numero es primo");
            }

            else
            {
                Console.WriteLine("Este numero no es primo");
            }

        }
    }
}