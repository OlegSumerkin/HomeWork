﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input any number: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
    while (a > 0)
    {
        sum = sum + a % 10;
        a = a /10 ;
    }
 Console.WriteLine(sum);