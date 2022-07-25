// See https://aka.ms/new-console-template for more information
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(" | ");
for(int i=1; i<number; i++){
    if(i%2==0){
        Console.Write(i);
        Console.Write(" | ");
    }
}