﻿using System;
using System.Collections.Generic;

namespace NumberApp

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose 1:\n" +
                "1. List all even numbers between 1 and X" +
                "2. List all odd numbers between 1 and X" +
                "3. List all numbers between 1 and X divisible by Y\n" +
                "4. List all prime numbers between 1 and X");

            Console.WriteLine(ListEvenNumbers(10));
        }

        static List<int> ListEvenNumbers(int endNumber)
        {
            int i = 2;
            List<int> numberList = null;
            while (i < endNumber)
            {
                numberList.Add(i);
                i += 2;
            }
            return numberList;
        }
    }
}
/*Project idea #1: A little math app.  Give the user the options to:
list all the even numbers between 1 and (whatever they want)
list all the odd numbers between 1 and (whatever they want)
List all the numbers between 1 and whatever they want that are evenly divisible by X (user tells you what x is)
List all the prime numbers between 1 and whatever they want*/
