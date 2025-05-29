using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Read the array from the console
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        // Keep condensing until only one element is left
        while (numbers.Length > 1)
        {
            int[] condensed = new int[numbers.Length - 1];

            for (int i = 0; i < condensed.Length; i++)
            {
                condensed[i] = numbers[i] + numbers[i + 1];
            }

            numbers = condensed;
        }

        // Output the final result
        Console.WriteLine(numbers[0]);
    }
}
