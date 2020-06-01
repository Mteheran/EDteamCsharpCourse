using System;

namespace CSharpCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su edad");
            var edadUsuarioString = Console.ReadLine();

            string mensaje = int.TryParse(edadUsuarioString, out int edadUsuario) ? "Calculando edad..." : "Edad invalida";

            Console.WriteLine(mensaje);

            if(mensaje == "Edad invalida") return;

            if (edadUsuario >= 65 && edadUsuario<=200)
            {
                Console.WriteLine("Eres mayor de edad");
                Console.WriteLine("Haces parte de la tercera edad");
            }
            else if (edadUsuario >= 18 && edadUsuario <= 200) Console.WriteLine("Eres mayor de edad");
            else if(edadUsuario >200 || edadUsuario<0) Console.WriteLine("La edad es invalida");
            else Console.WriteLine("Eres menor de edad");

        }
    }
}
