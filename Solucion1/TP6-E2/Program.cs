using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_Pto2y3
{
    class Program
    {
        static void Main(string[] args)
        {
            char operacion;
            float a, b;
            float suma, resta, prod, division;
            Console.Write("Elija una operación aritmética a realizar (+) (-) (*) (/):");
            operacion = Convert.ToChar (Console.ReadLine());
            Console.Write("Escriba el primer numero: ");
            a = float.Parse((Console.ReadLine()));
            Console.Write("Escriba el segundo numero: ");
            b = float.Parse((Console.ReadLine()));
            switch (operacion) {
                case '+':
                    suma =a+b;
                    Console.Write("Su suma es: ");
                    Console.Write(suma);
                    break;
                case '-':
                    resta = a - b;
                    Console.Write("Su resta es: ");
                    Console.Write(resta);
                    break;
                case '*':
                    prod = a * b;
                    Console.Write("Su producto es: ");
                    Console.Write(prod);
                    break;
                case '/':
                    division = a / b;
                    Console.Write("Su division es: ");
                    Console.Write(division);
                    break;
            }

            double numero;
            Console.Write("\nElija un numero del cual quiere obtener datos: ");
            numero = double.Parse((Console.ReadLine()));
            if(numero >= 0)
            {
                Console.Write("\nEl valor absoluto de su numero es: ");
                Console.Write(numero);
            }
            else
            {
                Console.Write("\nEl valor absoluto de su numero es: ");
                Console.Write(numero*-1);
            }
            Console.Write("\nCuadrado del numero: ");
            Console.Write(numero * numero);
            if (numero>=0){
                Console.Write("\nRaiz cuadrada del numero: ");
                Console.Write(Math.Sqrt(numero));
            }
            else{
                Console.Write("\nEl numero es negativo, no se puede calcular raiz cuadrada.");
            }
            Console.Write("\nEl seno del numero: ");
            Console.Write(Math.Sin(numero));

            Console.Write("\nEl coseno del numero: ");
            Console.Write(Math.Cos(numero));

            Console.Write("\nLa parte entera del numero decimal es: ");
            Console.Write(Math.Truncate(numero));

            float num, num2;

            Console.Write("\nIngrese el primer número a comparar:");
            num=float.Parse(Console.ReadLine());
            Console.Write("\nIngrese el segundo número a comparar:");
            num2= float.Parse(Console.ReadLine());
            Console.Write("\nEl siguiente número es el mayor entre ambos:");
            Console.Write(Math.Max(num,num2));
            Console.Write("\nEl siguiente número es el menor entre ambos:");
            Console.Write(Math.Min(num, num2));


        }
    }
}
