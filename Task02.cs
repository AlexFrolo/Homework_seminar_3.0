//Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве

using System;

namespace Task02 { 
    
    class Program { 
        static void Main(string[] args) { 

            Random random = new Random(); 

            int[] array = new int[10]; 

            for (int i = 0; i < array.Length; i++) { 
                
                array[i] = random.Next(-100, 101); 
                }

int evenCount = 0;

for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
{
evenCount++;
}
}
Console.WriteLine("Количество четных чисел: " + evenCount);
} 
} 
}

