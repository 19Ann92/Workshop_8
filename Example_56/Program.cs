// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns);
int[] array1 = FindSumOfRowElements(array);

Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Суммы строк: {string.Join(", ", array1)}");
CreateAnArrayFromString(array1);


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

int[] FindSumOfRowElements(int[,] array)
{
    int[] b = new int[array.GetLength(0)];
    int sum = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        b[index] += sum;
        index++;
        sum = 0;
    }
    return b;
}

void CreateAnArrayFromString(int[] array)
{
    int min = array[0];
    int minRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]<min)
        {
           min = array[i];
           minRow = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow+1}");
}

