using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            // 2.4.6.8
            //adana, ankara, istanbul, bursa
            // Değişken türü [] DiziAdı = new Değişken Türü[ElemanSayısı]

            string[] colors = new string[4];
            colors[0] = "Kırmızı";
            colors[1] = "Sarı";
            colors[2] = "Beyaz";
            colors[3] = "Mavi";

            Console.WriteLine(colors[2]);

            string[] cities = new string[5];

            cities[0] = "Milano";
            cities[1] = "Budapeşte";
            cities[2] = "Lyon";
            cities[3] = "Kahire";
            cities[4] = "Üsküp";

            Console.WriteLine(cities[5]); // Bunu çağıramazsın çünkü bu bileşen yok

            int[] numbers = new int[10];

            numbers[0] = 50;
            numbers[1] = 40;
            numbers[2] = 698;
            numbers[3] = 24;
            numbers[7] = 748;

            Console.WriteLine(numbers[5]); // indexe değer ataması yapmazsam default değeri döndürür

            string[] cities1 = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            Console.WriteLine(cities1[2]);




            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            string[] colors1 = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }

            int[] numbers1 = { 4, 85, 96, 74, 125, 635, 488, 7456, 2365, 1120 };

            for (int i = 0; i < numbers1.Length; i++)
            {
                if (numbers1[i] % 3 == 0)
                {
                    Console.WriteLine(numbers1[i]);
                }
            }

            char[] symbols = { 'A', 'b', 'c', 'd', '+', '/', '-' };
            for (int i = 0; i < symbols.Length; i++)
            {
                Console.WriteLine(symbols[i]);
            }

            int[] myArray = { 4, 85, 96, 74, 125, 635, 488, 7456, 2365, 1120 };

            int maxNUmber = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNUmber)
                {
                    maxNUmber = myArray[i];
                }
            }

            Console.WriteLine(maxNUmber);

            string[] persons = { "ali", "ahmet", "ayşe", "cem", "deniz" };
            Console.WriteLine(persons.Length);

            int[] numbers2 = { 4, 85, 53, 41, 86, 10, 22, 35 };
            Array.Sort(numbers2); // Küçükten büyüğe doğru sıralama
            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }

            int[] numbers3 = { 4, 85, 53, 41, 86, 10, 22, 35 };
            Array.Reverse(numbers3); //tersten sıralama
            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers3[i]);
            }

            #endregion

            #region Dizi Metotlar

            string[] customers = { "ali", "buse", "ayeşgül", "merve", "çınar", "kaya" };
            int index = Array.IndexOf(customers, "merve"); //  index değeri döndürme

            int[] numbers4 = { 4, 85, 53, 41, 86, 10, 22, 35 };
            Console.WriteLine("Dizideki En Büyük Elemean: " + numbers.Max() + "Dizinin En Küçük Elemanı: " + numbers.Min());



            #endregion

            #region Kullanıcıdan Değer Alma 

            string[] cities3 = new string[5];

            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"Lütfen {i + 1}. Şehrini Giriniz: ");
                cities3[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------");

            for (int i = 0; i < cities3.Length; i++)
            {
                Console.WriteLine(cities3[i]);
            }

            int[] numbers5 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine("Çift Sayılar");

            for (int i = 0; i < numbers5.Length; i++)
            {
                if (numbers5[i] % 2 == 0)
                {
                    Console.WriteLine(numbers5[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("-------------------");

            Console.WriteLine("Tek Sayılar");

            for (int i = 0; i < numbers5.Length; i++)
            {
                if (numbers5[i] % 2 == 1)
                {
                    Console.WriteLine(numbers5[i]);
                }
            }

            #endregion

            Console.Read();

        }
    }
}
