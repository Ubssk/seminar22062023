// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());
int baseN = 0;

while ((baseN+1) < N)
{
    if (N % 2 == 0)
    {
        baseN = baseN + 2;
    }
    else
    {
        baseN = baseN + 2;
    } 
    Console.Write(baseN + " ");
}
