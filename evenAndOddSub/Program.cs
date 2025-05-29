int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int evenSum = default;
int oddSum = default;
int result = default;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenSum += numbers[i]; 
    }
    else
    {
        oddSum += numbers[i]; 
    }
    result = evenSum - oddSum; 
}

Console.WriteLine(result);