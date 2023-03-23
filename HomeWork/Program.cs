// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = GetRandomArray(4, 100, 999);
Console.WriteLine($"[{String.Join(",", array)}]");

int GetEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        {
        if(array[i] % 2 == 0) 
        count++;
        }
    return count;
}
//Console.WriteLine($"[{String.Join(",", GetEven(array))}]");

Console.WriteLine($"Кол-во четных элементов: {GetEven(array)}");

        




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
