using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 2, 4, 6, 8, 10 };
        bool allEvent = true;
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                allEvent = false;
                break;
            }
        }
        Console.WriteLine(allEvent);
    }
}