﻿using System;

namespace UnitTesting_UsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            GreatestNumber obj = new GreatestNumber();
            //Check greatest number among three INT number
            Console.WriteLine("Welcome to generics program!");
            int number1, number2, number3;
            Console.WriteLine("Enter number 1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Greatest number is {0} ", obj.LargestNumber(number1, number2, number3));

            //Check greatest number among three FLOAT number
            float numberf1, numberf2, numberf3;
            Console.WriteLine("Enter number 1");
            numberf1 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            numberf2 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            numberf3 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Greatest number is {0} ", obj.LargestNumberFloat(numberf1, numberf2, numberf3));

            //Check greatest number among three STRINGS
            string string1, string2, string3;
            Console.WriteLine("Enter string 1");
            string1 = Console.ReadLine();
            Console.WriteLine("Enter string 2");
            string2 = Console.ReadLine();
            Console.WriteLine("Enter string 3");
            string3 = Console.ReadLine();
            Console.WriteLine("Greatest string is {0} \n", obj.LargestNumberString(string1, string2, string3));
        }
    }
}
