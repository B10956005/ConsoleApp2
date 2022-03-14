using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字");
            string s = Console.ReadLine();
            int x = int.Parse(s);
            if (x % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if(x >=2 && x<=5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (x >= 6 && x <= 20)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }

            Console.ReadLine();
        }
    }
}
