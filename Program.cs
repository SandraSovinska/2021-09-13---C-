using System;

namespace NamuDarbai
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("koks jusu vardas");

            var vardas = Console.ReadLine();

            Console.WriteLine("kokia jusu pavarde?");

            var pavarde = Console.ReadLine();

            Console.WriteLine("kokia Jusu gimtine?");

            var gimimoVieta = Console.ReadLine();

            Console.Write( vardas +  pavarde +  gimimoVieta ) ;
        }
    }
}
