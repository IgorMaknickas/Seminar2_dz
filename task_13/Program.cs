//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
if (num <= 99)
{
    Console.WriteLine("Нет третьего числа");
}
else if ((num > 999) & (num < 9999))
{
    Console.WriteLine((num / 10) % 10);
}
else if ((num > 9999) & (num < 99999))
{
    Console.WriteLine((num / 100) % 10);
}
else if ((num > 99999) & (num < 999999))
{
    Console.WriteLine((num / 1000) % 10);
}
else
{
    Console.WriteLine(num % 10);
}