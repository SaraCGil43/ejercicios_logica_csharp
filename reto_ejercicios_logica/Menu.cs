namespace csharp{

    public static class Menu{
        public static string MostrarMenu(){
            Console.WriteLine(@"1. Positividad al Cuadrado
2. ¡Doble o Triple!.
3. Raíz Cuadrada.
4. Perimetro del Circulo.
5. ¡Adivinando el dia!.
6. Calculador de impuestos.
7. Residuo de la división.
8. Suma de pares.
9.  Diferencia de fracciones.
10. ¡Mide tus palabras!
11. Cuatro numeros, un promedio.
12. El número mas pequeño.
13. Cuenta las vocales
14. Hallemos el Factorial
15. ¿Estas en el rango?");
    string op = Console.ReadLine();
    return op;
        }
    }
}
