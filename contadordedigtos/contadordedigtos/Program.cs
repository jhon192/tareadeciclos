using System;
using System.Diagnostics;

namespace contadordedigtos
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            /*Crear un programa que me diga la cantidad de digitos que tiene un numero positivo.
             Mostrar en mensaje ej: El numero ingresado tiene (N) digitos*/
            
            Console.WriteLine("._CONTADOR DE DIGITOS_.");
            Console.Write("Ingrese un numero: ");
            string digito = Console.ReadLine();
            var diginum = digito.Length;
            Console.WriteLine(string.Concat("Este numero tiene: ", diginum, " Digitos"));
        }
    }
}