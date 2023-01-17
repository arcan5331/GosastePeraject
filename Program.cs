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

            var c = Chose(a, b);
            Console.WriteLine($"c = {c}\n");
        }

        static int Chose(int n, int k)
        {

            if (n == k || (k == 0))
            {
                return 1;
            } 
            else
            {
                return (Chose(n - 1, k - 1) + Chose(n - 1, k));
            }

        }

    }
}
