// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int num = Enter("Enter array length: ");
double[] array = FillArray(num);
double[] FillArray(int size)
{
    double[] arr = new double[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = Enter("Enter the number: ");
    }
    return arr;
}
int Enter(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int count = 0;
for(int i = 0; i<array.Length;i++)
{
    if(array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine(string.Join("; ", array));
Console.WriteLine(count + " numbers > 0");




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[,] matrix = new double[2,2];
void EnterLines()
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Enter k: ");
      else Console.Write($"Enter b: ");
      matrix[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}
EnterLines();
double x = (matrix[1,1] - matrix[0,1]) / (matrix[0,0] - matrix[1,0]);
double y = x * matrix[0,0] + matrix[0,1];
if (matrix[0,0] == matrix[1,0] && matrix[0,1] == matrix[1,1]) 
  {
    Console.Write("Straight lines match");
  }
else if (matrix[0,0] == matrix[1,0] && matrix[0,1] != matrix[1,1]) 
  {
    Console.Write("Straight lines are parallel");
  }
else 
  {
    Console.Write($"intersection point: ({x}, {y})");
  }
