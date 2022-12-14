// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int [rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            {
            matrix[i,j] = new Random().Next(0,10);
            }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Entar rows length: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entar columns length: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = FillMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();

void SortMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                {
                    if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int temp = matrix[i, k + 1];
                            matrix[i, k + 1] = matrix[i, k];
                            matrix[i, k] = temp;
                        }
                }
            }
    }
}

SortMatrix(matrix);
PrintMatrix(matrix);

// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int [rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            {
            matrix[i,j] = new Random().Next(0,10);
            }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Entar rows length: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entar columns length: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = FillMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();
RowMinSum(matrix);
void RowMinSum(int[,] matrix)
{
    int min = 0;
    int minSum = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
        {
            min += matrix[0, i];
        }
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) sum += matrix[i, j];
            if (sum < min)
                {
                    min = sum;
                    minSum = i;
                }
        sum = 0;
        }
    Console.Write($"{minSum + 1} row");
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int [rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            {
            matrix[i,j] = new Random().Next(0,10);
            }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Entar rows length to matrix: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entar columns length to matrix: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = FillMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();
int [,] secondMatrix = FillMatrix(m,n);
PrintMatrix(secondMatrix);
Console.WriteLine();
int[,] resultMatrix = new int[m,n];

void SumMatrix(int[,] martrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < martrix.GetLength(1); k++)
      {
        sum += martrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
SumMatrix(matrix, secondMatrix, resultMatrix);
PrintMatrix(resultMatrix);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] FillMatrix(int rows, int columns, int size)
{
    int[,,] matrix = new int [rows, columns, size];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = new Random().Next(0,10);
            }

            }
    }
    return matrix;
}

Console.WriteLine("Entar x length: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entar y length: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entar z length: ");
int p = Convert.ToInt32(Console.ReadLine());
int [,,] matrix = FillMatrix(m,n,p);
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
        }
    }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Enter matrix sizq ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
{
  matrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}
void PrintNatrix (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($" {matrix[i,j]} ");
    }
    Console.WriteLine();
  }
}
PrintNatrix(matrix);

// Задача 63: Задайте значение N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void Numbers (int num)
{
if (num == 0)
{
return;
}
Console.Write($"{num} ");
Numbers(num -1);
}
Console.Write("Введите число: ");
int nums = Convert.ToInt32(Console.ReadLine());
Numbers(nums);


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int sum = 0;
// void SumNum (int num) {
// if (num == 0) {
// Console.Write(sum);
// return;
// }
// else {
// sum += num%10;
// SumNum(num/10);
// }
// }
// int num = int.Parse(Console.ReadLine());
// SumNum(num);


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int Stepen (int a,int b){
// if (b==0) return 1;
// return a*Stepen(a,b-1);
// }

// Console.WriteLine("Введите А");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите B");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Stepen(a,b));