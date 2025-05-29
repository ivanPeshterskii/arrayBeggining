using System;

int[] arr1 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] arr2 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sum = default;
bool isIdentical = true;

for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i] != arr2[i])
    {
        isIdentical = false;
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        break;
    }
    sum += arr1[i];

    
}
if (isIdentical)
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}

