using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            Console.WriteLine("Lütfen şifreyi giriniz: ");
            string password;
            password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Şifre Doğru");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış");
            }

            string capital, country;
            Console.WriteLine("Başkenti giriniz: ");
            capital = Console.ReadLine();

            Console.WriteLine("Ülkeyi giriniz: ");
            country = Console.ReadLine();

            if (capital == "ankara" & country == "türkiye")
            {
                Console.Write("Veriler doğrulandı");
            }
            else
            {
                Console.Write("Hatalı bilgi");
            }

            int number;
            Console.Write("Sayıyı giriniz: ");
            number = int.Parse(Console.ReadLine());

            if (number == 5)
            {
                Console.WriteLine("Sayı Doğru");
            }
            else
            {
                Console.WriteLine("Sayı Hatalı");
            }

            int exam1, exam2, exam3, average;
            string result = "";

            Console.Write("1. Sınavınızı giriniz");
            exam1 = int.Parse(Console.ReadLine());

            Console.Write("2. Sınavınızı giriniz");
            exam2 = int.Parse(Console.ReadLine());

            Console.Write("3. Sınavınızı giriniz");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 * exam2 + exam2) / 3;
            Console.WriteLine("Sınavların ortalaması: " + average);

            if (average > 0 & average <= 50)
            {
                result = "Sonuç vasat";
            }
            if (average > 50 & average <= 70)
            {
                result = "Sonuç orta";
            }
            if (average > 70 & average <= 84)
            {
                result = " Sonuç iyi";
            }
            if (average > 80)
            {
                result = "Sonuç çok iyi";
            }

            string city;
            Console.WriteLine("Şehir girişi yazınız: ");
            city = Console.ReadLine();

            if (city == "adana" | city == "bursa" | city == "ankara" | city == "trabzon")
            {
                Console.WriteLine("Şehir mevcut");
            }
            else
            {
                Console.WriteLine("Şehir mevcut değil");
            }

            Console.WriteLine("Lütfen kullanıcı adını giriniz: ");
            string username = Console.ReadLine();

            if (username != "admin")
            {
                Console.WriteLine("Kullanıcı adı kabul edilemez");
            }
            else
            {
                Console.WriteLine("Hoşgeldiniz");

            }

            #endregion

            #region Mod İşlemleri

            int number5;
            number5 = 26;
            int result1 = number % 5;
            Console.WriteLine(result);

            Console.WriteLine("Lütfen 1. Sayıyı giriniz: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz: ");
            int number2 = int.Parse(Console.ReadLine());

            int result2 = number1 % number2;

            Console.WriteLine("1. sayının 2. sayıya bölümünden kalan: " + result2);

            Console.Write("Lütfen sayıyı giriniz: ");
            int number_ = int.Parse(Console.ReadLine());

            if (number_ % 2 == 0)
            {
                Console.Write("Sayı Çifttir");
            }
            else
            {
                Console.Write("Sayı Tektir");
            }

            #endregion

            #region Char İşlemlerii
            char team;
            Console.Write("Lğtfen takım sembolünü giriniz: ");
            team = char.Parse(Console.ReadLine());

            if (team == 'f' | team == 'F')
            {
                Console.Write("Fenerbahçe");
            }
            if (team == 'g' | team == 'G')
            {
                Console.Write("Galatasaray");
            }
            if (team == 'b' | team == 'B')
            {
                Console.Write("Beşiktaş");
            }
            #endregion

            #region Örnek Proje Uygulaması
            Console.WriteLine("*****C# Eğitim Kampı Restoranı *******");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            string menuItem;

            Console.WriteLine("Detayını görmek istediğiniz menü seçimi: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("------------Ana Yemekler------------");
                Console.WriteLine();
                Console.WriteLine("1-Kori Soslu Tavuk");
                Console.WriteLine("2-Kızartma Tava ");
                Console.WriteLine("3-Fasulye Pilav");
                Console.WriteLine("4-Fırında Somon");
                Console.WriteLine("5-Patlıcan Mussaka");
                Console.WriteLine();
                Console.WriteLine("------------Ana Yemekler------------");

            }
            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("------------Çorbalar------------");
                Console.WriteLine();
                Console.WriteLine("1-Mercimek Çorbası");
                Console.WriteLine("2-Ezogelin Çorbası ");
                Console.WriteLine("------------Çorbalar------------");
                Console.WriteLine();

            }

            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("------------Pizzalar------------");
                Console.WriteLine();
                Console.WriteLine("1-Akdeniz Pizza");
                Console.WriteLine("2-Margarita Pizza");
                Console.WriteLine("2-Tavuklu Pizza");
                Console.WriteLine("------------Pizzalar------------");
                Console.WriteLine();
            }

            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("------------İçecekler------------");
                Console.WriteLine();
                Console.WriteLine("1-Kola");
                Console.WriteLine("2-Ayran");
                Console.WriteLine("3-Su");
                Console.WriteLine("------------İçecekler------------");
                Console.WriteLine();
            }

            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("------------Tatlılar------------");
                Console.WriteLine();
                Console.WriteLine("1-Triliçe");
                Console.WriteLine("2-Kazandibi");
                Console.WriteLine("3-Sütlaç");
                Console.WriteLine("------------Tatlılar------------");
                Console.WriteLine();
            }
            #endregion

            #region Switch Case

            Console.WriteLine("Lürfen ay girişi yapınız: ");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1: Console.WriteLine("Ocak"); break;
                case 2: Console.WriteLine("Şubat"); break;
                case 3: Console.WriteLine("Mart"); break;
                case 4: Console.WriteLine("Nisan"); break;
                case 5: Console.WriteLine("Mayıs"); break;
                case 6: Console.WriteLine("Haziran"); break;
                case 7: Console.WriteLine("Temmuz"); break;
                case 8: Console.WriteLine("Ağustos"); break;
                case 9: Console.WriteLine("Eylül"); break;
                case 10: Console.WriteLine("Ekim"); break;
                case 11: Console.WriteLine("Kasım"); break;
                case 12: Console.WriteLine("Aralık"); break;
                default: Console.WriteLine("Hatalı veri girişi"); break;

            }

            #endregion

            #region Switch Case Hesap Makinesi Uygulaması

            int number_1, number_2, result_1;
            char symbol;

            Console.Write("1. Sayıyı giriniz: ");
            number_1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayıyı giriniz");
            number_2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçininiz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result_1 = number_1 + number_2;
                    Console.WriteLine("Toplam: " + result);
                    break;
                case '-':
                    result_1 = number_1 - number_2;
                    Console.WriteLine("Çıkarma: " + result);
                    break;
                case '*':
                    result_1 = number_1 * number_2;
                    Console.WriteLine("Çarpma: " + result); break;
                case '/':
                    result_1 = number_1 / number_2;
                    Console.WriteLine("Bölüm: " + result);
                    break;

            }


            #endregion

            Console.Read();
        }
    }
}
