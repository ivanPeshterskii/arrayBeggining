﻿using System.Linq; 

double[] numbers = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    int rounded = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
    Console.WriteLine($"{numbers[i]} => {rounded}");
}