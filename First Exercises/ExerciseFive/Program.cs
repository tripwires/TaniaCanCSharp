﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ExerciseFive
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for list of nrs (1,2,3,4)
            //empty list of less then 5 nrs (count) = "invalid list" => ask to retry
            //if list ok = show 3 smallest nrs
            Console.WriteLine("Gief list with nrs separated by ','");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(','); //turns the string into an array

            Console.WriteLine("String to Array:");
            foreach (var a in inputArray)
            {
                Console.Write(a + " - ");
            }

            while ((String.IsNullOrEmpty(input)) || (inputArray.Length < 5))
            {
                Console.WriteLine("Invalid List, try again!");
                input = Console.ReadLine();
                inputArray = input.Split(',');
            }
            Console.WriteLine();

            int[] inputArrayNumbers = MakeNumberList(inputArray);

            Array.Sort(inputArrayNumbers);

            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(inputArrayNumbers[i] + " - ");
            }

            Console.ReadLine();
        }

        private static int[] MakeNumberList(string[] inputArray)
        {
            int[] result = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                result[i] = Convert.ToInt32(inputArray[i]);
            }
            return result;
        }
    }
}