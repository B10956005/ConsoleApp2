using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("請輸入數字");
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
             
            
            Console.Write("請輸入一個整數:");
            string user = Console.ReadLine();
            int num = Convert.ToInt32(user);

            int i, j;
            for(i = 1; i <= num; i++)
            {
                for (j = 0; j < i; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.WriteLine("-------------------");
            for(i = 1; i <= num; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + num * i);
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("九九乘法表");
            for (i = 1; i <=9; i++)
            {
                for(j=1;j<=9;j++)
                {
                    Console.WriteLine(i + "*" + j + "=" + i * j+"\t");
                }
                Console.WriteLine("");
            }
            */

            Console.WriteLine("練習");
            Console.WriteLine("輸入座號:");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] jack = { 80, 75, 60 };
            int[] mary = { 65, 67, 62 };
            int[] tom = { 100, 93, 91 };
            int[] grace = { 98, 25, 50 };
            int[] alice = { 83, 82, 87 };

            if (number==1)
            {
                Console.WriteLine("1.姓名:Jack \n 2.電腦概論:" + jack[0] + "\n 3.程式設計:" + jack[1] + "\n 4.動畫設計:" + jack[2]);
            }
            else if (number==2)
            {
                Console.WriteLine("1.姓名:Mary \n 2.電腦概論:" + mary[0] + "\n 3.程式設計:" + mary[1] + "\n 4.動畫設計:" + mary[2]);
            }
            else if (number == 3)
            {
                Console.WriteLine("1.姓名:Tom \n 2.電腦概論:" + tom[0] + "\n 3.程式設計:" + tom[1] + "\n 4.動畫設計:" + tom[2]);
            }
            else if (number == 4)
            {
                Console.WriteLine("1.姓名:Grace \n 2.電腦概論:" + grace[0] + "\n 3.程式設計:" + grace[1] + "\n 4.動畫設計:" + grace[2]);
            }
            else if (number == 5)
            {
                Console.WriteLine("1.姓名:Alice \n 2.電腦概論:" + alice[0] + "\n 3.程式設計:" + alice[1] + "\n 4.動畫設計:" + alice[2]);
            }
            else
            {
                Console.WriteLine("座號超出範圍");
            }
        }
    }
}
