using System;

namespace del50al100
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear una aplicacion que genere un numero aleatorio entre 50 y 100.
             Y pida al usuario si desea generar otro numero antes de terminar la aplicacion.
              El programa debe terminar cuando el usuario presione la letra 'S'*/
            
            Console.WriteLine("._NUMERO RANDOM DEL 50 AL 100_.");
            var ran = new Random();
            for (int rand = 0; rand <= 0; rand++)
            {
                Console.Write(ran.Next(50, 101));
                Console.WriteLine();  
            }
            

            Console.Write("Ponga una 'S' Si Desea Usted Terminar: ");
            string cont = Console.ReadLine();
            if (cont == "s")
            {
                Console.WriteLine();
            }

            else
            {
                for (int rand = 0; rand <= 0; rand++)
                {
                    Console.Write(ran.Next(50, 101));
                    Console.WriteLine();  
                }
            }
            
            Console.ReadKey();
              
        }
    }
}
