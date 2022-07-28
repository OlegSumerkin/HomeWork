// See https://aka.ms/new-console-template for more information
int[] array = new int[8];
Random rand = new Random();
int i=0;
int dif = 0;
Console.Write("We got array: ");
Console.Write("[");
    for (i = 0; i < array.Length; i++){
        array[i] = rand.Next(100);
        Console.Write(array[i]);
        if(i<7)Console.Write(", ");}
        Console.Write("] ");
int min = array[0];
int max = array[0];
    for (i=1;i<array.Length;i++){
        if(min>array[i]) min=array[i];}
    for (i=1;i<array.Length;i++){
        if(max<array[i]) max=array[i];}
dif=(max-min);
Console.WriteLine($"\nDifference between max and min is: {dif}");