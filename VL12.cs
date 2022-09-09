using System;

namespace DK05
{
    class Program
    {

        static void Main(string[] args)
        {

            String s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            if (n == 0) Console.WriteLine("INF");
            else
            {
                for (int i = Math.Abs(n); i > 0; i--)
                    if (i > 1)
                    {
                        if (n % i == 0) Console.Write("{0} ", i);
                    }
                Console.Write("1");
            }
        }
    }
}
