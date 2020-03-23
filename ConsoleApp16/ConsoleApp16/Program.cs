using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            Console.WriteLine("introducir posicion");
            int n = int.Parse(Console.ReadLine());
            while (numero <= n)
            {
                Console.Write(fibonacci(numero)+" ");
                numero++;
                
            }
            Console.ReadKey();
        }
      
        public static int fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
                return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
    
}
