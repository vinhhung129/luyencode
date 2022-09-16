using System;
 namespace sumdiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.Readline());
            int[] a = new int[t + 1];
            int t1 = t;
            while (t>0)
            {
                a[t] = Convert.ToInt32(Console.ReadLine());
                t--;
            }
            while (t1 > 0)
            {
                Console.WriteLine("{0}", sumdiv(a[t1]));
                t1--;
            }    
    
        }
        static int sumdiv(int x)
        {
            int sum = 0;
            for(int i=1; i <= Math.Round(Math.Sqrt(x)); i++)
            {
                if ((x % i == 0) && (i * i != x)) sum = sum + i + x / i;
                if ((x % i == 0) && (i * i == x)) sum = sum + i;
            }
            return sum;

        }

    }
}
