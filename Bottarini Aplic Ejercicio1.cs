﻿using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, prom, max = 0, promcur,tcur,min=11;
            int i, ca;
            Console.WriteLine("Ingrese la cantidad de alumnos");
            ca = int.Parse(Console.ReadLine());
            string na, nma = ".",npa=".";
            for (i = 0; i < ca; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno ");
                na = Console.ReadLine();
                Console.WriteLine("Ingrese la primer nota");
                n1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la segunda nota");
                n2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la tercer nota");
                n3 = Double.Parse(Console.ReadLine());
                prom = (n1 + n2 + n3) / 3;
                tcur += prom;
                Console.WriteLine("El promedio es {0}", prom);
                Console.ReadKey();
                if (prom >= 7)
                {
                    Console.WriteLine("El alumno ha aprobado");
                }
                else
                {
                    Console.WriteLine("El alumno ha desaprobado");
                }
                if (prom > max)
                {
                    max = prom;
                    nma = na;
                }
                if (prom < min)
                {
                    min = prom;
                    npa = na;
                }
            }
            promcur = tcur / ca;
            Console.WriteLine("El promedio mas alto es {0}, del alumno {1}, el promedio del curso es de {2}", max, nma,promcur);
            Console.WriteLine("El promedio del curso es {0}", promcur);
        }
    }
}
