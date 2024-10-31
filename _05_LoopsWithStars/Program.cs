using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma 

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("*");
            }

            #endregion

            #region Yan yana 10 tane yıldız oluşturma 

            for (int k = 1; k <= 10; k++)
            {
                Console.Write("*");
            }

            #endregion

            #region Alt alta her satırda 10 tane yıldız oluşturma

            for (int m = 1; m <= 10; m++)
            {
                Console.Write("**********");
            }

            #endregion

            #region Dik üçgen oluşturma

            for (int t = 1; t <= 5; t++)
            {
                for (int r = 1; r <= t; r++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region  Ters Üçgen Oluşturma

            for (int s = 5; s >= 1; s--)
            {
                for (int a = 1; a <= s; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region  Ters ve Dik Üçgen Beraber

            for (int y = 5; y <= 5; y++)
            {
                for (int b = 1; b <= y; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int s = 4; s >= 1; s--)
            {
                for (int a = 1; a <= s; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region  Baklava Dilimi

            int z = 5;
            for (int x = 1; x <= z; z++)
            {
                for (int y = z - 1; y > 0; y--)
                {
                    Console.Write(" ");
                }
                for (int q = 1; q <= 2 * x - 1; q++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }

            for (int x = z - 1; x >= 1; x--)
            {
                for (int y = z - 1; y >= 0; y--)
                {
                    Console.Write(" ");
                }

                for (int q = 1; q <= 2 * x - 1; q++)
                {
                    Console.WriteLine("*");
                }
            }

            #endregion

            #region  Piramit 

            int d = 5;

            for (int x = 1; x <= d; x++)
            {
                //boşluklar
                for (int y = d - 1; y >= 0; y--)
                {
                    Console.Write(" ");
                }

                //yıldızlar
                for (int q = 1; q <= 2 * x - 1; q++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region  Ters Piramit 

            int u = 5;

            for (int x = u; x >= 1; x--)
            {
                //boşluklar
                for (int y = u - x; y >= 0; y--)
                {
                    Console.Write(" ");
                }

                //yıldızlar
                for (int q = 1; q <= 2 * x - 1; q++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            Console.Read();

        }
    }
}
