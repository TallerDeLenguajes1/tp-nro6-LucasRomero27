using System;
using System.Text.RegularExpressions;

namespace TP6_Pto5
{
    class Program
    {
        static void Main(string[] args)
        {
            string email, pagina;
            Console.Write("Ingrese su email:");
            email = Console.ReadLine();
            Console.Write("Ingrese su página web:");
            pagina = Console.ReadLine();
            IsValidEmail(email);
            IsValidPage(pagina);
        }

        public static void IsValidEmail(string email)
        {
            string ctrlemail = @"(@)(.+)$";

            if (Regex.IsMatch(ctrlemail, email))
            {
                Console.WriteLine("El email ingresado: " + email + " es un email válido ");
            }
            else
            {
                Console.WriteLine("El email ingresado: " + email + " es un email inválido ");
            }

        }

        public static void IsValidPage(string pagina)
        {
            string ctrlpagina = @"^www\.\w+\.com";

            if (Regex.IsMatch(ctrlpagina, pagina))
            {
                Console.WriteLine("La página ingresada: '{0}' es válida ", pagina);
            }
            else
            {
                Console.WriteLine("La página ingresada: '{0}' es inválida ", pagina);
            }

        }
    }
}