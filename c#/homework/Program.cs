// // Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.WriteLine("Введите число А");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В");
// int b = Convert.ToInt32(Console.ReadLine());
// int num = 0;
// int pow = 1;
// while( pow <= b)
// {
//     num=num * a*pow;
//     pow++;

// }
// Console.WriteLine($"Ответ:{num}");



// //Задача 27.Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.WriteLine("Введите число ");
// int x = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (x > 0)
// {
//     int lastNum = x%10;
//     sum = sum + lastNum;
//     x = x/10;
// }

// Console.WriteLine(sum);


// Задача 29. Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write($"{array[i]}, ");
}
