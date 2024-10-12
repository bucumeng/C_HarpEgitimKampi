using System;

namespace _01_MainSubejects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.Write("Merhaba Dünya"); //İmleci en sağa getirir
            //Console.WriteLine("Selam") //imleci alt satıra indirir

            //Console.WriteLine("**** Yemek Tabirleri");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Salatalar");
            //Console.WriteLine("4-Soğuk Başlangıçlar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("**** Yemek Tabirleri");

            #endregion

            #region String Değişkenler

            ////string 
            ////Değişken_türü değişken_adi;

            ////string name;
            ////name = "Murat";
            ////Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = " Ali";
            //customerSurname = "Çınar";
            //customerEmail = "deneme@gmail.com";
            //customerPhone = "+9* 500 400 30 20";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("*** Rezervasyon Kartı");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + "" + customerSurname);
            //Console.WriteLine("İletişim" + customerPhone);
            //Console.WriteLine("Email Adresi" + customerEmail);
            //Console.WriteLine("Adres: " + district + "/ "+ city);
            //Console.WriteLine("-----------------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = " Kaya";
            //customerEmail = "ayse@gmail.comm";
            //customerPhone = "+90 400 500 80 70";
            //district = " Sapanca";
            //city = " Sakarya";

            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + "" + customerSurname);
            //Console.WriteLine("İletişim" + customerPhone);
            //Console.WriteLine("Email Adresi" + customerEmail);
            //Console.WriteLine("Adres: " + district + "/ " + city);
            //Console.WriteLine("-----------------------------------------");


            #endregion

            #region Int Degiskenler

            //int 
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonedePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı******");
            Console.WriteLine();
            Console.WriteLine("------Hmaburger: " + hamburgerPrice + "TL");
            Console.WriteLine("------Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("------Kola" + cokePrice + "TL");
            Console.WriteLine("------Limonata" + lemonedePrice + "TL");
            Console.WriteLine("------Kızartma" + friesPrice + "TL");
            Console.WriteLine("------Su: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı******");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemoneCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totallemonePrice = 0;
            int totalPrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemoneCount = 0;

            totalHamburgerPrice = hamburgerPrice + hamburgerCount;
            totalCokePrice = cokePrice + cokeCount;
            totalWaterPrice = waterPrice + waterCount;
            totallemonePrice = lemonedePrice + lemoneCount;
            totalFriesPrice = friesCount + friesPrice;
            totalPizzaPrice = pizzaPrice + pizzaCount;


            Console.WriteLine("----------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Limoanta: " + totallemonePrice + "TL");
            Console.WriteLine("Kızartma: " + totalFriesPrice + "  TL");
            Console.WriteLine("Su" + totalWaterPrice + "TL");

            totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totallemonePrice;
            Console.WriteLine();
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");

            #endregion


            Console.Read(); //Enter tuşuna basana kadar ekran bekletmeye yarar.



        }
    }
}

// Yazdırma Komutları 