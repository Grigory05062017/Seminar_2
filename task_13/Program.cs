// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 99)
    {
    Console.WriteLine("третьей цифры нет");
return;
    }

while (n >= 1000)

{
   n = n/10;
}
Console.WriteLine(n%10);