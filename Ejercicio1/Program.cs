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
            const int añobisi = 1948;
            const int cadacuanto = 4;

            //Fase 1
            string nom = "Gabriela";
            String cognom1 = "Duque";
            String cognom2 = "Arias";
            int dia = 07;
            int mes = 08;
            int any = 1999;
            String lol = "La fecha de hoy es " + dia + "/" + mes + "/" + any;
            System.Console.WriteLine(lol);
            String str = "Tu nombre completo es: " + nom + " " + cognom1 + " " + cognom2;
            System.Console.WriteLine(str);

            //Fase 2

            int añonaci = 1999;
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
            Console.WriteLine("Mi nombre completo es: " + nom + " " + cognom1 + " " + cognom2);
            Console.WriteLine("Mi fecha de nacimiento es"  +dia + "/" + mes + "/" + any);



            if (añonaci % 4 == 0)
            {
                Console.WriteLine("Es bisiesto {0}\n", añonaci);

            }
            else
            {
                Console.WriteLine("no es bisiesto {0} \n", añonaci);
            }


            Console.ReadKey();

            Console.ReadKey();


        }
    }
}
