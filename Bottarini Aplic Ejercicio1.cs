using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
         double n1, n2, n3, prom,max=0;
         ("Console.WriteLineIngrese la primer nota");
         n1 = Double.Parse(Console.ReadLine());
         Console.WriteLine("Ingrese la segunda nota");
         Console.WriteLine("Ingrese la tercer nota");
         n3 = Double.Parse(Console.ReadLine());
         prom = (n1 + n2 + n3) / 3;
         Console.WriteLine("El promedio es {0}", prom);
         Console.ReadKey();
         if (prom>max)
             max=prom;
         

        }
    }
}
