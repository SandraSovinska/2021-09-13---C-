using System;
using System.Globalization;

namespace SpindulioIlgisPlotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ivesk apskritimo spinduli");
            string radiusInstring = Console.ReadLine();

            double spindulys = Convert.ToDouble(radiusInstring,CultureInfo,Console.ReadLine());

            double c = 2 * Math.PI * spindulys;//ilgis

            double s = Math.PI * spindulys * spindulys;

            Console.WriteLine($"Apskritimo ilgis yra:{c}");








        }
    }
}
