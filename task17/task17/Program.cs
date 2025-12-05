using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 2, 4, 6, 8, 10 }; //ОбЪявляем массив
        bool allEvent = true; //Проверка на четность
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