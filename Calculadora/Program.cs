using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declara Variables y luego inicializa a cero.
            int num1 = 0; int num2 = 0;

            // Muestra el titulo como la aplicación de calculadora de la consola de C#
            Console.WriteLine("Calculadora de Consola en C#\r");
            Console.WriteLine("------------------------\n");

            // Pedir al usuario que digite el primer número.
            Console.WriteLine("Digite un número y luego presione ENTER");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Pedir al usaurio que digite el segundo número.
            Console.WriteLine("Digite otro número y luego presione ENTER");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Pedir al usuario que seleccione una opción
            Console.WriteLine("Elija una opción de la siguiente lista:");
            Console.WriteLine("\ta - Sumar");
            Console.WriteLine("\ts - Restar");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("¿Cuál es tu opción? ");

            // Usa una sentencia de cambio para hacer los cálculos.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"El resultado es: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"El resultado es: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"El resultado es: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"El resultado es: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Espere a que el usuario responda antes de cerrar.
            Console.Write("Presione cualquier tecla para cerrar la aplicación de la Calculadora de Consola");
            Console.ReadKey();
        }
    }
}