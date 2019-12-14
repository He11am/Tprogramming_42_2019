using System;

namespace CourseApp
{
    public class Program
    {
        public static double Equat(double a, double b, double x)
        {
            return Math.Log10(Math.Pow(x, 2) - 1) / Math.Log(a * Math.Pow(x, 2)) / Math.Log(5);
        }

        public static double[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            if (xk < xn)
            {
                return new double[0];
            }
            else
            { 
                int size = (int)Math.Floor((xk - xn) / dx);
                double[] rtrn = new double[size + 1];
                size = 0;
                for (double x = xn; x < (xk + 0.1); x += dx)
                    {
                        rtrn[size] = Equat(a, b, x);
                        size++;
                    }

            return rtrn;
            }
        }

        public static double[] TaskB(double a, double b, double[] xm)
        {
            double[] rtrn = new double[xm.Length];
            for (int i = 0; i < xm.Length; i++)
            {
                rtrn[i] = Equat(a, b, xm[i]);
            }

            return rtrn;
        }

        public static void Main(string[] args)
        {
            double a = 1.1;
            double b = 0.09;
            double[] mass = TaskA(a, b, 1.2, 2.2, 0.2);
            foreach (var item in mass)
            {
                Console.WriteLine(item);
            }

            double[] mass2 = new double[5] { 1.21, 1.76, 2.53, 3.48, 4.52 };
            mass2 = TaskB(a, b, mass2);
            foreach (var item in mass2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
=======
﻿using System;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double b, double x)
        {
            var y = (a * Math.Pow(x, 2)) + (b * x);
            return y;
        }

        public static double[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            return new double[0];
        }

        public static double[] TaskB(double a, double b, double[] x)
        {
            var y = new double[x.Length];
            for (var i = 0; i < x.Length; i++)
            {
                y[i] = MyFunction(a, b, x[i]);
            }

            return y;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const double a = 2.2;
            const double b = 3.8;
            var resSingle = MyFunction(a, b, 4);
            Console.WriteLine(resSingle);
            var x = new double[] { 1, 2, 3, 4, 5 };
            var taskBRes = TaskB(a, b, x);
            foreach (var item in taskBRes)
            {
                Console.WriteLine($"y = {item}");
            }

            Console.ReadLine();
        }
    }
}

