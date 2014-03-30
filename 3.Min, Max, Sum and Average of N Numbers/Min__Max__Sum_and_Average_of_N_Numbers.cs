using System;
using System.Collections.Generic;
using System.Linq;

class Min__Max__Sum_and_Average_of_N_Numbers
{
    static void Main()
    {
        //Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
        //The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 
        //    The output is like in the examples below. Examples:
        Console.Write("Please enter n: ");
        int n;
        n = int.Parse(Console.ReadLine());
        List<double> list = new List<double>();
        for (int i = 0; n > i; i++)
        {
            list.Add(double.Parse(Console.ReadLine()));
        }
        Console.WriteLine("Min " + list.Min());
        Console.WriteLine("Max " + list.Max());
        Console.WriteLine("Sum " + list.Sum());
        Console.WriteLine("Average " + list.Average());

    }

}
