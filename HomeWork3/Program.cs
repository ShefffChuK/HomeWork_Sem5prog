// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76


Console.WriteLine("Введите массив ");
int size = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[size];

ArrayRandomNumbers(numbers);
Console.WriteLine($"[{String.Join(", ", numbers)}]");

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

Console.WriteLine($"кол-во в массиве {numbers.Length} чисел. макс = {max}, мин  = {min}");
Console.WriteLine($"Разница между макс и мин = {max - min}");

void ArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 10;
        }
}
