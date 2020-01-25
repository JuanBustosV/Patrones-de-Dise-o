using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Patrón Estrategia - 2 - Patrones de Diseño de Software";

            string dato = "";

            double x = 0;
            double y = 0;
            double r = 0;

            string opcion = "";
            string[] opciones = { "1", "2", "3", "4" };

            // Nuestra variable que referencia al algoritmo
            // Instanciamos con un default para permitir compilación correcta
            IOperacion miOperacion = new CSuma(); // variable polimórfica para intercambiar de algoritmo

            while (opcion != "5")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1- Suma, 2-Resta, 3- Producto, 4- División, 5- SALIR");
                Console.ResetColor();
                opcion = Console.ReadLine();
                
                if (opcion == "5")
                    break;

                // opción válida si está entre la 1 y la 4
                if (opciones.Where((i) => i == opcion).Any())
                {
                    Console.WriteLine("Dame el valor de a");
                    dato = Console.ReadLine();
                    x = Convert.ToDouble(dato);

                    Console.WriteLine("Dame el valor de b");
                    dato = Console.ReadLine();
                    y = Convert.ToDouble(dato);

                    // Aquí seleccionamos el algoritmo de acuerdo a la necesidad
                    // SELECCIÓN DE UNA DE LAS ESTRATEGIAS
                    switch (opcion)
                    {
                        case "1":
                            miOperacion = new CSuma();
                            break;

                        case "2":
                            miOperacion = new CResta();
                            break;

                        case "3":
                            miOperacion = new CProducto();
                            break;

                        case "4":
                            miOperacion = new CDivision();
                            break;
                    }

                    r = miOperacion.operacion(x, y);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tEl resultado es {0}\n", r);
                    Console.ResetColor();
                }
            }
        }
    }
}
