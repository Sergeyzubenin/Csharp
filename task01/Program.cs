﻿/*
Напишите программу, которая на вход принимает два числа и проверяет,
 является ли первое число квадратом второго
 */


 Console.WriteLine("Введите первое число:");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2=Convert.ToInt32(Console.ReadLine());
if (number1==number2*number2){
 Console.WriteLine("Первое чило квадрат второго"); 

}
else{
   Console.WriteLine("Первое чило не квадрат второго");   
}

