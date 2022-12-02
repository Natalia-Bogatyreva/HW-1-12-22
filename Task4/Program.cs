// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int numberA = 0;
int numberB = 0;
int numberC = 0;
Console.Write("Вам нужно ввести 3 числа для сравнения. Введите первое число:");
numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
numberC = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB || numberB == numberC)
{
    Console.WriteLine("Числа равны. Невозможно найти максимальное и минимальное число.");
}
else
{
    if(numberA > numberB)
    {
        if(numberA > numberC )
        {
                Console.WriteLine("Максимальное число -> " + numberA);
            }
            else 
            {
                Console.WriteLine("Максимальное число -> " + numberC);
            }
        }
        else
        {
            if(numberB > numberC)
            {
                Console.WriteLine("Максимальное число -> " + numberB);
            }
            else
            {
                Console.WriteLine("Максимальное число -> " + numberC);
            }
        }
    if(numberA < numberB)
    {
        if(numberA < numberC )
        {
            Console.WriteLine("Минимальное число -> " + numberA);
        }
        else 
        {
            Console.WriteLine("Минимальное число -> " + numberC);
        }
    }
    else
    {
        if(numberB < numberC)
        {
            Console.WriteLine("Минимальное число -> " + numberB);
        }
        else
        {
            Console.WriteLine("Минимальное число -> " + numberC);
        }
    }
}