// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int numberA = 0;

Console.Write("Введите число:");
numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 == 0 )
{
    Console.WriteLine(numberA +" - четное число");
}
else
{
   Console.WriteLine(numberA +" - нечетное число");
}
