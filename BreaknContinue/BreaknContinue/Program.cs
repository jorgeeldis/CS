using System;

namespace BreaknContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num < 20)
            {
                if (num == 5)
                    break;

                Console.WriteLine(num);
                num++;
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;

                Console.WriteLine(i);
            }
        }
    }
}
