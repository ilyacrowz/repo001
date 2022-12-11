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

//  //Задача 53: Задайте двумерный массив.
// // Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int[,] FillMatrix(int rows, int columns)
// {
// int[,] matrix = new int [rows, columns];
// for(int i = 0; i < matrix.GetLength(0); i++)
// {
// for(int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i,j] = new Random().Next(0,10);
// }
// }
// return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
// for(int i = 0; i < matrix.GetLength(0); i++)
// {
// for(int j = 0; j < matrix.GetLength(1); j++)
// {
// Console.Write(matrix[i,j] + " ");
// }
// Console.WriteLine();
// }
// }
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = FillMatrix(m,n);
// PrintMatrix(matrix);
// Console.WriteLine();

// for(int j = 0; j < matrix.GetLength(1); j++)
// {
// int temp = matrix[0, j];
// matrix[0,j] = matrix[matrix.GetLength(0)-1,j];
// matrix[matrix.GetLength(0)-1,j] = temp;
// }

// PrintMatrix(matrix);

//======================================================================================================

// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = FillMatrix(m,n);
// PrintMatrix(matrix);
// Console.WriteLine();

// for(int k = 0; k < 10; k++)
// {
// int count = 0;
// for(int i = 0; i < matrix.GetLength(0); i++)
// {
// for(int j = 0; j < matrix.GetLength(1); j++)
// {
// if(matrix[i,j] == k)
// {
// count++;
// }
// }
// }
// if(count != 0) Console.WriteLine($"Кол-во повторений для {k} = {count}");
// }

//====================================================================================================

// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrix(m, n);
// PrintMatrix(matrix);
// Console.WriteLine();

// int[] countArray = new int[10];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// int index = matrix[i,j];
// countArray[index]++;
// }
// }

// for(int i = 0; i < countArray.Length; i++)
// {
// if(countArray[i] != 0)
// {
// Console.WriteLine($"Кол-во повторений для {i} = {countArray[i]} раз");
// }
// }
