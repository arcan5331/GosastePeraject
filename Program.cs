using System;

namespace GosastePeraject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Ball = false, Box = false, Empty = false;
            int n = 0, k = 0;
            Int64 ansr;
            Console.WriteLine("Are Balls Diferent (for true only Enter 'yes')(defult is false)");
            if (string.Equals(Console.ReadLine(), "yes"))
            {
                Ball = true;
            }
            Console.WriteLine("Are Boxes Diferent (for true only Enter 'yes')(defult is false)");
            if (string.Equals(Console.ReadLine(), "yes"))
            {
                Box = true;
            }
            Console.WriteLine("can Boxes Be Empty (for true only Enter 'yes')(defult is false)");
            if (string.Equals(Console.ReadLine(), "yes"))
            {
                Empty = true;
            }
            try
            {
                Console.WriteLine("Enter Balls count");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Boxes Count");
                k = Convert.ToInt32(Console.ReadLine());
                switch (FormChose(Ball, Box, Empty))
                {
                    case 0:
                        throw new NotImplementedException("0 From in not valid and there was an Err in FormChose Method!");
                    case 1:
                        ansr = FirstForm(n, k);
                        break;
                    case 2:
                        ansr = SecendForm(n, k);
                        break;
                    case 3:
                        ansr = ThirdForm(n, k);
                        break;
                    case 4:
                        ansr = _4thForm(n, k);
                        break;
                    case 5:
                        ansr = _5thForm(n, k);
                        break;
                    case 6:
                        ansr = _6thForm(n, k);
                        break;
                    case 7:
                        ansr = _7thForm(n, k);
                        break;
                    case 8:
                        ansr = _8thForm(n, k);
                        break;
                    default:
                        throw new NotImplementedException("no Form was Returd from FormChose Method!");
                }
                System.Console.WriteLine($"The Anser is {ansr}");
            }
            
            catch (NotImplementedException e) 
            {
                System.Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static int Combination(int n, int k)    // Combination k from n
        {

            if (n == k || (k == 0))
            {
                return 1;
            }
            else
            {
                return (Combination(n - 1, k - 1) + Combination(n - 1, k));
            }

        }

        static int Permutation(int n, int k)    // Permutation k from n
        {
            int temp = 1;
            for (int i = 0; i < k; i++)
            {
                temp *= i + 1;
            }
            return Combination(n, k) * temp;
        }

        static Int64 StirlingNumber(int n, int k)     // Stirling Number of n & k.
        {
            Int64 output = 0;
            Int64 Kfctor = 1;
            for (int i = 0; i < k; i++)
            {
                output += Convert.ToInt64(Math.Pow(k - i, n) * Math.Pow(-1, i));
                Kfctor *= (i + 1);                     // k!
            }
            
            return output / Kfctor;
        }
        static Int64 FirstForm(int n, int k)       // Balls are Diferent, Boxes are Diferent and can be Empty
        {
            return Convert.ToInt64(Math.Pow(k, n));
        }
        static Int64 SecendForm(int n, int k)     //  Balls are Diferent, Boxes are Diferent and can not be Empty
        {
            Int64 output = 1;
            for (int i = k; i > 0; i--)
            {
                output *= i;
            }
            return output * StirlingNumber(n, k);
        }

        static Int64 ThirdForm(int n, int k)      // Balls are Diferent, Boxes are not Diferent and can not be Empty
        {
            return StirlingNumber(n, k);
        }

        static Int64 _4thForm(int n, int k)       // Balls are Diferent, Boxes are not Diferent and can be Empty
        {
            Int64 output = 0;
            for (int i = 1; i <= k; i++)
            {
                output += StirlingNumber(n, i);
            }
            return output;
        }

        static Int64 _5thForm(int n, int k)       // Balls are not Diferent, Boxes are Diferent and can be Empty
        {
            return Combination(n + k - 1, k - 1);
        }

        static Int64 _6thForm(int n, int k)      // Balls are not Diferent, Boxes are Diferent and can not be Empty
        {
            return Combination(n - 1, k - 1);
        }

        static Int64 _7thForm(int n, int k)       // Balls are not Diferent, Boxes are not Diferent and can not be Empty
        {
            return Convert.ToInt64(Permutation(n, k));
        }

        static Int64 _8thForm(int n, int k)       // Balls are not Diferent, Boxes are not Diferent and can be Empty
        {
            Int64 output = 0;
            for (int i = 1; i <= k; i++)
            {
                output += Permutation(n, i);
            }
            return output;
        }

        static int FormChose(bool Ball, bool Box, bool Empty)
        {
            if (Ball && Box && Empty)
            {
                return 1;
            }
            else if (Ball && Box && !Empty)
            {
                return 2;
            }
            else if (Ball && !Box && !Empty)
            {
                return 3;
            }
            else if (Ball && !Box && Empty)
            {
                return 4;
            }
            else if (!Ball && Box && Empty)
            {
                return 5;
            }
            else if (!Ball && Box && !Empty)
            {
                return 6;
            }
            else if (!Ball && !Box && !Empty)
            {
                return 7;
            }
            else if (!Ball && !Box && Empty)
            {
                return 8;
            }
            return 0;
        }

    }

}
