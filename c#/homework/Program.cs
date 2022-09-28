// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int b = Convert.ToInt32(Console.ReadLine());
int num = 1;
int pow = 1;
while( pow <= b)
{
    num=num * a;
    pow++;
    
}
Console.WriteLine($"Ответ:{num}");



