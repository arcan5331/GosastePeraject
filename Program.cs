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
            var c = _5thForm(n, k);
            System.Console.WriteLine($"C = {c}");
            
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
        
        static Int64 _5thForm(int n,int k)
        {
            return Chose(n + k - 1,k - 1);
        }
        
        static Int64 _6thForm(int n,int k)
        {
            return Chose(n-1,k-1);
        }
        
    }

}
