// See https://aka.ms/new-console-template for more information  
int[] a = new int[5];
    do{
        for(int i=0; i<5; i++){
            Console.WriteLine("Enter 5-symbol number. {0} symbol: ", i+1);
            a[i] = Convert.ToInt32(Console.ReadLine());}
        if(a[0]!=a[4]&a[1]!=a[3]) Console.WriteLine("It's not palindrome :( Try again.");}
    while(a[0]!=a[4]&a[1]!=a[3]);
if(a[0]==a[4]&a[1]==a[3]) Console.WriteLine("You're Great! It's palyndrome.");