using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular cel = new Celular(Marca.Samsung ,"A20",new TamañoPantalla(10,15) , Color.Blanco , 16 ,new Procesador("agsdcdg",6,2.5));
            Celular c2 = (Celular)cel.clone();
            Celular c3 = (Celular)cel.clone();
            Celular c4 = (Celular)cel.clone();
            Celular c5 = (Celular)cel.clone();
            Console.WriteLine(cel);

            Console.ReadKey();
        }
    }
}
