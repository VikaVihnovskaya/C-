// Задача 64.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// string NumbersRec(int n, int b)
// {
// if (n >= 1) return $"{n} " + NumbersRec((n - 1),b);
// else return String.Empty;
// }

// Console.WriteLine("Введите число n");
// int n = Convert.ToInt32(Console.ReadLine());
// int b = 1;
//  Console.WriteLine(NumbersRec(n, b));

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumber (int m, int n)
{
    if ( n==m) return m;
    else return n +  SumNumber( m,n-1);
}

Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
 int n = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine(SumNumber(m,n));