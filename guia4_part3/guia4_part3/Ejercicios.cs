using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4_part3
{
    internal class Ejercicios
    {
        public void pares()
        {
            double par;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 0 && i != 50 && i != 0)
                {
                    Console.Write(i + "-");
                }
                else if (i == 50)
                {
                    Console.Write(i);
                }

            }
            Console.ReadKey();
        }
        public void sumaNumeros()
        {
            int suma = 0;
            for (int i = 0; i < 100; i++)
            {
                suma += i;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("El total es: " + suma);
            Console.ReadKey();
        }
        public void tabla()
        {
            int producto, num;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Inserte 0 para salir...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese el multiplicador: ");
                num = int.Parse(Console.ReadLine());

                for (int i = 1; i < 11; i++)
                {
                    producto = num * i;
                    Console.WriteLine($"{num}*{i}={producto}");
                }
            } while (num != 0);



        }
        public void factorial()
        {
            long factorial;
            int num;
            do
            {
                factorial = 1;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Inserte 0 para salir...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese el numero factorial: ");
                num = int.Parse(Console.ReadLine());

                for (int i = 1; i < (num + 1); i++)
                {
                    factorial *= i;


                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"El factorial de {num} es {factorial}");

            } while (num != 0);

        }
        public void contarVocales()
        {
            string palabra = "";
            int cont;
            do
            {
                cont = 0;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Ingrese 0 para salir...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese palabra: ");
                palabra = Console.ReadLine();
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (palabra[i] == 'a' || palabra[i] == 'e' || palabra[i] == 'i' || palabra[i] == 'o' || palabra[i] == 'u')
                    {
                        cont++;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"En total hay {cont} vocales");
            } while (palabra != "0");
        }
        public void numerosPrimos()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            double num = 0;
            int cont = 0;

            for (int i = 2; i < 100; i++)
            {
                bool esprimo = true;
                for (int e = 2; e < i; e++)
                {
                    if (i % e == 0)
                    {

                        esprimo = false; break;
                    }


                }
                if (esprimo)
                {
                    if (i >= 97) { Console.Write(i); } else if (i < 100) { Console.Write(i + "-"); }

                }

            }
            Console.ReadLine();
        }
        public void fibonacci()
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.ReadLine();
        }
        public void bisiesto()
        {
            double bisiesto = 0;
            bool esBisiesto = true;
            for (int i = 1999; i <= 2024; i++)
            {
                esBisiesto = DateTime.IsLeapYear(i);
                if (esBisiesto)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{i} : Es Bisiesto.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i} : No es Bisiesto");
                }
            }
            Console.ReadLine();
        }
        public void cadenaInvertida()
        {
            string cadena, cadenainv;
            do
            {
                int cont = 0;
                cadenainv = "";
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Ingresar 0 para salir...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingresar cadena: ");
                cadena = Console.ReadLine();
                cont = cadena.Length;
                for (int i = 0; i < cadena.Length; i++)
                {
                    cont--;
                    cadenainv += cadena[cont];
                }
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(cadenainv);

            } while (cadena != "0");

        }
        public void calcularPotencia()
        {
            int num, potencia, total;
            do
            {
                total = 0;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Ingresa 0 para salir...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Indica el numero a potenciar: ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                num = int.Parse(Console.ReadLine());
                Console.Write("Indica su potencia: ");
                potencia = int.Parse(Console.ReadLine());
                total = num;
                for (int i = 1; i < potencia; i++)
                {
                    total *= num;
                }
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Total: " + total);

            } while (num != 0);

        }
        public void contarDigitos()
        {
            double num;
            int cont = 0;
            double divisor = 0;
            do
            {
                cont = 0;
                divisor = 0;
           Console.ForegroundColor =ConsoleColor.DarkGray;
                Console.WriteLine("Ingrese 0 para salir...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese numero: ");
            num=double.Parse(Console.ReadLine());
            divisor = num / 10;
            cont++;
                          

                    while (divisor >= 1)
                    {
                        divisor /= 10;
                        cont++;
                    }
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"El numero {num} tiene {cont} digitos");
                

            } while (num!=0);
        }
        public void sumaDigitos()
        {
            double num;
            int cont = 0;
            double divisor = 0;
            double suma;
            do
            {
                suma = 0;
                cont = 0;
                divisor = 0;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Ingrese 0 para salir...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese numero: ");
                num = double.Parse(Console.ReadLine());
                double numeroOriginal = num;
                divisor = num / 10;
                cont++;


                while (divisor >= 1)
                {
                    divisor /= 10;
                    cont++;
                }
                
                for (int i = 0; i < cont; i++)
                {
                    suma +=  numeroOriginal%10;                   
                    numeroOriginal /=10;                    
                }
                Console.WriteLine($"La suma es {Math.Floor(suma)}");
            } while (num != 0);
        }
        public void convertir()
        {
                                  double convertir;            
            double num;
            string op;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Ingrese 0 para salir...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese el numero: ");
                num=double.Parse(Console.ReadLine());
                Console.WriteLine("Indica la opcion a convertir:");
                Console.WriteLine("1.De Celcius a Fahrenheit");
                Console.WriteLine("2.De Fahrenheit a Celcius");
                op=Console.ReadLine();
                switch (op)
                {
                    case "1":
                                               Console.ForegroundColor = ConsoleColor.White;
                        
                        convertir = 1.8 * num + 32;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Total seria: {num}° = {convertir}F");
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                        case "2":
                        
                        Console.ForegroundColor = ConsoleColor.White;
                       
                        convertir = (num-32)*0.5;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Total seria: {num}F = {convertir}°");
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                        default:
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Ocion ivalida...");
                        break;
                }
               
               
                
                

            } while (num != 0);
        }
        public void diaSemana()
        {
            List<string> diasSemanas = new List<string> {"Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","Domingo"};
            int num;
            string dia="";

            do
            {

                num=0;
                dia = "";
                for (int i = 0; i < 7; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ingrese el numero: ");
                    num = int.Parse(Console.ReadLine());
                    if (num == 0) { break; }
                    switch (num)
                    {
                        case 1: dia = diasSemanas[0]; break;
                        case 2: dia = diasSemanas[1]; break;
                        case 3: dia = diasSemanas[2]; break;
                        case 4: dia = diasSemanas[3]; break;
                        case 5: dia = diasSemanas[4]; break;
                        case 6: dia = diasSemanas[5]; break;
                        case 7: dia = diasSemanas[6]; break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR!");break;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"El dia es: {dia} ");
                }
            } while (num!=0);
           

            




        }
        public void contarCadena()
        {
            string cadena;
            int cont;
            do
            {
                cont = 0;
                Console.ForegroundColor= ConsoleColor.DarkGray;
                Console.WriteLine("Ingrese 0 para salir...");
                Console.ForegroundColor=ConsoleColor.White;
                Console.Write("Ingrese cadena: ");
                cadena = Console.ReadLine();
                for (int i = 0; i < cadena.Length; i++)
                {
                if ( cadena[i] !=' ')
                    {
                        cont++;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Hay {cont} caracteres ");

            } while (cadena!="0");
        }
    }
}