// Задача 34.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// void fillArr(int[] array) 
//  { 
//     int index = 0;
//     while (index < array.Length) 
//     { 
//         array[index] = new Random().Next(100, 1000); 
//         index++; 
//     } 
// } 

// void printArr(int[] nArray) 
// { 
//     int count = nArray.Length; 
//     int pos = 0; 
//     while (pos < count) 
//     { 
//         Console.Write($"{nArray[pos]} "); 
//         pos++; 
//     } 
// } 
// void sizeArr( int[] array1)
// { 
//     int count = 0; 
//     for( int index=0;index<array1.Length; index++)
//     { 
//          if(array1[index]%2==0) 
//          {
//             count++;
//          } 
         
//     } 
//    Console.WriteLine($"Количество четных элементов массива: {count}"); 
// }
// int []arr=new int[4]; 
// fillArr(arr); 
// printArr(arr); 
// sizeArr(arr); 
// Console.WriteLine(); 




// Задача 36.Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// void fillArr(int[] array) 
//  { 
//     int index = 0;
//     while (index < array.Length) 
//     { 
//         array[index] = new Random().Next(-100, 100); 
//         index++; 
//     } 
// } 

// void printArr(int[] nArray) 
// { 
//     int count = nArray.Length; 
//     int pos = 0; 
//     while (pos < count) 
//     { 
//         Console.Write($"{nArray[pos]} "); 
//         pos++; 
//     } 
// } 
//  void sumArr (int[]array) 
// {
//      int sum=0; 
//      for( int index=1;index<array.Length; index++)
//      { 
//         if (array[index]%2!=0) 
//         { 
//             sum+= array[index]; 
//         } 
//      }    
//    Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях= {sum}"); 
// }
// int []arr=new int[4]; 
// fillArr(arr); 
// printArr(arr); 
// sumArr(arr); 
// Console.WriteLine();



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void fillArr(double[] array) 
 { 
    int index = 0;
    while (index < array.Length) 
    { 
        array[index] = new Random().NextDouble()*100; 
        index++; 
    } 
} 
void printArr(double[] nArray) 
{ 
    int count = nArray.Length; 
    int pos = 0; 
    while (pos < count) 
    { 
        Console.Write($"{nArray[pos]} "); 
        pos++; 
    }
}
void diff(double[] array)
{
    double maxValue=array[0];
    double minValue=array[0];
    for(int index=1;index<array.Length;index++)
    {
         if( array[index]>maxValue)
         {
            maxValue=array[index];
         }
        else if( array[index]<minValue)
        {
            minValue=array[index];
        }
    }
    double diff= maxValue-minValue;
    Console.WriteLine($" Разница между максимальным и минимальным значениями элементов равна: {diff}");
}

double []arr=new double[6]; 
fillArr(arr); 
printArr(arr); 
diff(arr); 
Console.WriteLine();