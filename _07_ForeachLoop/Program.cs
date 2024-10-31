using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            // Foreach(1;2;3;4)
            //1: Değişken Türü
            //2: Değişken adı
            //3: In
            //4: Liste , Koleksiyon, Dizi

            string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            foreach (string x in cities)
            {
                Console.WriteLine(x);
            }

            int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 285, 6578, 1038 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            int[] numbers1 = { 45, 78, 985, 74, 11, 22, 33, 41, 285, 6578, 1038 };

            foreach (int number in numbers1)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            int[] numbers2 = { 45, 78, 985, 74, 11, 22, 33, 41, 285, 6578, 1038 };
            int total = 0;

            foreach (int i in numbers2)
            {
                total += i;
            }

            List<int> numbers3 = new List<int>()
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8
            };
            foreach (int number in numbers3) // Liste sıralamak istersek foreach ı kullanabiliriz
            {
                Console.WriteLine(number);
            }

            string word = "Merhaba";

            foreach (char c in word)
            {
                Console.WriteLine(c);
            }



            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("******* C# Eğitim Kampı Örnek Sınav Sistemi Uygulaması *******");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{i + 1}. öğrencinin ismini giriniz");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // notları topluyoruz
                }
                Console.WriteLine();

                studentExamAvg[i] = totalExamResult / 3;
            }

            //Sıınav Ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: + {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumları 
                if (studentExamAvg[i] >= 56)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci derten kaldı.");
                }

                Console.WriteLine(----------------------------------------------);


            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******* C# Eğitim Kampı Örnek Sınav Sistemi Uygulaması *******");
            #endregion
            Console.Read();
        }
    }
}
