using System;

    class Numbers_Not_Divisible_by_3_and_7
    {
        static void Main()
        {
            //Write a program that enters from the console a positive integer n and prints all the numbers 
            // from 1 to n not divisible by 3 and 7, on a single line, separated by a space. Examples:
            int number;
            Console.Write("Please enter a positive number: ");
            number = int.Parse(Console.ReadLine());
            double start = 1;

            do
            {
                if ((start % 3 == 0) || (start % 7 == 0))
                {
                    start++;
                    
                }
                else
                {
                    Console.Write("{0} ", start);
                    start++;
                }

            }
            while (number >= start);
        }
    }

