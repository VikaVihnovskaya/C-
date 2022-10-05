//Задача 41.Пользователь вводит с клавиатуры М чисел.Посчитайте , сколько чисел больше 0 ввел пользователь
// void FillArr(int[] mas) 
// { 
//     int index=0; 
//     while (index<mas.Length) 
//     { 
//         Console.Write("Введите число- "); 
//         int a = Convert.ToInt32(Console.ReadLine());
//         mas[index] = a; 
//         index++; 

//     } 
// } 

// void PrintArr(int[]mas) 
// { 
//     int i=0; 
//     while (i<mas.Length) 
//     { 
//     Console.Write($"{mas[i]} "); 
//     i++; 
//     } 
//     Console.WriteLine();
// } 

// Console.Write("Введите размер массива, какое количество чисел Вы хотите проверить?- "); 
// int a = Convert.ToInt32(Console.ReadLine()); 
// int [] arr= new int[a]; 
// FillArr(arr); 
// PrintArr((arr)); 
// int count = 0; 
// for( int index=0;index< arr.Length; index++)
//     { 
//          if(arr[index]>0) 
//          {
//             count++;
//          } 
         
//     } 

// Console.WriteLine($"Количество чисел больше 0: {count}"); 



// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите  значение b1 - "); 
double b1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите  значение k1 - "); 
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите  значение b2 - "); 
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите  значение k2 - "); 
double k2 = Convert.ToDouble(Console.ReadLine());
double x= (b2 - b1)/(k1 - k2);
Console.WriteLine();
double y= k1*x+b1;
Console.WriteLine($" Точка пересечения двух прямых: {x};{y} ");


