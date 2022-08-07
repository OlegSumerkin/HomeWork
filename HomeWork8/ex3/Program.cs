// See https://aka.ms/new-console-template for more information
int m;
int n;
int a=0;
int b=0;
int el1=0;
int i=0;
int j=0;

Random rnd=new Random();
Console.WriteLine("Enter number of strings and rows of 1st matrix: ");
m=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of strings and rows of 2nd matrix: ");
n=Convert.ToInt32(Console.ReadLine());

int[,] matrix1=new int[m,m];
Console.WriteLine("The 1st matrix: ");
for(i=0;i<m;i++){
    for(j=0;j<m;j++){
        matrix1[i,j]=rnd.Next(1, 10);
        Console.Write($"{matrix1[i,j]} ");
    }
Console.WriteLine();}
Console.WriteLine();
Console.WriteLine("The 2nd matrix: ");
int[,] matrix2=new int[n,n];
for(i=0;i<m;i++){
    for(j=0;j<m;j++){
        matrix2[i,j]=rnd.Next(1, 10);
        Console.Write($"{matrix2[i,j]} ");
    }
Console.WriteLine();}
Console.WriteLine();
Console.WriteLine("The result matrix: ");
int[,] matrix3=new int[m,n];
for(a=0;a<m;a++){
    for(b=0;b<n;b++){
        matrix3[a,b]=el1;
        Console.Write($"{matrix3[a,b]} ");
        el1=0;
        i=0;
        j=0;
        do{
            el1+=matrix1[a,j]*matrix2[i,b];
            i++;
            j++;
        }while(i<m&&j<n);
    }

Console.WriteLine();}

// В общем, основная проблема в том, что я в упор не понимаю, как работает перемножение матриц. Я пытался понять эту формулу два дня
// но увы, в математике я 0. 
//Я даже смотрел решения в интернете, все равно ничего не понял. Можете снижать оценку, больше пробовать не буду. 
//P.S. прикрепил последнюю попытку.