﻿using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pojedynczo wartości punktu początkowego (x1, y1):");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj pojedynczo wartości punktu końcowego (x2, y2):");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            double dlugoscOdcinka = ObliczDlugoscOdcinka(x1, y1, x2, y2);
            Console.WriteLine($"Długość Twojego odcinka wynosi: {dlugoscOdcinka:F2}");
        }

        static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;

            return Math.Sqrt(dx * dx + dy * dy);
        }
    }