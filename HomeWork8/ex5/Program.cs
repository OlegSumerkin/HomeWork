// See https://aka.ms/new-console-template for more information
int m;
int n;
Random rnd=new Random();
Console.WriteLine("Enter number of strings and columns: ");
n=m=Convert.ToInt32(Console.ReadLine());

int[,] matrix=new int[m,n];
int a=m;
int b=n;
int c=0;
int d=0;
int value=1;
int i=0;
int j=0;
int mult=m*n;
while(value<=mult){
    for(i=c;i<=c;i++){
        for(j=d;j<a;j++){
            matrix[i,j]=value;
            value++;}}
    c++;
    for(j=a-1;j<a;j++){
        for(i=c;i<b;i++){
            matrix[i,j]=value;
            value++;}}
    a--;
    b--;
    for(i=b;i<=b;i++){
        for(j=a-1;j>=c;j--){
            matrix[i,j]=value;
            value++;}}

    for(j=d;j>=d;j--){
        for(i=a;i>=c;i--){
            matrix[i,j]=value;
            value++;}}
    d++;
}

for(i=0;i<m;i++){
    for(j=0;j<n;j++){
        if(matrix[i,j]<10){
            Console.Write($"0{matrix[i,j]} ");
        }
            else {
              Console.Write($"{matrix[i,j]} ");
        }}
Console.WriteLine();}