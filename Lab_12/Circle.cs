using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{

    static class Circle
    {
        static public double GetLeghtCircle(double R)
        {
            return 2 * Math.PI * R;
        }
        static public double GetSquare(double R)
        {
            return Math.PI * R * R;
        }
        static public string Centr( double x, double y, double R)
        {
            double Centr = Math.Sqrt(Math.Pow(0 - x, 2) + Math.Pow(0 - y, 2));

            if (Centr < R)
                return "{Точка находится в кругу}";
            else
                return "Точка вне круга";
                

        }

    }
}
