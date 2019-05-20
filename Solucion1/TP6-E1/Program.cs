using System;

namespace TP6_Pto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ninv;
            ninv = int.Parse (Console.ReadLine());
            if (ninv > 0)
            {
                int aux = ninv;
                while (aux!=0) {
                    int aux2 = aux % 10;
                    Console.Write(aux2);
                    aux = aux / 10;
                }
            }
            else
            {
                Console.Write("El número a invertir no es mayor que 0.");
            }
        }
    }
}
