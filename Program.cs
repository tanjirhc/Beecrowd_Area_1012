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
            string[] values = Console.ReadLine().Split();

            Console.WriteLine("TRIANGULO: " + ((double.Parse(values[0]) * double.Parse(values[2])) / 2).ToString("0.000"));
            Console.WriteLine("CIRCULO: " + ((Math.PI * (double.Parse(values[2]) * double.Parse(values[2])))).ToString("0.000"));
            Console.WriteLine("TRAPEZIO: " + (((double.Parse(values[0]) + double.Parse(values[1])) * double.Parse(values[2])) / 2).ToString("0.000"));
            Console.WriteLine("QUADRADO: " + (double.Parse(values[1]) * double.Parse(values[1])).ToString("0.000"));
            Console.WriteLine("RETANGULO: " + ((double.Parse(values[0]) * double.Parse(values[1]))).ToString("0.000"));
            Console.ReadKey();
        }
    }
}
