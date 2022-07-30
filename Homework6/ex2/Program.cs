// See https://aka.ms/new-console-template for more information
double k1;
double b1;
double k2;
double b2;
Console.WriteLine("Enter k1 value: ");
k1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter b1 value: ");
b1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter k2 value: ");
k2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter b2 value: ");
b2=Convert.ToInt32(Console.ReadLine());

double[] a=new double[2];

a[0]=Convert.ToDouble((-b2+b1)/(k2-k1));

a[1]=Convert.ToDouble((a[0]*k2+b2));

Console.WriteLine($"The intersection point is ({a[0]};{a[1]})");

// Очень плохо с математикой, не уверен, что помню правила переноса за равно
// но из того, что я вычитал в интернете, в дз неправильно указан ответ в примере, хотя я могу ошибаться.