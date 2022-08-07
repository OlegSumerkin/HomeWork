int a;
int b;
int c;
int n=89;
int v;

Console.WriteLine("Enter length of x, y, z: ");
a=b=c=Convert.ToInt32(Console.ReadLine());

int[] rndNum=new int[90];
int[,,] matrix=new int[a,b,c];
Random rnd=new Random();
int number=10;
    for(int i=0;i<rndNum.Length;i++){
        rndNum[i]=number;
        number++;
        }
var tmp = new List<int>(rndNum);
for(int x=0;x<a;x++){
    for(int y=0;y<b;y++){
        for(int z=0;z<c;z++){
            v=rnd.Next(0,n);
            matrix[x,y,z]=tmp[v];
            tmp.RemoveAt(v);
            n--;
            Console.Write($"{matrix[x,y,z]} ({x},{y},{z}) ");
        }
    }
Console.WriteLine();}