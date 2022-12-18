// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.WriteLine("Введите число строк 1-ого двумерного массива: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов 1-ого (и строк 2-ого) двумерного массива: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов 2-ого двумерного массива: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(a, b);
int[,] array1 = FillArray(b, c);
int[,] newMatrices = new int[a,c];

Console.WriteLine();
PrintArray(array);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
FindProductOfTwoMatrices(array, array1, newMatrices);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(newMatrices);


int[,] FillArray(int arrayRows, int arrayColumns)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = random.Next(1, 10);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindProductOfTwoMatrices(int[,] array, int[,] array1, int[,] newMatrices)
{
  for (int i = 0; i < newMatrices.GetLength(0); i++)
  {
    for (int j = 0; j < newMatrices.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array.GetLength(1); k++)
      {
        sum += array[i,k] * array1[k,j];
      }
      newMatrices[i,j] = sum;
    }
  }
}