﻿int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sum = default;

for (int i = 0; i < numbers.Length; i++)
{
    
    if (numbers[i] % 2 == 0)
    {
        sum += numbers[i]; 
    }
}

Console.WriteLine(sum);