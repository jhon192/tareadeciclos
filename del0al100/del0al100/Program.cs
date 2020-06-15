using System;

namespace del0al100
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear una aplicacion que muestre la cantidad de 0 que hay del 1 al 100.*/
            Console.WriteLine("._NUMEROS DEL 1 AL 100");
            for (int i = 0; i < 101; i++)
            {
                var io = i.ToString().Length;
                Console.Write(string.Concat(" Este contador tiene:  ", io-1, " cero de "));
                Console.WriteLine(i); 
                i += 9;
            }
            
            
        }
    }
}