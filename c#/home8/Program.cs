// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Результат кубов чисел: ");
for(int i= 1; i<=num; i++)
{
   double number = Math.Pow (Convert.ToDouble(i),3.0);
   Console.WriteLine(Convert.ToInt32(number));
}