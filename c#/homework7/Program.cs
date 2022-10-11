// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Console.WriteLine("Задайте количество строк двумерного массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте количество столбцов двумерного массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[m, n];
// void FillArray(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = Convert.ToDouble(new Random().Next(-100, 100) / 10.0);
//         }
//     }
// }
// void PrintArray(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// FillArray(array);
// Console.WriteLine();
// PrintArray(array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = Convert.ToInt32(new Random().Next(0, 100));
//         }
//     }
// }
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Задайте количество строк двумерного массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте количество столбцов двумерного массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// FillArray(array);
// Console.WriteLine();
// PrintArray(array);

// Console.Write("Введите строку:");
// int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите столбец:");
// int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
//      if (pos1 < 0 | pos1 > array.GetLength(0) - 1 | pos2 < 0 | pos2 > array.GetLength(1) - 1)
//     {
//         Console.WriteLine("Элемент не существует");
//     }
//     else
//     {
//         Console.WriteLine("Значение элемента массива = {0}", array[pos1, pos2]);
//     }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToInt32(new Random().Next(0, 100));
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void PrintOnewDimensionArray(double[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
            Console.Write($"{matr[i]} ");
    }
            
     Console.WriteLine();
}

int[] SumArray (int[,] matr)
{
    int[] sums = new int[matr.GetLength(1)];
    for( int i=0;i < matr.GetLength(1); i++)
    {
        for(int j = 0; j < matr.GetLength(0); j++)
        {
            int currentValue = matr[j, i];
            sums[i]= sums[i] + currentValue;
        }
    }
    return sums; 
} 


double[] AveregeArray( int[] sumArray, int n)
{
    double[] averegeSums = new double[sumArray.Length];

    for( int i=0;i<sumArray.Length; i++)
    {
        double averege= Convert.ToDouble(sumArray[i])/Convert.ToDouble(n);
        averegeSums[i] = averege;
    }
    return averegeSums;
}


Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
Console.WriteLine();
PrintArray(array);
int[] sums = SumArray(array);
double[] averageSum = AveregeArray(sums, n);
PrintOnewDimensionArray(averageSum);


