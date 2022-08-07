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
int a=m-n+1;
int[] array=new int[a];
for(int i=0;i<array.Length;i++){
    array[i]=n;
    n++;}
int sum=0;
for(int i=0;i<array.Length;i++){
    sum+=array[i];
}
Console.WriteLine($"Summ of all numbers between {m-a+1} and {m} is: {sum}");