﻿using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double totalPoints = points;
            for (int i = 0; i < n; i++)
            {
                string nameJury = Console.ReadLine();
                double currentPoints = double.Parse(Console.ReadLine());
                int a = nameJury.Length;
                totalPoints += a * currentPoints / 2;
                if (totalPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {totalPoints:f1}!");
                    break;
                }
            }
            if (totalPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - totalPoints:f1} more!");
            }
        }
    }
}