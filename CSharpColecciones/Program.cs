using System;
using System.Collections.Generic;

namespace CSharpColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] listaDeNumeros = new int[5] { 1, 2, 3,4, 5 };

            //for (int i = 0; i < listaDeNumeros.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un número");
            //    listaDeNumeros[i] = int.Parse(Console.ReadLine());
            //}

            //foreach (var item in listaDeNumeros)
            //{
            //    Console.WriteLine(item);
            //}

            //var listaDeDatos = new Dictionary<string, int>();

            //string valorDigitado = "";
            //while (valorDigitado != ".")
            //{
            //    Console.WriteLine("Ingrese número o ingrese . para terminar");

            //    valorDigitado = Console.ReadLine();

            //    if (valorDigitado != ".")
            //    {
            //        try
            //        {
            //                listaDeDatos.Add(Guid.NewGuid().ToString(), int.Parse(valorDigitado));
            //        }
            //        catch (Exception)
            //        {
            //            Console.WriteLine("El dato ingresado no es un numero o ya existe dentro de la colección");
            //        }

            //    }

            //}

            //foreach (var item in listaDeDatos)
            //{
            //    Console.WriteLine($"Clave: {item.Key} - Valor: {item.Value} ");
            //}

            var listaDePorcentajes = new List<short>();
            listaDePorcentajes.Add(50);
            listaDePorcentajes.Add(30);
            listaDePorcentajes.Add(70);

            Console.WriteLine($"Mi lista contiene {listaDePorcentajes.Count} elementos ");

            Console.WriteLine($"Mi lista contiene 80? {listaDePorcentajes.Contains(80)} ");

            foreach (var item in listaDePorcentajes)
            {
                Console.WriteLine(item);
            }

        }
    }
}
