using System;

namespace q_no_53
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("(A)");
            int x=20,y=35;
            x= y++ + x++;
            y= ++y + ++x;
            Console.Write(x);
            Console.WriteLine(y);

            Console.WriteLine("(B)");
            int x1 = 10, y1 = 15;
            x1 = x1++;
            y1 = ++y1;
            Console.Write(x1);
            Console.Write(",");
            Console.WriteLine(y1);

            Console.WriteLine("(C)");
            int a = 10;
            a++;
            Console.WriteLine(a);

            Console.WriteLine("(D)");
            int a1 = 10;
            Console.WriteLine(a1++);

            Console.WriteLine("(E)");
            int n = 10;
            int x2 = 0;
            x2 = n--;
            Console.WriteLine(x2);

            Console.WriteLine("(F)");
            int i = 5, j = 6, k = 7, n1 = 3;
            Console.WriteLine(i + j * k - k % n1);
            Console.WriteLine(i / n1);

            Console.WriteLine("(G)");
            int n2;
            float x3 = 3.8f;
            n2 = Convert.ToInt32(x3);
            Console.Write("n=");
            Console.WriteLine(n2);

            Console.WriteLine("(H)");
            int a4 = 6;
            Console.Write(a4);
            a4 = a4 + 3;
            Console.Write(a4);
            a4 = 5;
            Console.Write(a4);
            a4++;
            Console.Write(a4);
        }
    }
}
