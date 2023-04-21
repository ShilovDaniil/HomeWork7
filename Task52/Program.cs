// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Read(string arg)
{
  System.Console.WriteLine($"Введите {arg}: ");
  return int.Parse(System.Console.ReadLine());
}

int length1 = Read("длину строк");
int length2 = Read("длину столбцов");

int[,] array = CreateArray(length1, length2);
PrintArray(array);
MidArifm(array);

void MidArifm(int[,] array)
{
 System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
 for (int j = 0; j < array.GetLength(1); j++)
 {
   double sum = 0;
   for (int i = 0; i < array.GetLength(0); i++)
   {
   sum += array[i,j];
   }
   System.Console.Write(sum/array.GetLength(0) + "; ");
 }
}

int[,] CreateArray (int length1, int length2)
{
  int[,] array = new int[length1, length2];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = new Random().Next(-10,10);
    }
  }
  return array;
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
  }
}