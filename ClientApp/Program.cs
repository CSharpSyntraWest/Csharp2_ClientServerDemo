using ServerApp;
using System;
using System.Collections.Generic;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello van de Client!");
            Console.WriteLine("Opvragen van alle biernamen aan Server:");
            DataService dataService = new DataService();
            IList<string> biernamen = dataService.GeefAlleBiernamen();
            foreach (string biernaam in biernamen)
            {
                Console.WriteLine(biernaam);
            }

            Console.ReadKey();
        }
    }
}
