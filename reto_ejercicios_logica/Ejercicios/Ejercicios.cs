
namespace csharp {
    public class PositivePower {
        public void Run() {
                Console.WriteLine("¡Ingresa un número!");
                int numero = int.Parse(Console.ReadLine());
                if(numero > 0) {
                    int resultado = numero * numero;
                    Console.WriteLine($"Resultado = {resultado}");
                }else if (numero == 0) {
                    Console.WriteLine("Resultado = 0");
                }else {
                    Console.WriteLine("¡Número negativo!");
                }
        }
    }
        public class DoubleOrTriple {
        public void Run() {
          
                Console.WriteLine("Por favor ingresa el primer número");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ahora, ingrese el segundo número");
                int n2 = int.Parse(Console.ReadLine());

                int resultado_multiplicacion;

                if(n1 > n2) {
                    resultado_multiplicacion = n1*2;
                }else {
                    resultado_multiplicacion = n2*3;
                }
                Console.WriteLine($"El resultado de tu número es = {resultado_multiplicacion}");
        }
    }
        public class RootSquare {
        public void Run() {
    
            Console.WriteLine("Ingresa un número");
            double numero = double.Parse(Console.ReadLine());
            double resultado;

             if (numero >= 0) {
                 resultado = Math.Sqrt(numero); // Es positivo, raíz cuadrada
            }else {
                resultado = Math.Pow(numero, 2); // Es negativo, devuelvo cuadrado
            }
             Console.WriteLine($"El resultado es = {resultado}");   
        }
    }
 }

        public class CirclePerimeter {
        public void Run() {
                Console.WriteLine("Ingresa el radio del círculo");
                double radio = double.Parse(Console.ReadLine());

                if (radio <= 0) {
                    Console.WriteLine("¡El radio tiene que ser un número positivo!");
                    return;
                }

                double perimetro = 2 * Math.PI * radio;

                Console.WriteLine($"El resultado del perimetro es: {perimetro}");
        }
    }

     public class MidweekDay  {
        public void Run() {
                Console.WriteLine("Ingresa un número entre 1 y 7 para calcular el dia");
                int numero = int.Parse(Console.ReadLine());

                string dia;

                switch (numero) {
                    case 1:
                        dia = "Lunes";
                        break;
                    case 2:
                        dia = "Martes";
                        break;
                    case 3:
                        dia = "Miércoles";
                        break;
                    case 4:
                        dia = "Jueves";
                        break;
                    case 5:
                        dia = "Viernes";
                        break;
                    default:
                        dia = "Número fuera del rango laboral.";
                        break;
                }
                Console.WriteLine(dia);
    }
 }
        public class TaxCalculator {
        public void Run() {
                Console.WriteLine("Ingresa tu salario anual");
                double salarioAnual = double.Parse(Console.ReadLine());

                if (salarioAnual <= 12000) {
                    Console.WriteLine("¡No debes impuestos!");
                }else {
                    double excedente = salarioAnual - 12000;
                    double impuesto = excedente * 0.15;
                    Console.WriteLine($"Debes los siguientes impuestos: {impuesto}");
                }
        }
        }
        public class RemainderFinder {
        public void Run() {

                Console.WriteLine("Ingresa el primer número:");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el segundo número:");
                int n2 = int.Parse(Console.ReadLine());
                int residuo = n1%n2;
                Console.WriteLine($"El residuo es: {residuo}");
        }
        }
        public class SumOfEvenS {
            public void Run() {
                int suma = 0;
                for (int i = 2; i <= 50; i += 2) {
                    suma += i;
                }
                Console.WriteLine($"La suma es: {suma}");
            }
 
        }
        public class StringLength{
            public void Run() {
                    Console.WriteLine("Ingrese una palabra:");
                    string palabra = Console.ReadLine();
                    
                    int length = palabra.Length;
                    Console.WriteLine($"La longitud de la palabra '{palabra}' es: {length}");
            }
        }

        public class AverageOfFour {
            public void Run() {
                Console.WriteLine("Ingresa cuatro números separados por comas: ej: 2, 4, 6, 8");
                string[] inputs = Console.ReadLine().Split(',');

                if (inputs.Length != 4) {
                    Console.WriteLine("¡ERROR! no ingresaste 4 numeros");
                    Run();
                }

                //Debemos validar si si son numeros validos, si la conversión falla para cualquier elemento mostrará el mensaje de error.
                if (!double.TryParse(inputs[0], out double n1) || !double.TryParse(inputs[1], out double n2) ||
                    !double.TryParse(inputs[2], out double n3) || !double.TryParse(inputs[3], out double n4)) {
                    Console.WriteLine("¡ERROR! Los numeros no son validos.");
                    return;
                }

                double prom = (n1 + n2 + n3 + n4)/4;
                Console.WriteLine($"El promedio de los números es: {prom}");
            }
        }

        public class SmallestOfFive {
            public void Run() {
                Console.WriteLine("Ingresa cinco números separados por comas, ejemplo: 1, 2, 3, 4, 5 = ");

                string[] fiveNumbers = Console.ReadLine().Split(',');

                if (fiveNumbers.Length != 5) {
                    Console.WriteLine("¡ERROR! no ingresaste 5 numeros");
                    return;
                }

                if (!double.TryParse(fiveNumbers[0], out double num1) || !double.TryParse(fiveNumbers[1], out double num2) ||
                    !double.TryParse(fiveNumbers[2], out double num3) || !double.TryParse(fiveNumbers[3], out double num4) ||
                    !double.TryParse(fiveNumbers[4], out double num5)) {
                    Console.WriteLine("¡ERROR! Los numeros no son validos.");
                    return;
                }
                double numeroPequeño = Math.Min(Math.Min(Math.Min(Math.Min(num1, num2), num3), num4), num5);
                Console.WriteLine($"El número más pequeño de la lista es: {numeroPequeño}");
        }
    }
    public class VowelCounter {
        public void Run() {
            Console.WriteLine("Por favor ingresa una palabra:");
            string palabra = Console.ReadLine();

            int vocalesContadasTotal = 0;
            foreach (char c in palabra.ToLower()) {
                if ("aeiou".Contains(c)) {
                    vocalesContadasTotal++;
                }
            }
            Console.WriteLine($"El número de vocales en la palabra '{palabra}' es: {vocalesContadasTotal}");
        }
    }
    public class FactorialFinder {
        public void Run() {
            Console.WriteLine("Ingresa un número para calcular tu factorial");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num) || num < 0) {
                Console.WriteLine("¡ERROR! El numero no es entero o es negativo");
                Run();
            }
            int factorial = 1;
            for (int i = 2; i <= num; i++) {
                factorial *= i;
            }
            Console.WriteLine($"El factorial de {num} es: {factorial}");
        }
    }

    public class InRangeValidator {
        public void Run() {
            Console.WriteLine("Ingresa un número para verificar si está en el rango de 10 a 20:");
            string num = Console.ReadLine();

            if (!int.TryParse(num, out int number)) {
                Console.WriteLine("¡ERROR! Debes ingresar un número entero o formato numero.");
                return;
            }

            if (number >= 10 && number <= 20) {
                Console.WriteLine("¡Tu numero esta en el rango!");
            } else {
                Console.WriteLine("¡Tu numero esta fuera del rango!");
            }
        }
    }
    public class FractionDifference {
        public void Run() {
            Console.WriteLine("Ingresa las dos fracciones en el formato 'a/b, c/d' ejemplo: : 1/2, 1/3");
            string fraccion = Console.ReadLine();
            string[] fraccionArray = fraccion.Split(',');

            //Validar el formato de la fracción si es correcto.
            if (fraccionArray.Length != 2) {
                Console.WriteLine("¡ERROR! Formato invalido de fracción, no es posible calcular");
                return;
            }

            //Separar las fracciones en dos Arrays con un split
            string[] fraccion1 = fraccionArray[0].Trim().Split('/');
            string[] fraccion2 = fraccionArray[1].Trim().Split('/');

            if (!int.TryParse(fraccion1[0], out int num1) || !int.TryParse(fraccion1[1], out int denom1) ||
                !int.TryParse(fraccion2[0], out int num2) || !int.TryParse(fraccion2[1], out int denom2) ||
                denom1 == 0 || denom2 == 0) {
                Console.WriteLine("¡ERROR! Las fracciones deben tener numerador y denominador válidos");
                return;
            }

            //Calcular la diferencia entre las fracciones
            int resultadoNumerador = num1 * denom2 - num2 * denom1;
            int comunDenominador = denom1 * denom2;

            //Simplificar la fracción resultante
            int gcd = ObtenerGCD(resultadoNumerador, comunDenominador);
            resultadoNumerador /= gcd;
            comunDenominador /= gcd;

            if (resultadoNumerador == 0 && comunDenominador == 1) {
                Console.WriteLine("El resultado es: 0");
            } else {
                Console.WriteLine($"El resultado es: {resultadoNumerador}/{comunDenominador}");
            }
            
        }
        //Metodo para calcular el máximo común divisorusando el algoritmo de Euclides
        private int ObtenerGCD(int a, int b) {
            while (b != 0) {
                int temp = b;
                b =a%b;
                a =temp;
            }
            return a;
        }
    }

    


        




    



