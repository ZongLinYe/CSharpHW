using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220422BuildShoolHomework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // homework1
            Console.WriteLine("請輸入一個英文句子");
            string inputSentence=Console.ReadLine();
            string[] splitSentence=inputSentence.Split(' ');
            Console.WriteLine($"{inputSentence}  一共有 {splitSentence.Length} 個單字");
            Console.ReadLine();

            // homework2
            for(int i = 1; i <= 50; i++)
            {
                if(i%3==0 || i %5==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();

            // homework3
            Console.WriteLine("請輸入一串數字");
            string inputNumbers = Console.ReadLine();
            char[] splitNumbers = inputNumbers.ToCharArray();

            int[] statistics = new int[10];

            foreach (char number in splitNumbers)
            {
                int numberInt = int.Parse(number.ToString());

                for (int i = 0; i < statistics.Length; i++)
                {
                    if (numberInt == i)
                    {
                        statistics[i]++;
                        break;
                    }
                }

            }
            for (int i = 0; i < statistics.Length; i++)
            {
                Console.WriteLine($"數字 {i} 出現 {statistics[i]} 次");
            }

            Console.ReadLine();

            // homework4

            Console.WriteLine("請輸入數字(用,分隔):");
            string numberA=Console.ReadLine();
            string[]  numberB= numberA.Split(',');

            int[] toNumber= new int[numberB.Length];

            for(int i = 0; i < numberB.Length; i++)
            {
                toNumber[i] = int.Parse(numberB[i]);
            }

            Array.Sort(toNumber);
            Console.WriteLine("排序結果");

            foreach(int number in toNumber)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();

            // homework5

            Console.WriteLine("請輸入數字(用,分隔):");
            string numberC = Console.ReadLine();
            string[] numberD = numberC.Split(',');

            int[] toNumberE = new int[numberD.Length];

            for (int i = 0; i < numberD.Length; i++)
            {
                toNumberE[i] = int.Parse(numberD[i]);
            }

            Array.Sort(toNumberE);
            Array.Reverse(toNumberE);

            Console.WriteLine("排序結果");
            //foreach (int number in toNumberE)
            //{
            //    Console.Write(number);
            //}
            string[] toString1 = new string[toNumberE.Length];
            

            for (int i = 0; i < toNumberE.Length; i++)
            {
                toString1[i] = toNumberE[i].ToString();
            }
            string toString2 = string.Join(",", toString1);

            Console.WriteLine(toString2);
          
            Console.ReadLine();


        }
    }
}
