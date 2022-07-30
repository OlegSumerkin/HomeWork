// See https://aka.ms/new-console-template for more information
int n;
int count = 0;
Console.WriteLine("Enter number of array elements: ");
n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
    for(int i=0; i<array.Length; i++){
        Console.WriteLine($"Please enter the {i+1} number: ");
        array[i]=Convert.ToInt32(Console.ReadLine());
        if(array[i]>0) count = count+1;}
Console.Write("We got array: [");
    for (int i=0; i<array.Length; i++){
        Console.Write(array[i]);
        if(i<array.Length-1) Console.Write(", ");
        if(i==array.Length-1) Console.Write("]");}
Console.WriteLine($"\nUser entered {count} number(s) > 0.");