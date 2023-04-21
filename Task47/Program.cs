/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */



//Не понимаю как сделать по-другому double, чтоб не были такие длинные числа

double Read(string arg)
{
  System.Console.WriteLine($"Введите {arg}: ");
  return double.Parse(System.Console.ReadLine());
}

double length1 = Read("длину строк");
double length2 = Read("длину столбцов");

double[,] CreateArray(double length1, double length2)
{
  double[,] array = new double[(int)length1,(int)length2];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = new Random().NextDouble();
    }
  }
  return array;
}

void PrintArray( double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write(array[i,j] + " ");
    }
    System.Console.WriteLine();
  }
}

PrintArray(CreateArray(length1, length2));