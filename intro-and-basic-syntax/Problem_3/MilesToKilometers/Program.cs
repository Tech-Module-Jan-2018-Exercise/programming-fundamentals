using System;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceInMiles = double.Parse(Console.ReadLine());

            double kilometersPerMile = 1.60934;

            //calculating the distance in km
            var distanceInKilometers = distanceInMiles * kilometersPerMile;

            Console.WriteLine("{0:F2}", distanceInKilometers);
        }
    }
}
