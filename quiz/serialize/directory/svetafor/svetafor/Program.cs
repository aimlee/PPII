using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace svetafor
{
    


    
    class Program
    {
        static int p = 0;
        public static void Svet()
        {
            

        string a = "*******\n********\n*******";

            ConsoleColor c1= ConsoleColor.Red;
            ConsoleColor c2 = ConsoleColor.Green;
            ConsoleColor c3 = ConsoleColor.Yellow;
            ConsoleColor c4 = ConsoleColor.White;
            while (true) {
                p++;
                Console.Clear();
                if (p % 3 == 0)
                {
                    Console.ForegroundColor = c1;
                    Console.WriteLine(a);
                    Console.ForegroundColor = c4;
                    Console.WriteLine(a);
                    Console.WriteLine(a);
                }
                if (p % 3 == 1)
                {

                    Console.WriteLine(a);
                    Console.ForegroundColor = c2;
                    Console.WriteLine(a);
                    Console.ForegroundColor = c4;
                    Console.WriteLine(a);
                }
                if (p % 3 == 2)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(a);
                    Console.ForegroundColor = c3;
                    Console.WriteLine(a);
                    Console.ForegroundColor = c4;

                }
                Thread.Sleep(1000);
            }
            
        }
        
        static void Main(string[] args)
        {
            Thread thread = new Thread(Svet);
            thread.Start();



        }
    }
}
