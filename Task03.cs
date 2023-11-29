//Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива

using System;

namespace Task03 { 

     class Program { 
        
        static void Main(string[] args) { 
   
   double[] array = new double[10];

Random random = new Random();

for (int i = 0; i < array.Length; i++) {

array[i] = random.NextDouble() * 10;
}
double max = array.Max();

double min = array.Min();

double result = (max - min);

Console.WriteLine(result);
         }
     
     }
    
}
  