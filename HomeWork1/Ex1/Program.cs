// See https://aka.ms/new-console-template for more information
Console.Write("Input number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number2 > number1)
{
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine(number1);
}
