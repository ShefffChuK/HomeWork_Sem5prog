// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



int[] array = GetRandomArray(6, -100, 100);
Console.WriteLine($"[{String.Join(",", array)}]");

int GetSum(int[] array)
{
    
    int sum = 0;
    for(int i = 1; i < array.Length; i = i + 2)
        {
        sum = sum + array[i];
        }
    return sum;
}
Console.WriteLine($"Сумма элементов на нечетных индексах равна {GetSum(array)}");



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