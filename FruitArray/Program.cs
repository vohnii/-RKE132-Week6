﻿using System;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis puuvilja kasutaja sööb

            string[] fruit = new string[5] { "an apple", "a banana", "a lemon", "an orange", "a mango" };

            //Console.WriteLine("Enter a number from 0 to 4:");
            Random rnd = new Random();
            int userNumber = rnd.Next(0, fruit.Length);

            Console.WriteLine($"Today you will have {fruit[userNumber]}");


        }
    }
}