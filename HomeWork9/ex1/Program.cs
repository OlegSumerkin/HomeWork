// See https://aka.ms/new-console-template for more information
Console.Write("Enter number1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number2: ");
int m = Convert.ToInt32(Console.ReadLine());
if(n>m){
    int temp=n;
    n=m;
    m=temp;
}
Console.WriteLine("Result array: ");
int a=m-n+1;
int[] array=new int[a];
for(int i=0;i<array.Length;i++){
    array[i]=n;
    n++;
    if(i<array.Length-1) Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]}.");}