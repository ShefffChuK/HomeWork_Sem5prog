//  Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найти сумму отрицательных и положительных элементов массива.

// int[] array = GetRandomArray(12, -9, 9);
// Console.WriteLine($"[{String.Join(",",array)}]");

// int positivesum = 0;
// int negativesum = 0;

// foreach(int el in array)
// {
//   positivesum += el > 0 ? el : 0;
//   negativesum += el < 0 ? el : 0;  
// }
// System.Console.WriteLine($"Positive sum = {positivesum} and negative sum = {negativesum}");

// int[] GetRandomArray(int size, int minValue, int maxValue)
//     {
//         int[] result = new int[size];
//         for (int i=0; i < size; i++)
//         {
//         result[i]=new Random().Next(minValue , maxValue + 1);
//         }
//         return result;
//     }

// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.


// int[] array = GetRandomArray(5, -10, 10);
// Console.WriteLine($"[{String.Join(",", array)}]");

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] *= -1;
// }
// Console.WriteLine($"[{String.Join(",", array)}]");

// ---------------------Общий метод----------------------
// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }

// Задайте массив,. Напишите программу, которая определяет присутствует ли заданное число в массиве?

// int[] array = GetRandomArray(5, -10, 10);
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// if (FindElement(array, num))
// {
//     Console.WriteLine("Да ");
// }
// else 
// {
//     Console.WriteLine("Нет ");
// }

// bool FindElement (int[] array, int number)
// {
//     foreach (int el in array)
//     {
//         if (number == el) return true;
//     }
//     return false;
// }





// //---------------------Общий метод----------------------
// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }

// Задайте одномерный массив из 123 случайных чисел. Найдите кол-во элементов массива, значения которых лежат в отрезке [10, 99]

// int[] array = GetRandomArray(123, 0, 1000);
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine("Введите левый предел: ");
// int leftrange = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите правый предел: ");
// int rightrange = int.Parse(Console.ReadLine()!);

// Console.WriteLine(FindElement(array, leftrange, rightrange));

// int FindElement (int[] array, int leftrange, int rightrange)
// {
//         int count = 0;
//         foreach(int el in array)
//         {
//                if(el >= leftrange && el <= rightrange)
//                count++;
//         }
//         return count;
// }




// //---------------------Общий метод----------------------
// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }


// Задача 37:** Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21






int[] array = GetRandomArray(9, 0, 10);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"[{String.Join(",", GetMultiply(array))}]");

int[] GetMultiply(int[] array)
{
    int size = array.Length / 2;
    if(array.Length % 2 != 0) size++;
    int[] arrayMultiply = new int[size];
    for(int i = 0; i < array.Length / 2; i++)
    {
        arrayMultiply[i] = array[i] * array[array.Length - 1 - i];
    }
    if(array.Length % 2 != 0) arrayMultiply[size - 1] = array[array.Length / 2];
    return arrayMultiply;
   
}


//---------------------Общий метод----------------------
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}