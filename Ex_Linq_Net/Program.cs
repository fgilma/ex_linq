using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Ex_Linq_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fase 1:
            // numeros pares:
            int[] series = new int[] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            var consulta1 = from num in series
                           where (num % 2) == 0
                           select num;
            Console.WriteLine("Los numeros pares son:");
            foreach (int num in consulta1)
            {
                Console.Write(num + " ");
            }

            // con lambdas
            
            var consulta1L = series.Where(x => x % 2 == 0);
            Console.WriteLine("\nLambdas: Los numeros pares son:");
            foreach (int num in consulta1L)
            {
                Console.Write(num + " ");
            }

            // Fase 2:
            // Nota media, minima y maxima
            var minArray = series.Min();
            var maxArray = series.Max();
            var avgArray = series.Average();
            Console.WriteLine("\n\nEl valor mínimo es: " + minArray);
            Console.WriteLine("El valor máximo es: " + maxArray);
            Console.WriteLine("El valor medio es: " + avgArray);

            // Fase 3:
            // Dos arrays en una sola query con valores > 5 y valores < 5

            var consulta3 = from num in series
                            where num < 5
                            select num;

            var consulta4 = from num in series
                            where num > 5
                            select num;
            
           
            Console.WriteLine("\nLos numeros menores que 5 son:");
            
                foreach (var a in consulta3)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine("\nLos numeros mayores que 5 son:");

            foreach (var a in consulta4)
            {
                Console.Write(a+ " ");
            }

            //con lambdas
            var consulta4L = series.Where(x => x > 5);

            Console.WriteLine("\nLamdbas: Los numeros mayores que 5 son:");

            foreach (var a in consulta4L)
            {
                Console.Write(a + " ");
            }

            // Fase 4:
            string[] serieNombres = new string[] { "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };
            
            //nombres que empiezan por O
            var consulta5 = from a in serieNombres
                            where a[0] == 'O'
                            select a;
                       
            Console.WriteLine("\n\nLos nombres que empiezan por O son:");
            foreach (var i in consulta5)
            {
                Console.WriteLine(i);
            }

            //con lambdas

            var consulta5L = serieNombres.Where(x => x[0] == 'O');
            Console.WriteLine("\n\n Lambdas:Los nombres que empiezan por O son:");
            foreach (var i in consulta5L)
            {
                Console.WriteLine(i);
            }

            //nombres con mas de 6 letras
            var consulta6 = from a in serieNombres
                            where a.Length >= 6
                            select a;

            Console.WriteLine("\nLos nombres que tienen mas de 6 letras son:");
            foreach (var i in consulta6)
            {
                Console.WriteLine(i);
            }

            //con lambdas
            var consulta6L = serieNombres.Where(x => x.Length >= 6);

            Console.WriteLine("\nLambdas: Los nombres que tienen mas de 6 letras son:");
            foreach (var i in consulta6L)
            {
                Console.WriteLine(i);
            }

            //nombres ordenados de forma descendente
            var consulta7 = from a in serieNombres
                            orderby a descending
                            select a;

            Console.WriteLine("\nLos nombres ordenados de forma descendiente son:");
            foreach (var i in consulta7)
            {
                Console.Write(i + " ");
            }
            //con lambdas
            var consulta7L = serieNombres.OrderByDescending(x=>x);

            Console.WriteLine("\n\nLambdas: Los nombres ordenados de forma descendiente son:");
            foreach (var i in consulta7L)
            {
                Console.Write(i + " ");
            }

        }
    }
}
