
// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

string Recurs (int m, int n)
{
    if (m == n) 
    {
        return n.ToString();
    }

    return (m + " " + Recurs(m + 1, n));   
}
Console.WriteLine(Recurs(m, n));


