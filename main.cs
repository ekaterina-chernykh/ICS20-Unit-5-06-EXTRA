// Created by: Ekaterina
// Created on: Dec 2022
//
// This program multiplies with and addition while loop

using System;

class Program
{
    public static void Main(string[] args)
    {
        double value1;
        int value2;
        int counter = 0;
        double result = 0;
        double value1pos;
        int value2pos;

        // This function accepts user input
        Console.WriteLine("Enter 2 numbers to multiply:");
        Console.WriteLine(" ");

        Console.WriteLine("Value 1: ");
        value1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("Multipliction Factor: ");
        value2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(" ");

        Console.WriteLine(" ");
        value1pos = Math.Abs(value1);
        value2pos = Math.Abs(value2);
        while (counter < value2pos)
        {
            result = result + value1pos;
            counter = counter + 1;
        }

        if ((value1 < 0 && value2 > 0) || (value1 > 0 && value2 < 0))
        {
            Console.WriteLine("The result is: -" + result.ToString("0.0"));
        }
        else 
        {
            Console.WriteLine("The result is: " + result.ToString("0.0"));
        }
        Console.WriteLine(" ");
        Console.WriteLine("\nDone.");
    }
}