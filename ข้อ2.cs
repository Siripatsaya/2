using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = a;
            int y = b;

            while (x < y || x > y)
            {
                if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            }
            if (x == y)
            {
                Console.Write("{0}", x);
            }
            else
            {
                Console.Write("");
            }
            Console.ReadLine();
        }
    }
}
