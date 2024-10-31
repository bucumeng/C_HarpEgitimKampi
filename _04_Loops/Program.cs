using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            int i;

            for (i = 0; i <= 5; i++)
            {
                Console.WriteLine("C# Harp Eğitim Kampı");
            }

            for (int m = 1; m <= 20; m++)
            {
                Console.WriteLine(m);
            }

            for (int n = 1; n <= 50; n += 3)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Lütfen ekrana yazılması gereken adedi yazınız: ");
            int finisValue = int.Parse(Console.ReadLine());

            for (int t = 1; t <= finisValue; t++)
            {
                Console.WriteLine("Yaşasın Cumhuriyet");
            }


            #endregion

            #region For Döngüsü ile karar yapıları

            for (int f = 1; f <= 100; f++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(f);
                }

            }

            int totalValue = 0;

            for (int s = 1; s <= 10; s++)
            {
                totalValue += i;
            }

            Console.WriteLine(totalValue);

            int totalValue_ = 0;

            for (int c = 1; c < 20; c++)
            {
                if (c % 2 == 0)
                {
                    totalValue_ += c;
                    Console.WriteLine(c);
                }
            }
            Console.WriteLine("---------");
            Console.WriteLine(totalValue_);

            int count = 0;

            for (int r = 1; r <= 50; r++)
            {
                if (r % 7 == 0)
                {
                    count++;
                }

            }

            Console.WriteLine(count);

            int bacterium = 1;

            for (int h = 1; h <= 24; h++)
            {
                bacterium *= 2;
                Console.WriteLine(h + ".Saat sonunda: " + bacterium);
            }

            #endregion

            #region While Döngüsü 
            int p = 1;

            while (p <= 10)
            {
                Console.WriteLine("Merhaba Döngüler");
                p++;
            }

            int j = 1;
            while (j <= 10)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }

            int k = 1;
            int sum = 0;

            while (k <= 10)
            {
                sum += k;
                k++;
            }
            Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum1;

            ones = number % 10;
            tens = number / 100;
            hundreds = (number % 100) / 10;

            Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            sum1 = ones + tens + hundreds;

            #endregion

            Console.Read();
        }
    }
}
