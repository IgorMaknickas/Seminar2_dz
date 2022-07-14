// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7");
int num = int.Parse(Console.ReadLine());
if (num <= 5) 
{
Console.WriteLine("Нет");
}
else
{
    if ((num > 5) & (num <= 7));
    Console.WriteLine("Да");
}
