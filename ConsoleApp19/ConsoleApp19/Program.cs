using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            
            ListaDoble l = new ListaDoble();
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

                        Infectados a = new Infectados(nombre, segundoNombre, apellido, segundoApellido, edad, Sexo, estado);
                        l.Insertar(a);
                        break;
                    case 2:
                        Console.WriteLine("¿Que apellido desea eliminar");
                        string x = (Console.ReadLine());
                        l.EliminarApellido(x);
                        Console.ReadKey();
                        break;
                    case 3:
                        l.Mostrar();
                        Console.ReadKey();
                        break;

                }
            }
        }
    }
    
}
