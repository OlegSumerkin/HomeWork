// See https://aka.ms/new-console-template for more information
int[] array = new int[8];
Random rand = new Random();
int summ=0;
Console.Write("We got array: ");
Console.Write("[");
    for (int i = 0; i < 8; i++){
        array[i] = rand.Next(100, 999);
        Console.Write(array[i]);
        if(i<7)Console.Write(", ");}
        Console.Write("] ");
            for(int i=1;i<array.Length;i=i+2){
                summ=summ+array[i];}
Console.WriteLine($"\nThe summ of values of odd indexes is: {summ}");