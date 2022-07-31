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
        matrix[i,j]=rnd.Next(0, 10);
        Console.Write($"{matrix[i,j]} ");
    }
Console.WriteLine();}

for(int j=0;j<m;j++){
    double avg = 0.0;
    for(int i=0;i<n;i++){
        avg = avg + matrix[i,j];}
    Console.WriteLine($"Average of {j+1} column is: {avg/m}");}
       
