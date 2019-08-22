using System;

namespace Ciclos_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
           int x, y, z;
            Console.WriteLine("NUMEROS DE MAYOR A MENOR Y DE MENOR A MAYOR");
            Console.WriteLine("INDICA EL PRIMER NUMERO: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INDICA EL SEGUNDO NUMERO: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SUCECION DE NUMEROS: ");
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                for (int i = x; i > y; i -= z)
                {
                    Console.WriteLine("i = " + i);
                }
            }
            else
            {
                for (int i = x; i < y; i += z)
                {
                    Console.WriteLine("i = " + i);
                }
            }

        }
    }
}
