using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fase 1
            string nom = "Gabriela";
            String cognom1 = "Duque";
            String cognom2 = "Arias";
            Console.WriteLine("Ingresa la fecha");
            String input = Console.ReadLine();
            String input2 = Console.ReadLine();
            String input3 = Console.ReadLine();
            int dia = 30;
            int mes = 01;
            int any = 2020;
            Int32.TryParse(input, out dia);
            Int32.TryParse(input2, out mes);
            Int32.TryParse(input3, out any);
            String lol = "La fecha de hoy es " + input + "/" + input2 + "/" + input3;
            System.Console.WriteLine(lol);
            Console.WriteLine("Ingresa tu nombre");
            nom = Console.ReadLine();
            Console.WriteLine("Ingresa tus apellidos");
            cognom1 = Console.ReadLine();
            cognom2 = Console.ReadLine();
            String str = "Tu nombre completo es: " + nom + " " + cognom1 + " " + cognom2;
            System.Console.WriteLine(str);

            //Fase 2
            Console.WriteLine("Ingresa tu año de nacimiento");
            int añonaci = int.Parse(Console.ReadLine());
            int cadacuanto = 4;
            var diasanio = 365;
            int añobisi = 1948;
            int resta = añonaci - añobisi;
            int divi = resta / cadacuanto;
            Console.WriteLine(" Hay " + divi + " Años desde 1948 hasta 1999");
            Console.ReadKey();


            //Fase 3 : Años bisiestos desde 1948 hasta tu año de nacimiento

            var años = new[] { 1948, 1952, 1956, 1960, 1964, 1968, 1972, 1976, 1980, 1984, 1988, 1992, 1996, };


            Console.WriteLine("Años bisiesto desde 1948 hasta tu año de nacimiento");

            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(años[i]);

            }

           



            Console.ReadKey();

            // Fase 4
            Console.WriteLine("Tus datos");
            Console.WriteLine("Tu nombre completo es: " + nom + " " + cognom1 + " " + cognom2);
            Console.WriteLine("Tu año de nacimiento es" + añonaci );

            if (añonaci == 1999)
            {
                Console.WriteLine("Tu año de nacimiento no es bisiesto");
            }
     
            Console.ReadKey();


        }
    }
}
