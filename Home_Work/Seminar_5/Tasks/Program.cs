﻿// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// //[345, 897, 568, 234] -> 2



// int[] CreateArray(int size, int Min, int max)
//  { int[] array = new int[size];
//  Random rnd = new Random();
// for (int i = 0; i < size; i++)
//  { array[i] = rnd.Next(Min, max);
// }
// return array;
// }

// int EvenNumber(int[] array)
// {
//     int count = 0;
//     for ( int i =0; i < array.Length; i++)
//      {
//         if (array[i] % 2 == 0) count++;
//      }
//      return count;
// }

// string GetArray(int[] array)
// {
//     string count = string.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         count = count + $"{array[i]}, ";
//     }
//     return count;
// }
// int[] array  = CreateArray(10, 100, 1000);

// System.Console.WriteLine(GetArray(array));
// System.Console.WriteLine(EvenNumber(array));



//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateArray(int size, int Min, int max)
//  { int[] array = new int[size];
//  Random rnd = new Random();
// for (int i = 0; i < array.Length; i++)
//  { array[i] = rnd.Next(Min, max);
// }
// return array;
// }

// int[] SumOddNumber(int[] array){
// int sum = 0;
// for (int i =0; i < array.Length; i++)
// {
//     if (array[i] % 2 != 0) sum = sum + array[i];
//  }  
//   return array;
// }

// string GetArray(int[] array)
// {
//     string sum = string.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         sum = sum + $"{array[i]}, ";
//     }
//     return sum;
// }
// int[] array  = CreateArray(4, 1, 10);


// 


// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

int[] CreateArray(int size, int Min, int max)
 { int[] array = new int[size];
 Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
 { array[i] = rnd.Next(Min, max);
}
return  array;
}

int DifElements(int[] array){
//int dif = 0;
int MinElement = array[0];
int MaxElement = array[0];
 for (int i = 0; i < array.Length; i++)
 {
    if (array[i] < MinElement) 
    {                
         MinElement = array[i];}
     
     if (array[i] > MaxElement)
    {
         MaxElement = array[i];}
    }
   int dif = MaxElement - MinElement;

  return dif;  
}
string GetArray(int[] array)
{
    string dif = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        dif = dif + $"{array[i]}, ";
    }
    return dif;
}

int[] array  = CreateArray(5, 1, 30);
Console.WriteLine(GetArray(array));
Console.WriteLine("Разница между минимальным и максимальным элементом массива = " + DifElements(array));



// double[] arrayRealNumbers = new double[10];
//   for (int i = 0; i < arrayRealNumbers.Length; i++ )
//   {
//     arrayRealNumbers[i] = new Random().Next(1, 10);
//     Console.Write(arrayRealNumbers[i] + " ");
//   }

// double maxNumber = arrayRealNumbers[0];
// double minNumber = arrayRealNumbers[0];

//   for (int i = 1; i < arrayRealNumbers.Length; i++)
//   {
//     if (maxNumber < arrayRealNumbers[i])
//     {
//       maxNumber = arrayRealNumbers[i];
//     }
//         if (minNumber > arrayRealNumbers[i])
//     {
//       minNumber = arrayRealNumbers[i];
//     }
//   }

//   double decision = maxNumber - minNumber;

//   Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");