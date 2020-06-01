using System;

namespace CsharpCiclos
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i=0; i<=5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 5; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            int contador = 0;
            while (contador <= 5)
            {
                Console.WriteLine(contador++);
            }

            foreach (var item in new[] { 5,4,3,2,1,0 } )
            {
                Console.WriteLine(item);
            }

        }
    }
}
