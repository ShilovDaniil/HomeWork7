// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int Read(string arg)
{
  System.Console.WriteLine($"Введите {arg}: ");
  return int.Parse(System.Console.ReadLine());
}

int length1 = Read("длину строк");
int length2 = Read("длину столбцов");

int[,] CreateArray(int length1, int length2)
{
  int[,] array = new int[length1, length2];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(-10, 10);
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

PrintArray(CreateArray(length1,length2));

void FindElement(int[,] array)
{
  System.Console.WriteLine("Введите координаты элемента(длину строки): ");
  int row = int.Parse(System.Console.ReadLine()) - 1;
  System.Console.WriteLine("Введите координаты элемента(длину столбца): ");
  int column = int.Parse(System.Console.ReadLine()) - 1;
  if (row >= array.GetLength(0) || column >= array.GetLength(1))
  {
   Console.WriteLine("Такого элемента нет");
  }
  else
  {
   Console.WriteLine($"Значение элемента: {array[row, column]}");
  }
}

FindElement(CreateArray(length1,length2));