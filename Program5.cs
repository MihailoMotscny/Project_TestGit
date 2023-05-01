using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Запитуємо у користувача значення n
        Console.Write("Введіть значення n: ");
        int n = int.Parse(Console.ReadLine());

        // Зчитуємо елементи з файлу
        int[] numbers = File.ReadAllLines("file.txt")
                            .Select(int.Parse)
                            .ToArray();

        // Знаходимо всі переважні елементи
        List<int> majorityElements = GetMajorityElements(numbers, n);

        // Виводимо результат
        Console.WriteLine("Переважні елементи:");
        foreach (int element in majorityElements)
        {
            Console.WriteLine(element);
        }
    }

    static List<int> GetMajorityElements(int[] numbers, int n)
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();

        // Рахуємо кількість входжень кожного елемента в масиві
        foreach (int number in numbers)
        {
            if (frequency.ContainsKey(number))
            {
                frequency[number]++;
            }
            else
            {
                frequency[number] = 1;
            }
        }

        // Знаходимо всі елементи, які зустрічаються більше n/2 разів
        List<int> majorityElements = new List<int>();
        foreach (KeyValuePair<int, int> pair in frequency)
        {
            if (pair.Value > n / 2)
            {
                majorityElements.Add(pair.Key);
            }
        }

        return majorityElements;
    }
}
