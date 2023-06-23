Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());
if (firstDigit > secondDigit)
{    
    Console.WriteLine("Число " + firstDigit + " больше");
}
else
{    
    Console.WriteLine("Число " + secondDigit + " больше");
}