//Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90]

using System;

namespace Task01
{
class Program
{
static void Main(string[] args)
{
Random random = new Random();

        int[] array = new int[10];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100);
        }

        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 20 && array[i] <= 90)
            {
                count++;
            }
        }

        Console.WriteLine("Количество элементов в массиве, значения которых лежат в отрезке [20, 90]: " + count);

        }
}
}

