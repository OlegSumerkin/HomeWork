// See https://aka.ms/new-console-template for more information
int[] array = new int[8];
Random rand = new Random();
int count=0;{
Console.Write("[");
for (int i = 0; i < 8; i++){
    array[i] = rand.Next(100, 999);
    Console.Write(array[i]);
    if(i<7)Console.Write(", ");}
Console.Write("]");
    for(int i=0;i<array.Length;i++){
        if(array[i]%2==0) count=count+1;}
Console.Write($" =>  {count}");}