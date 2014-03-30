using System;

    class Numbers_from_1_to_N
    {
        static void Main()
        {
            //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space. Examples:
            uint number; 
            int count = 1;
            Console.Write("Please eneter a number = ");
            number = uint.Parse(Console.ReadLine());
            while (number >= count)
            {
                Console.Write("{0} ",count);
                count++;
            }
            Console.WriteLine();
        }
    }

