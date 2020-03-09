using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Registro[] listaregistro = new Registro[4];
            InsertarTodos(listaregistro);
            int opcion = 0;
            while (opcion != 5)
            {
                Console.Clear();
                Console.WriteLine("1.- ");
                Console.WriteLine("2.- ");
                Console.WriteLine("3.- ");
                Console.WriteLine("4.- ");
                Console.WriteLine("5.- ");

                Console.WriteLine("6.- Salir");


                Console.Write("Introduzca opcion ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;

                    default:
                        break;
                }
            }
        }
       
        static void InsertarTodos(Registro[] listaalumnos)
        {
            listaalumnos[0] = new Registro(1, "Presidente", "Sucre", 35, 46, 15,5);
            listaalumnos[1] = new Registro(21, "Diputado", "La Paz", 33, 11, 20,6);
            listaalumnos[2] = new Registro(323, "Diputado", "Sucre", 36, 60, 18,7);
            listaalumnos[3] = new Registro(44, "Presidente", "Sucre", 40, 20, 20,8);          
        }
        private void 
    }
}
