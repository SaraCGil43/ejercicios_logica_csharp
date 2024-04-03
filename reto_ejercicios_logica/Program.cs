using System;

namespace csharp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("BIENVENIDO A LOS 15 EJERCICIOS DE LOGICA EN C#");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Dime, ¿Cuál es tu nombre?");
            string nombre = Console.ReadLine();

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Bienvenido {nombre} ¡A continuación elije el ejercicio que deseas navegar!");
            Console.WriteLine("--------------------------------------------");

            while (true) {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Bienvenido {nombre} ¡A continuación elije el ejercicio que deseas navegar!");
                Console.WriteLine("--------------------------------------------");

                string opStr = Menu.MostrarMenu();
                int op;

                if (opStr.ToLower() == "exit") {
                    break; // Salir del bucle si el usuario escribe 'exit'
                }

                if (int.TryParse(opStr, out op) && op >= 1 && op <= 15) {

                    switch (op) {
                        case 1:
                            Console.WriteLine("Seleccionó la opción 1");
                            break;
                        case 2:
                            Console.WriteLine("Seleccionó la opción 2");
                            break;
                        case 3:
                            Console.WriteLine("Seleccionó la opción 3");
                            break;
                        case 4:
                            Console.WriteLine("Seleccionó la opción 4");
                            break;
                        case 5:
                            Console.WriteLine("Seleccionó la opción 5");
                            break;
                        case 6:
                            Console.WriteLine("Seleccionó la opción 6");
                            break;
                        case 7:
                            Console.WriteLine("Seleccionó la opción 7");
                            break;
                        case 8:
                            Console.WriteLine("Seleccionó la opción 8");
                            break;
                        case 9:
                            Console.WriteLine("Seleccionó la opción 9");
                            break;
                        case 10:
                            Console.WriteLine("Seleccionó la opción 10");
                            break;
                        case 11:
                            Console.WriteLine("Seleccionó la opción 11");
                            break;
                        case 12:
                            Console.WriteLine("Seleccionó la opción 12");
                            break;
                        case 13:
                            Console.WriteLine("Seleccionó la opción 13");
                            break;
                        case 14:
                            Console.WriteLine("Seleccionó la opción 14");
                            break;
                        case 15:
                            Console.WriteLine("Seleccionó la opción 15");
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                } else {
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número del 1 al 15 o escriba 'exit' para salir.");
                }

            }
    }
}
}