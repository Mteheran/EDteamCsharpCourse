using System;

namespace CSharpExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroString = Console.ReadLine();

            try
            {
                int numero = int.Parse(numeroString);  
                Console.WriteLine($"has escrito el número: {numero}");
            }
            catch(FormatException fx)
            {
                Console.WriteLine("el dato ingresado no es un número");

                #if DEBUG
                    Console.WriteLine(fx.Message);
                    Console.WriteLine(fx.StackTrace);
                #endif

            }
            catch (Exception)
            {
                Console.WriteLine("Ha Ocurrido un error");
            }

        }
    }
}
