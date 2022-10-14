// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// int[,] FillAndPrintMatrix(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }

//     return array;
// }

// int[,] SortMatrix(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = array.GetLength(1) - 1; j > 0; j--)
//         {

//             for (int l = array.GetLength(1) - 1; l > 0; l--)
//             {
//                 if (array[i, l] > array[i, l - 1])
//                 {
//                     int currentValue = array[i, l - 1];
//                     array[i, l - 1] = array[i, l];
//                     array[i, l] = currentValue;
//                 }
//             }
//         }

//     }
//     return array;
// }

// void PrintNewMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int stringArray = new Random().Next(1, 9);
// int columnArray = new Random().Next(1, 9);
// Console.WriteLine($"m = {stringArray}, n = {columnArray}");
// Console.WriteLine();
// int[,] firstArray = FillAndPrintMatrix(stringArray, columnArray);
// int[,] firstArray1 = SortMatrix(firstArray);
// Console.WriteLine();
// PrintNewMatrix(firstArray1);



//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] FillAndPrintMatrix(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }

//     return array;
// }

// void GetRowNumber(int[,] matr)
// {
//     int[] sums = new int[matr.GetLength(0)];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             int currentValue = matr[i, j];
//             sums[i] = sums[i] + currentValue;
//         }
//     }



//     int minPos = 0;
//     for (int i = 1; i < sums.Length; i++)
//     {
//         if( sums[i]<sums[minPos] )
//         {
//             minPos = i;
//         }
//     }
// Console.WriteLine($"Наименьшая сумма элементов находится на строке {minPos+1} ");
// }

// int stringArray = new Random().Next(1, 9);
// int columnArray = new Random().Next(1, 9);
// Console.WriteLine($"m = {stringArray}, n = {columnArray}");
//  Console.WriteLine();
// int[,] firstArray = FillAndPrintMatrix(stringArray, columnArray);
// GetRowNumber(firstArray);

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int[,] spiralMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
  spiralMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(spiralMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}





