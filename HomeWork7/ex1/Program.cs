// See https://aka.ms/new-console-template for more information
int m;
int n;
Random rnd=new Random();
Console.WriteLine("Enter number of strings: ");
m=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of columns: ");
n=Convert.ToInt32(Console.ReadLine());

double[,] matrix=new double[m,n];
for(int i=0;i<m;i++){
    for(int j=0;j<n;j++){
        matrix[i,j]=rnd.Next(-100, 100)/10.0;
        Console.Write($"{matrix[i,j]} ");
    }
Console.WriteLine();}

    