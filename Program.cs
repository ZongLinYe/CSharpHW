using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===簡單版===");
            for(int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    int k = i * j;
                    Console.Write($"{i}*{j}={k}   ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("===排版好看版===");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    int k = i * j;
                    Console.Write($"{i}*{j}={k,-6}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("===轉個方向版===");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    int k = i * j;
                    //Console.Write($"{j}*{i}={k,-6}");
                    string printWord = $"{j}*{i}={k}";
                    printWord=printWord.PadRight(10);
                    Console.Write(printWord);

                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
