// See https://aka.ms/new-console-template for more information
int[] week = {1, 2, 3, 4, 5, 6, 7};
int i = 0;
Console.WriteLine("Enter day of the week number: ");
week[i] = Convert.ToInt32(Console.ReadLine());
do{
    Console.WriteLine("Thats day number doesn't exist try again: ");
    week[i] = Convert.ToInt32(Console.ReadLine());}
while(week[i]<1^week[i]>7);
if(week[i]<6&week[i]>0) Console.WriteLine("It is not weekend");
if(week[i]<8&week[i]>5) Console.WriteLine("It is weekend");