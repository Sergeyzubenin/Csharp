/*
Напишите программу, которая выводит случайное трёхзначное число
 и удаляет вторую цифру этого числа.
*/

int number=new Random().Next(100,1000);

int n1=number%10;
int n100=number/100;

Console.WriteLine($"{number} {n100*10 +n1}");