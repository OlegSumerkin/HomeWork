// See https://aka.ms/new-console-template for more information
int m;
int n;
Random rnd=new Random();
Console.WriteLine("Enter number of strings: ");
m=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of columns: ");
n=Convert.ToInt32(Console.ReadLine());

int[,] matrix=new int[m,n];
for(int i=0;i<m;i++){
    for(int j=0;j<n;j++){
        matrix[i,j]=rnd.Next(0, 10);
        Console.Write($"{matrix[i,j]} ");
    }
Console.WriteLine();}
int temp;
    for(int i=0;i<m;i++){
        for(int j=0;j<n;j++){
            for(int k=j+1;k<n;k++){
                if(matrix[i,j]<matrix[i,k]){
                    temp=matrix[i,j];
                    matrix[i,j]=matrix[i,k];
                    matrix[i,k]=temp;
                }
            }
        }
    }
Console.WriteLine("Sorted matrix: ");
for(int i=0;i<m;i++){
    for(int j=0;j<n;j++){
        Console.Write($"{matrix[i,j]} ");
    }
Console.WriteLine();}
