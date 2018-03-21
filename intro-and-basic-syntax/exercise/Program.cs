using System;

namespace _01_card
{
    class Program
    {
        static void Main(string[] args)
        {   /* On the first 4 lines we read the integers from the console*/
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());

            //As output we print the numbers in creditcard form with the help of the subscipts :D4 and:00.00  .
            Console.WriteLine($"{numOne:D4} {numTwo:D4} {numThree:D4} {numFour:D4} {numOne:00.00}");

        }
    }
}
