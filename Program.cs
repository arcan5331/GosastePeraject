using System;

namespace GosastePeraject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two int.");

            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            var c = C(a, b);
            Console.WriteLine($"c = {c}\n");
        }

        static int C(int n, int k)
        {

            if (n == k || (k == 0) || (n == 1 && k == 1) || (n == 0 && k == 0))
            {
                return 1;
            } 
            else
            {
                return (C(n - 1, k - 1) + C(n - 1, k));
            }

        }

    }
}
