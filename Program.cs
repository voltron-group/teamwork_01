using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09LongerLine
{
    class Program
    {
        static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            double pointAdist = GetHypotenose(x1, y1);
            double pointBdist = GetHypotenose(x2, y2);
            if (pointAdist <= pointBdist)
            {
                Console.Write($"({x1}, {y1}) ");
            }
            else
            {
                Console.Write($"({x2}, {y2}) ");
            }
        }
        static void PrintFarPoint(double x1, double y1, double x2, double y2)
        {
            double pointAdist = GetHypotenose(x1, y1);
            double pointBdist = GetHypotenose(x2, y2);
            if (pointAdist > pointBdist)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
        static double GetHypotenose(double x, double y)
        {
            double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return result;
        }

        static double GetLineLenght(double x1, double y1, double x2, double y2)
        {
            double length = GetHypotenose(GetAbsCoordinate(x1, x2), GetAbsCoordinate(y1, y2));
            return length;
        }
        static double GetAbsCoordinate(double crd1, double crd2)
        {
            double absCoordinate = 0;
            if (Math.Sign(crd1) == Math.Sign(crd2))
            {
                if (Math.Abs(crd1) >= Math.Abs(crd2))
                {
                    absCoordinate = Math.Abs(crd1) - Math.Abs(crd2);
                }
                else
                {
                    absCoordinate = Math.Abs(crd2) - Math.Abs(crd1);
                }
            }
            else
            {
                absCoordinate = Math.Abs(crd1) + Math.Abs(crd2);
            }
            return absCoordinate;
        }

        static void Main(string[] args)
        {
            double x1lineA = double.Parse(Console.ReadLine());
            double y1lineA = double.Parse(Console.ReadLine());
            double x2lineA = double.Parse(Console.ReadLine());
            double y2lineA = double.Parse(Console.ReadLine());
            double x1lineB = double.Parse(Console.ReadLine());
            double y1lineB = double.Parse(Console.ReadLine());
            double x2lineB = double.Parse(Console.ReadLine());
            double y2lineB = double.Parse(Console.ReadLine());
            double lengthA = GetLineLenght(x1lineA, y1lineA, x2lineA, y2lineA);
            double lengthB = GetLineLenght(x1lineB, y1lineB, x2lineB, y2lineB);

            if (lengthA >= lengthB)
            {
                PrintClosestPoint(x1lineA, y1lineA, x2lineA, y2lineA);
                PrintFarPoint(x1lineA, y1lineA, x2lineA, y2lineA);
            }
            else
            {
                PrintClosestPoint(x1lineB, y1lineB, x2lineB, y2lineB);
                PrintFarPoint(x1lineB, y1lineB, x2lineB, y2lineB);
            }
        }
    }
}
