using System;

namespace GosastePeraject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two int.");
            var n = Convert.ToInt32(Console.ReadLine());
            var k = Convert.ToInt32(Console.ReadLine());
            var c = _4thForm(n, k);
            System.Console.WriteLine($"C = {c}");
            
        }

        static Int64 StirlingNumber(int n, int k)
        {
            Int64 output = 0;
            for (int i = 0; i < k; i++)
            {
                output += Convert.ToInt64(Math.Pow(k - i, n) * Math.Pow(-1, i));
            }
            Int64 temp = 1;
            for (int i = k; i > 0; i--)
            {
                temp *= i;
            }
            return output/temp;
        }

        static Int64 SecendForm(int n,int k)
        {
            Int64 output = 1;
            for (int i = k; i > 0; i--)
            {
                output *= i;
            }
            return output * StirlingNumber(n,k);
        }
        static Int64 ThirdForm(int n,int k)
        {
            return StirlingNumber(n,k);
        }

        static Int64 _4thForm(int n,int k)
        {
            Int64 output = 0;
            for (int i = 1; i <= k; i++)
            {
                output += StirlingNumber(n,i);
            }
            return output;
        }
    }


}
