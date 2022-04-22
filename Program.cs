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
            // homework1
            // Console.WriteLine("請輸入新台幣數值：");
            //string inputNewTaiwanDollar=Console.ReadLine();
            // decimal newTaiwanDollar=decimal.Parse(inputNewTaiwanDollar);
            // decimal dollar = newTaiwanDollar / 28;
            // Console.WriteLine($"對應的美金價值為：{dollar}");
            // Console.ReadLine();


            Console.WriteLine("請輸入新台幣數值：");
            string inputNewTaiwanDollar = Console.ReadLine();
            if (decimal.TryParse(inputNewTaiwanDollar, out decimal newTaiwanDollar) && newTaiwanDollar >= 0)
            {
                decimal dollar = newTaiwanDollar / 28;
                Console.WriteLine($"對應的美金價值為：{dollar}");
            }
            else
            {
                Console.WriteLine($"{inputNewTaiwanDollar} Is Invalid String");
            }


            Console.ReadLine();

            // homework2
            //Console.WriteLine("請輸入整數的華氏溫度值：");
            //string inputFahrenheit=Console.ReadLine();
            //double fahrenheit=double.Parse(inputFahrenheit);
            //double celsius = (fahrenheit - 32) * 5 / 9;
            //Console.WriteLine($"對應的攝氏溫度值為：{celsius}");
            //Console.ReadLine();




            Console.WriteLine("請輸入整數的華氏溫度值：");
            string inputFahrenheit = Console.ReadLine();

            if (double.TryParse(inputFahrenheit, out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                // Console.WriteLine($"對應的攝氏溫度值為：{celsius}"); 
                Console.WriteLine($"對應的攝氏溫度值為：{celsius.ToString("N2")}");
            }
            else
            {
                Console.WriteLine("Invalid String");
            }

            Console.ReadLine();

            // homework3
            //Console.WriteLine("請輸入整數：");
            //string inputNumber=Console.ReadLine();
            //int number=int.Parse(inputNumber);
            //int i = number %2;
            //if (i == 0)
            //{
            //    Console.WriteLine("是偶數");
            //}
            //else
            //{
            //    Console.WriteLine("是奇數");
            //}

            Console.WriteLine("請輸入整數：");
            string inputNumber = Console.ReadLine();

            //if (int.TryParse(inputNumber, out int number) && number % 2 == 0)
            //{
            //    Console.WriteLine("是偶數");
            //}
            //else if (Math.Abs(number % 2) == 1)
            //{
            //    Console.WriteLine("是奇數");
            //}
            //else
            //{
            //    Console.WriteLine($"{inputNumber} Is Invalid String");
            //}

            if (int.TryParse(inputNumber, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("是偶數");
                }
                else
                {
                    Console.WriteLine("是奇數");
                }
            }
            else
            {
                Console.WriteLine($"{inputNumber} Is Invalid String");
            }


            Console.ReadLine();


            // homework4

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
