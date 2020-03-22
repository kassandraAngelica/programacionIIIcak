using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class coladoble2
    {       
        static void Main(string[] args)
        {
            Bicola p = new Bicola();
            int opcion = 0;

            while (opcion != 6)
            {
                Console.Clear();
                Console.WriteLine(" opciones: ");
                Console.WriteLine(" 1.Agregar por el frente  \n " +
                                  "2.agregar por el final   \n" +
                                  " 3.eliminar por el frente \n " +
                                  "4.eliminar por el final  \n " +
                                  "5.imprimir elementos \n 6.salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        p.agregarAdelante();
                        break;
                    case 2:
                        p.agregarAtras();
                        break;
                    case 3:
                        p.eliminarAdelante();
                        Console.ReadKey();
                        break;
                    case 4:
                        p.eliminarFinal();
                        Console.ReadKey();
                        break;
                    case 5:
                        p.imprimir();
                        Console.ReadKey();
                        break;

                }
            }
                               
        }
    }

}
