﻿using System;

namespace _01_card
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numOne:D4} {numTwo:D4} {numThree:D4} {numFour:D4} {numOne:00.00}");

        }
    }
}
