/*Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

453 -> 12

45 -> 9 */


Console.WriteLine("Введите число N: ");
int Num = int.Parse(Console.ReadLine());

int SumOfDigits (int Num)
{
    if (Num < 10) return Num;
    else return Num % 10 + SumOfDigits(Num / 10);
}
Console.WriteLine(SumOfDigits(Num));

