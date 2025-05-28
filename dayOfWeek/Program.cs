int number = int.Parse(Console.ReadLine());

string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
if (number >= 1 && number <= 7)
{
    Console.WriteLine(day[number - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}