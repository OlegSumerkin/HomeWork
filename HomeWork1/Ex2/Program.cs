﻿// See https://aka.ms/new-console-template for more information
Console.Write("Input number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number3: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if(number2 > max) max = number2;
if(number3 > max) max = number3;
Console.WriteLine(max);

