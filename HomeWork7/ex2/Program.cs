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

int a;
int b;
Console.WriteLine("Enter number of string of element: ");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of column of element: ");
b=Convert.ToInt32(Console.ReadLine());
if(a<0||a>m||b<0||b>n) do{
    Console.WriteLine("Entered address doesn't exist. Try again.");
    Console.WriteLine("Enter number of string of element: ");
    a=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number of column of element: ");
    b=Convert.ToInt32(Console.ReadLine());}
while (a<m&&b<n||a<0&&b<0);
Console.WriteLine($"Your value is {matrix[(a-1),(b-1)]}");
