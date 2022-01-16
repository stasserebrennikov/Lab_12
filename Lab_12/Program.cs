using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double leghtcircle = Circle.GetLeghtCircle(R);
            double square = Circle.GetSquare(R);
            string centr = Circle.Centr(x, y, R);
            Console.WriteLine($"{leghtcircle}\n {square}\n {centr}");
            Console.ReadKey();

        }
    }
}
