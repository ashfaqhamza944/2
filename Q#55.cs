using System;

namespace q_no_55
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 4;
a =++a;
b =b++;

//(a)
Console.WriteLine("a");
Console.WriteLine(a*b);

//(b)
//If we replace ++a = b++ by 
int a1 = 3, b1 = 4;
b1 = ++b1;
a1 =++a1;
Console.WriteLine("b");
Console.WriteLine(a1*b1);

//(c)
Console.WriteLine("c");
a = a + 1;
b = b + 1;
Console.WriteLine(a*b)
        }
    }
}
