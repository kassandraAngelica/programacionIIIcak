using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mayor de {0}, {1} y {2} es: {3}", 2, 3, 4, Mayor(2, 3, 4));
            Console.WriteLine("Menor es: {3}\n", 2, 3, 4, Menor(2, 3, 4));


            Console.WriteLine("Mayor de {0}, {1} y {2} es: {3}", 3.1, 4.6, 2.3, Mayor(3.1, 4.6, 2.3));
            Console.WriteLine("Menor es:{3}\n", 3.1, 4.6, 2.3, Menor(3.1, 4.6, 2.3));

            Console.WriteLine("Mayor de {0}, {1} y {2} es: {3}","Juan", "Pedro", "Maria", Mayor("Juan", "Pedro", "Mario"));
            Console.WriteLine("Menor es: {3}\n", "Juan", "Pedro", "Maria", Menor("Juan", "Pedro", "Mario"));

            Console.ReadKey();
        }

        private static T Mayor<T>(T x, T y, T z)
            where T : IComparable<T>
        {
            T max = x;
            if (y.CompareTo(max) > 0)
                max = y;
            if (z.CompareTo(max) > 0)
                max = z;
            return max;


        }
         private static T Menor<T>(T x, T y, T z)
            where T : IComparable<T>
         {
            T min = x;

            if (y.CompareTo(min) < 0)
                min = y;
            if (z.CompareTo(min) < 0)
                min = z;
   
            return min;
         }

    }
}
