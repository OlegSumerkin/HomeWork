// See https://aka.ms/new-console-template for more information
int m;
int n;
Random rnd=new Random();
Console.WriteLine("Enter number of strings: ");
m=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of columns: ");
n=Convert.ToInt32(Console.ReadLine());

int[] array=new int[m];
int[,] matrix=new int[m,n];
for(int i=0;i<m;i++){
    int sum=0;
    for(int j=0;j<n;j++){
        matrix[i,j]=rnd.Next(0, 10);
        Console.Write($"{matrix[i,j]} ");
        sum=sum+matrix[i,j];
        if(j==n-1) array[i]=sum;
    }
Console.WriteLine();}

int min=array[0];
for(int i=1;i<m;i++){
    if(min>array[i]) min = array[i];}
Console.WriteLine($"The minimal summ of all elements of each string is {min} and thats summ of all elements of {Array.IndexOf(array, min)+1} string.");