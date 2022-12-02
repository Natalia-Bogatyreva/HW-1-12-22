// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int numberA = 0;
int numberB = 0;
Console.Write("Вам нужно ввести 2 числа для сравнения. Введите первое число:");
numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("Максимальное число -> " + numberA);
    Console.WriteLine("Минимальное число -> " + numberB);
}
else
{
    if (numberB > numberA)
    {
        Console.WriteLine("Максимальное число -> " + numberB);
        Console.WriteLine("Минимальное число -> "  + numberA);
    }
    else
    {
      Console.WriteLine("Числа равны. Невозможно найти максимальное и минимальное число.");   
    }
}