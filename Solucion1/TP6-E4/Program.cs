using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_Pto4
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringuno, concat, concat1, nuevacad, buscar, cadmayus, cadminus, cadenacomparar, cadena, ecuacion;
            string[] subcadena;
            concat = @"Para concatenar";
            concat1 = @"Unir dos cadenas";
            nuevacad = concat + concat1;

            Console.WriteLine("\nPor favor, ingrese la cadena de texto:");
            stringuno = Console.ReadLine();

            Console.Write("\nPrimer elemento de la cadena ingresada: " + stringuno[0]);
            Console.Write("\nSegundo elemento de la cadena ingresada: " + stringuno[1]);
            Console.Write("\nTercer elemento de la cadena ingresada: " + stringuno[2]);
            Console.Write("\nCuarto elemento de la cadena ingresada: " + stringuno[3]);

            Console.Write("\nLongitud total de la cadena: " + stringuno.Length);
            Console.Write("\nSubCadena creada a partir de la cadena ingresada: " + stringuno.Substring(3));

            char operacion;
            float a, b;
            float suma, resta, prod, division;
            Console.Write("\nElija una operación aritmética a realizar (+) (-) (*) (/):");
            operacion = Convert.ToChar(Console.ReadLine());
            Console.Write("\nEscriba el primer numero: ");
            a = float.Parse((Console.ReadLine()));
            Console.Write("\nEscriba el segundo numero: ");
            b = float.Parse((Console.ReadLine()));
            switch (operacion)
            {
                case '+':
                    suma = a + b;
                    Console.Write("\nLa suma de " + a + " y de " + b + " es igual a: " + suma);
                    break;
                case '-':
                    resta = a - b;
                    Console.Write("\nLa resta de " + a + " y de " + b + " es igual a: " + resta);
                    break;
                case '*':
                    prod = a * b;
                    Console.Write("\nEl producto de " + a + " y de " + b + " es igual a: " + prod);
                    break;
                case '/':
                    division = a / b;
                    Console.Write("\nLa división de " + a + " y de " + b + " es igual a: " + division);
                    break;
            }

            Console.Write("\nRecorremos la cadena: ");
            foreach (var elem in stringuno)
            {
                Console.Write(elem);
            }

            Console.Write("\nIngrese una palabra para buscar en la cadena: ");
            buscar = Console.ReadLine();

            if (stringuno.Contains(buscar)) {
                Console.Write("\nLa palabra ingresada: " + buscar + " si se encuentra en la cadena.");
            }
            else
            {
                Console.Write("\nLa palabra ingresada: " + buscar + " no se encuentra en la cadena.");
            }

            cadmayus = stringuno.ToUpper();
            cadminus = stringuno.ToLower();

            Console.Write("\nIngrese una nueva cadena para comparar con la anterior: ");
            cadenacomparar = Console.ReadLine();

            if (String.Equals(stringuno, cadenacomparar)) {
                Console.Write("\nLa cadena: " + stringuno + " es igual a la cadena: " + cadenacomparar);
            }
            else
            {
                Console.Write("\nLa cadena: " + stringuno + " no es igual a la cadena: " + cadenacomparar);
            }

            cadena = "Primero, Segundo, Tercero, Cuarto, Quinto";
            Console.Write("\nLa cadena antes del split: " + cadena);
            subcadena = cadena.Split(',');
            Console.Write("\nLa cadena luego del split: ");
            for (int i=0; i < subcadena.Length; i++)
            {
                Console.Write(subcadena[i]);
            }
            string[] aux;
            float numaux, total=0;
            Console.Write("Ingrese los números y la operación que quiere realizar:");
            ecuacion=Console.ReadLine();

            if (ecuacion.Contains('+'))
            {
                aux = ecuacion.Split('+');
                for (int i = 0; i < aux.Length; i++)
                {
                    numaux = float.Parse(aux[i]);
                    total += numaux;
                }
                Console.Write("La suma total de todos los elementos es: " + total);
            }

            if (ecuacion.Contains('-'))
            {
                aux = ecuacion.Split('-');
                total = float.Parse(aux[0]);
                for (int i = 1; i < aux.Length; i++)
                {
                    numaux = float.Parse(aux[i]);
                    total -= numaux;
                }
                Console.Write("La resta total de todos los elementos es: " + total);
            }

            if (ecuacion.Contains('*'))
            {
                aux = ecuacion.Split('*');
                total = 1;
                for (int i = 0; i < aux.Length; i++)
                {
                    numaux = float.Parse(aux[i]);
                    total *= numaux;
                }
                Console.Write("El producto total de todos los elementos es: " + total);
            }

            if (ecuacion.Contains('/'))
            {
                aux = ecuacion.Split('/');
                total = float.Parse(aux[0]);
                for (int i = 1; i< aux.Length;i++) {
                    numaux = float.Parse(aux[i]);
                    total /= numaux;
                }
                Console.Write("La division total de todos los elementos es: " + total);
            }
        }
    }
}
