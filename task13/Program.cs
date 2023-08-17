/*
Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Напишите число:");
int number=Convert.ToInt32(Console.ReadLine());
if (number<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (number>=100 && number<1000)
{
    Console.WriteLine(number%10);
}
else
{
    int result=number/100;
    Console.WriteLine(result%10);
}