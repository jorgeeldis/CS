using System;

namespace AssignmentOp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 42;
            int y = 10;
            int z = 3;
            int v = ++z;
            int w = z++;
            x += 2;
            x -= 6;
            x *= 8;
            x /= 5;
            x %= 2;
            y++;
            Console.WriteLine(y);
            Console.WriteLine(v);
            Console.WriteLine(w);
        }
    }
}
