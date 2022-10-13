/* Задача 69. Напишите программу, которая на вход принимает 2 числа А и В, 
и возводит число А в целую степень B с помощью рекурсии. 
А = 3, В = 5 -> 2433
*/

Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());

int Power(int a, int b)
{
    if (b == 0) return 1;
    if (b == 1) return a;
    return a * Power(a, b - 1);
}
Console.WriteLine(Power(a, b));
