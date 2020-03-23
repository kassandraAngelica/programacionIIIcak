﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp10
{
    class llenar
    {
        Stopwatch t = new Stopwatch();
        int h;
        int[] vector;
        public llenar(int n)
        {
            h = n;
            vector = new int[h];
            for (int i = 0; i < h; i++)
            {
                Console.Write("ingrese valor {0}: ", i + 1);
                vector[i] = Int32.Parse(Console.ReadLine());
            }
            quicksort(vector, 0, h - 1);
            mostrar();
        }
        
        private void quicksort(int[] vector, int primero, int ultimo)
        {
            t.Start();
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vector, i, ultimo);
            }
        }

        private void mostrar()
        {
            Console.WriteLine("Vector ordenados en forma ascendente");
            for (int i = 0; i < h; i++)
            {
                Console.Write("{0} ", vector[i]);
            }
            Console.WriteLine("   ");
            t.Stop();
            Console.WriteLine("tiempo:" + t.Elapsed.TotalSeconds + "segundos \n");
        }
    }
}
