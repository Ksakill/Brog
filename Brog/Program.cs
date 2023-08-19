using System;

namespace TireCountCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert Nummer af Motercykler: ");
            int NummerafM = int.Parse(Console.ReadLine());

            Console.Write("Insert Nummer af biler: ");
            int NummerafB = int.Parse(Console.ReadLine());

            Console.Write("Insert Nummer af Busser: ");
            int Nummerafbs = int.Parse(Console.ReadLine());

            Console.Write("Insert Nummer af Lastbiler: ");
            int NummerafL = int.Parse(Console.ReadLine());

            int totalTires = CalculateTotalTires(NummerafM, NummerafB, Nummerafbs, NummerafL);

            Console.WriteLine($"Total Nummer af dæk på brogen: {totalTires}");
            Console.WriteLine("Motorcykler har 2 dæk, Biler har 4, Lastbiler og Busser har 6.");
        }

        static int CalculateTotalTires(int Motercykeler, int Biler, int Lastbiler, int Busser)
        {
            int motorcyclenummer = Motercykeler * Motorcycl;
            int Bilnummer = Biler* Bil;
            int busnummer = Busser * Bus;
            int lastbilnummer = Lastbiler * Lastbil;

            int totalTireCount = motorcyclenummer + Bilnummer + busnummer + lastbilnummer;
            return totalTireCount;
        }

        // Define the number of tires for each type of vehicle
        const int Motorcycl = 2;
        const int Bil = 4;
        const int Lastbil = 6;
        const int Bus = 6;
    }
}





