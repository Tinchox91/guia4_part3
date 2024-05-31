using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4_part3
{
    internal class Inicio
    {
        static void Main(string[] args)
        {
            Ejercicios ej = new Ejercicios();
            int op = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Indica opcion:");
                Console.WriteLine("1. Numeros Pares del 1 al 50");
                Console.WriteLine("2. Suma de los numeros del 1 al 10");
                Console.WriteLine("3. Tabla de Multiplicar de un numero");
                Console.WriteLine("4. Factorial de un numero");
                Console.WriteLine("5. Contar vocales de una cadena");
                Console.WriteLine("6. Numeros primos del 1 al 100");
                Console.WriteLine("7. Numeros Fibonacci");
                Console.WriteLine("8. Determinar si un uño es Bisiesto");
                Console.WriteLine("9. Invertir cadena");
                Console.WriteLine("10. Calcular potencia de un numero");
                Console.WriteLine("11. Contar digitos de un numero");
                Console.WriteLine("12. Suma de digitos de un numero");
                Console.WriteLine("13. Convertir Temperaturas");
                Console.WriteLine("14. Determinar el dia de la semana");
                Console.WriteLine("15. Contar palabras de una cadena");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: ej.pares(); break;
                    case 2: ej.sumaNumeros(); break;
                    case 3: ej.tabla(); break;
                    case 4: ej.factorial(); break;
                    case 5: ej.contarVocales(); break;
                    case 6: ej.numerosPrimos(); break;
                    case 7: ej.fibonacci(); break;
                    case 8: ej.bisiesto(); break;
                    case 9: ej.cadenaInvertida(); break;
                    case 10: ej.calcularPotencia(); break;
                    case 11: ej.contarDigitos(); break;
                    case 12: ej.sumaDigitos(); break;
                    case 13: ej.convertir(); break;
                    case 14: ej.diaSemana(); break;
                    case 15: ej.contarCadena(); break;
                }
                Console.Clear();


            } while (op != 0);
        }
    }
}
