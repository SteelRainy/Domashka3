//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 3; i >= 0; i--)
{
    sum += a / (int)Math.Pow(10.0, i);
    a = a % (int)Math.Pow(10.0, i);
}
Console.WriteLine(sum);
