// See https://aka.ms/new-console-template for more information
int[] r1 = new int[3];
for(int i=0; i<3; i++){
    Console.WriteLine("Enter value of {0} point of coordinates for r1: ", i+1);
    r1[i] = Convert.ToInt32(Console.ReadLine());}
int[] r2 = new int[3];
for(int i=0; i<3; i++){
    Console.WriteLine("Enter value of {0} point of coordinates for r2: ", i+1);
    r2[i] = Convert.ToInt32(Console.ReadLine());}
double distance = Math.Sqrt(Math.Pow(r1[0]-r2[0], 2)+Math.Pow(r1[1]-r2[1], 2)+Math.Pow(r1[2]-r2[2], 2));
Console.Write("Distance = ");
Console.Write(distance);