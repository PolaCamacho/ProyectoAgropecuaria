
using System;

namespace GestionCAgropecuaria
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //PrecargaMaquinaria();
            //PrecargaAgricultores();


            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n");
            Console.WriteLine("GESTION DE AGRICULTORES Y MAQUINARIA\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n");

            Console.WriteLine("1 - Listado de funconarios y sus maquinas");
            Console.WriteLine("2 - Ingresar nuevo funcionario");
            Console.WriteLine("3 - Elminar funcionario");
            Console.WriteLine("4 - Eliminar Maquina");


            bool salir = true;

            int imput = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            while (!salir)
            {
                Console.Write("\nSeleccione una opción: ");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (input)
                {
                    case 1:
                        ///
                        break;
                    case 2:
                        //igresar funcionario;
                        break;
                    case 3:
                        //eliminarFuncioaio;
                        break;
                    case 4:
                        //eliminarMaquina;
                        break;
                    case 5:

                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

    }
}





