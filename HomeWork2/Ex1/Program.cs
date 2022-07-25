// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter element numbers: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
int central = 0;
for(int i=0; i<n; i++){
    Console.WriteLine("Enter value of {0} elemnt: ", i+1);
    a[i] = Convert.ToInt32(Console.ReadLine());
}
central = n/2;
Console.WriteLine(a[central]);