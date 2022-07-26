// See https://aka.ms/new-console-template for more information
int[] array = new int[8];
Random rand = new Random();
Console.Write("[");
for (int i = 0; i < 8; i++){
    array[i] = rand.Next(9);
    Console.Write(array[i]);
    if(i<7)Console.Write(", ");}
Console.Write("]");