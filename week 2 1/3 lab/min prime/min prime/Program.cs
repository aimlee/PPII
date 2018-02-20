using System;
using System.IO;
namespace lab2
{
    class MainClass
    {
        public static bool IsPrime(int a)
        {
            for (int i = 2; i * i <= a; i++)
            {
                if (a % i == 0)
                    return false;

            }
            return true;
        }

        public static void Main(string[] args)
        {
            int mini = -1, k = -1, p = 0;
            string line = File.ReadAllText(@"F:\c# labs\week 2\2 lab\qw.txt");
            string[] arr = line.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (int.Parse(arr[i]) >= 2)
                {
                    if (IsPrime(int.Parse(arr[i])) == true)
                    {
                        k = i;
                        mini = int.Parse(arr[i]);
                        break;
                    }
                }
            }
            if (k != -1 && mini != -1)
            {
                string l = " ";
                for (int i = k; i < arr.Length; i++)
                {
                    if (int.Parse(arr[i]) > 1)
                    {
                        if (IsPrime(int.Parse(arr[i])) == true && mini > int.Parse(arr[i]))
                        {
                            mini = int.Parse(arr[i]);
                            p = i;
                        }


                    }
                }
                l += arr[p];
                if (l.Length >= 2)
                {
                    File.WriteAllText(@"F:\c# labs\week 3\prime.txt", l);
                    Console.WriteLine(l);
                }
                Console.ReadKey();
            }

        }
    }
}