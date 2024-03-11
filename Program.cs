using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_Area_1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, RectangleTri, Circle, Trapezium, Squre, Rectangle;
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            C = Convert.ToDouble(Console.ReadLine());

            RectangleTri = (0.5*(A + C));
            Circle = 3.14159*C*C;
            Trapezium = A+B+C;
            Squre = B * B;
            Rectangle = 2 * (A + B);

            Console.WriteLine("TRIANGULO: {0:00.000}", RectangleTri);
            Console.WriteLine("CIRCULO: {0:00.000}", Circle);
            Console.WriteLine("TRAPEZIO: {0:00.000}", Trapezium);
            Console.WriteLine("QUADRADO: {0:00.000}", Squre);
            Console.WriteLine("RETANGULO: {0:00.000}", Rectangle);
            Console.ReadKey();
        }
    }
}
