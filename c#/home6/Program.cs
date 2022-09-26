// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите  любое пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int help = number;
int reverse = 0;
while (number > 0)
{
    int last = number % 10;
    reverse = reverse * 10 + last;
    number = number / 10;
    Console.WriteLine($"Это число в обратном порядке {reverse}");
}
if (help == reverse)
{
    Console.WriteLine($"Это число палиндром");
}
else
{
    Console.WriteLine($"Это число не является палиндромом");
}


