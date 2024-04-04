using System;

namespace csharp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("BIENVENIDO A LOS 15 EJERCICIOS DE LOGICA EN C#");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Dime, ¿Cuál es tu nombre?");
            string nombre = Console.ReadLine();

            while (true) {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Bienvenido {nombre} ¡A continuación elije el ejercicio que deseas navegar!");
                Console.WriteLine("--------------------------------------------");

                string opStr = Menu.MostrarMenu();
                int op;
                Console.WriteLine("--------------------------------------------");

                if (opStr.ToLower() == "exit") {
                    break; // Salir del bucle si el usuario escribe 'exit'
                }

                if (int.TryParse(opStr, out op) && op >= 1 && op <= 15) {
                    try {
                        switch (op) {
                            case 1:
                                var positivePower = new PositivePower();
                                positivePower.Run();
                                break;
                            case 2:
                                var doubleOrTriple = new DoubleOrTriple();
                                doubleOrTriple.Run();
                                break;
                            case 3:
                                var rootSquare = new RootSquare();
                                rootSquare.Run();
                                break;
                            case 4:
                                var circlePerimeter = new CirclePerimeter();
                                circlePerimeter.Run();
                                break;
                            case 5:
                                var midweekDay = new MidweekDay();
                                midweekDay.Run();
                                break;
                            case 6:
                                var taxCalculator = new TaxCalculator();
                                taxCalculator.Run();
                                break;
                            case 7:
                                var RemainderFinder = new RemainderFinder();
                                RemainderFinder.Run();
                                break;
                            case 8:
                                var SumOfEvenS = new SumOfEvenS();
                                SumOfEvenS.Run();
                                break;
                            case 9:
                                var FractionDifference = new FractionDifference();
                                FractionDifference.Run();
                                break;
                            case 10:
                                var StringLength  = new StringLength();
                                StringLength.Run();
                                break;
                            case 11:
                                var AverageOfFour  = new AverageOfFour();
                                AverageOfFour.Run();
                                break;
                            case 12:
                                var SmallestOfFive  = new SmallestOfFive();
                                SmallestOfFive.Run();
                                break;
                            case 13:
                                var VowelCounter  = new VowelCounter();
                                VowelCounter.Run();
                                break;
                            case 14:
                                var FactorialFinder  = new FactorialFinder();
                                FactorialFinder.Run();
                                break;
                            case 15:
                                var InRangeValidator  = new InRangeValidator();
                                InRangeValidator.Run();
                                break;
                            default:
                                Console.WriteLine("xxxxxx OPCIÓN INVALIDA xxxxxx Por favor, ingrese un número del 1 al 15 o escriba 'exit' para salir.");
                                break;
                        }
                    } catch (FormatException) {
                        Console.WriteLine("¡ERROR! Has ingresado algo diferente a un número.");
                    } catch (DivideByZeroException) {
                        Console.WriteLine("¡ERROR! No se puede dividir por cero.");
                    } catch (Exception e) {
                        Console.WriteLine($"¡ERROR! {e.Message}");
                    }
                }
            }
        }
    }
}
