/*Задача 63 Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

N = 5 -> "1, 2, 3, 4, 5"

N = 6 -> "1, 2, 3, 4, 5, 6" */ 

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

string Recurs (int minValue, int n)
{
    if (minValue == n) 
    {
        return n.ToString();
    }

    return (minValue + " " + Recurs(minValue +1, n));   
}
Console.WriteLine(Recurs(1, n)); 

