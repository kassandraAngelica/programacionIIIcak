using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            Insercion a = new Insercion();
            a.Cargar();
            time.Start();
            a.InsercionDirecta();
            a.Imprimir();
            time.Stop();
            Console.WriteLine("tiempo:" + time.Elapsed.TotalSeconds + "segundos \n");

            //metodo shellshort
            shellShort b = new shellShort();
            b.cargar();
            time.Start();
            b.Shell();
            b.Imprimir();
            time.Stop();
            Console.WriteLine("tiempo:" + time.Elapsed.TotalSeconds + "segundos \n");

            //metodo quicksort
            int n;
            Console.WriteLine("Metodo de Quick Sort");
            Console.Write("Cuantos longitud del vector: ");
            n = Int32.Parse(Console.ReadLine());
            llenar c = new llenar(n);

            //metodo burbuja
            Burbuja d = new Burbuja();
            d.Cargar();
            time.Start();
            d.MetodoBurbuja();
            d.Imprimir();
            time.Stop();
            Console.WriteLine("tiempo:" + time.Elapsed.TotalSeconds + "segundos \n");

            //metodo merge sort
            Mergesort e = new Mergesort();
            e.Cargar();
            Console.ReadKey();
        }
        
    }
}
    

