// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.


int num = Enter("Enter array length: ");
int[] array = FillArray(num);
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        count++;
    }
}
int[] FillArray(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(99,999);
    }
    return arr;
}
int Enter(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(count);

// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

int num = Enter("Enter array length: ");
int[] array = FillArray(num);
int[] FillArray(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,999);
    }
    return arr;
}
int Enter(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int count=0;
for(int i=0; i < array.Length; i++)
    {
        if(array[i] > 10 && array[i] < 99)
        count++;
    }
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"[10,99]-> {count} numbers");

//  Задайте одномерный массив, заполненный случайными числами.
//   Найдите сумму элементов, стоящих на нечётных позициях(индексах).

int num = Enter("Enter array length: ");
int[] array = FillArray(num);
int[] FillArray(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,999);
    }
    return arr;
}
int Enter(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int result = 0;
for(int i = 0; i < array.Length; i++)
{
    if(i % 2 != 0)
    {
        result+=array[i];
    }
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"The sum of the elements standing in odd positions = {result}");

// Задайте массив вещественных(тип double) чисел.
// Найдите разницу между максимальным и минимальным элементов массива.


int num = Enter("Enter array length: ");
double[] array = FillArray(num);
double[] FillArray(int size)
{
    double[] arr = new double[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((Convert.ToDouble(new Random().Next(0,100)) + new Random().NextDouble()),2);
    }
    return arr;
}
int Enter(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
double result = max - min;
Console.WriteLine(string.Join("; ", array));
Console.WriteLine($"Max num - Min num = {Math.Round(result,2)}");
