using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Bicola
    {
        int[] cola = new int[max];
        int final = -1;
        int frente = -1;
        public static int max = 10;
        public Boolean vacia()
        {
            if (frente == -1)
                return true;
            else
                return false;
        }
        public Boolean llena()
        {
            if (frente == 0 && final == max - 1)
                return true;
            else
                return false;
        }
        public void agregarAdelante()
        {
            if (llena() == true)
                Console.WriteLine("la cola esta llena");
            else
                Console.WriteLine("agregar dato");
            if (frente == 0)
            {
                Console.WriteLine("no se puede agregar por el frente");
            }
            if (frente > 0)
            {
                frente--;
                cola[frente] = int.Parse(Console.ReadLine());
            }
            if (frente == -1)
            {
                frente++;
                cola[frente] = int.Parse(Console.ReadLine());
                if (frente == 0)
                { final = 0; }
            }
        }
        public void agregarAtras()
        {
            if (llena() == true)
                Console.WriteLine("la cola esta llena");
            else
                Console.WriteLine("agregar dato");
            if (final < max - 1)
            {
                final++;
                cola[final] = int.Parse(Console.ReadLine());
            }
            if (final == max - 1)
            {
                Console.WriteLine("no se puede agregar por el final");
            }
            if (final == -1)
            {
                final++;
                cola[final] = int.Parse(Console.ReadLine());
                if (final == 0)
                    frente = 0;
            }

        }
        public void eliminarAdelante()
        {
            if (vacia() == true)
                Console.WriteLine("La cola esta vacia");
            else
                Console.WriteLine("Se eliminara el dato por el frente" + cola[frente]);
            frente++;
        }
        public void eliminarFinal()
        {
            if (vacia() == true)
                Console.WriteLine("La cola esta vacia");
            else
                Console.WriteLine("Se eliminara el dato por el final" + cola[final]);
            final--;
        }
        public void imprimir()
        {
            if (vacia() == true)
            {
                Console.WriteLine("Cola vacia");
            }
            else
                for (int i = frente; i <= final; i++)
                    Console.Write(" " + cola[i] + '\t');
             Console.WriteLine("  ");                
        }
    }
}
