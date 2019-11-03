﻿using System;

namespace Chapter_13_Solution_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter equation: ");
            string input = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') counter++;
                if (input[i] == ')') counter--;
                if (counter < 0) break;                
            }

            if (counter == 0) Console.WriteLine("Correct equation.");
            else Console.WriteLine("Wrong equation!");

            Console.ReadLine();
        }
    }
}