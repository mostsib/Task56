// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

int[,] FillArray(int numline, int numColumns, int maxRand = 20, int minRand = 0)
 {
    int[,] matrix = new int[numline, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(minRand, maxRand);
        }   
    }
    return matrix;
 }
 void PrintArray(int[,] matrix)
 {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++) 
       {
        Console.Write($"{matrix[i, j]}\t");
       }
       Console.WriteLine();
    }
 }
int[] SumOfLine(int[,] matrix)
{
    int[] sum = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i,j];
        }
    }
    return sum;
}
void ArrayPrint(int[] myArr)
{
    for (int j = 0; j < myArr.Length; j++)
    {
        Console.Write($"{myArr[j]}\t");
    }
}

int MinIndex(int[] array)
{
   
    int minNum = array [0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNum)
        {
            minNum = array[i];
            index = i;
        }
    }
    return index;
}

int[,] matrix = FillArray(3,3);
PrintArray(matrix);
Console.WriteLine();
int[] sum = SumOfLine(matrix);
ArrayPrint(sum);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в {MinIndex(sum) + 1} строке");