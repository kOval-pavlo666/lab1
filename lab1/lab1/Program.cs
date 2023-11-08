using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;




class Програма
{
    static void Main(string[] args)
    {
        Console.WriteLine("завдання 1");
        SortedList mySortedList = new SortedList();

        // Додаємо елементи зазначеної кількості
        mySortedList.Add("int", "цілий");
        mySortedList.Add("char", "символьний");
        mySortedList.Add("bool ", "логічний");
        mySortedList.Add("float ", "дійсний");
        mySortedList.Add("double ", "дійсний з подвійною точністю");
        mySortedList.Add("short", "короткий");
        mySortedList.Add("long ", "довгий");

        // Виводимо елементи на консоль у прямому порядку
        Console.WriteLine("Елементи в прямому порядку:");
        foreach (DictionaryEntry entry in mySortedList)
        {
            Console.WriteLine($"{entry.Key} - {entry.Value}");
        }

        // Виводимо елементи на консоль у зворотньому порядку
        Console.WriteLine("\nЕлементи в зворотньому порядку:");
        for (int i = mySortedList.Count - 1; i >= 0; i--)
        {
            Console.WriteLine($"{mySortedList.GetKey(i)} - {mySortedList.GetByIndex(i)}");
        }

        // Виводимо кількість елементів у колекції
        Console.WriteLine($"\nКількість елементів у колекції: {mySortedList.Count}");

        // Очищуємо колекцію
        mySortedList.Clear();
        Console.WriteLine("\nКолекція очищена.");
        Console.ReadLine();
        Console.WriteLine("завдання 2");
        List<int> numbers = new List<int> { 3, 7, 1, 9, 4, 2, 6, 8, 5 }; // Замініть це на ваш список чисел

        if (numbers.Count > 0)
        {
            int min = numbers.Min();
            int max = numbers.Max();

            double average = (min + max) / 2.0;

            Console.WriteLine($"Середнє арифметичне мінімального ({min}) та максимального ({max}) елементів: {average}");
        }
        else
        {
            Console.WriteLine("Список чисел порожній.");
        }
    }
}
