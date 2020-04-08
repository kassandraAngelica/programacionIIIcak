using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Rentista a;
            int opcion = 0;
            Cola<Rentista> p = new Cola<Rentista>();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca nombres");
                        string nombre = Console.ReadLine();
                        string segundoNombre = Console.ReadLine();
                        Console.WriteLine("introduzca primer apellido y segundo");
                        string apellido = Console.ReadLine();
                        string segundoApellido = Console.ReadLine();
                        Console.WriteLine("introduzca Edad");
                        int edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("introduzca Sexo (M/F) ");
                        string Sexo = Console.ReadLine();
                        Console.WriteLine("introduzca estado de salud");
                        string estado = Console.ReadLine();

                        a = new Rentista(nombre, segundoNombre, apellido, segundoApellido, edad, Sexo, estado);
                        p.Insertar(a);
                        break;
                    case 2:
                        a = p.Eliminar();
                        Console.WriteLine("El elemento eliminado es {0}", a);
                        Console.ReadKey();
                        break;
                    case 3:
                        p.mostrar();
                        Console.ReadKey();
                        break;

                }

            }
        }
    }
}
