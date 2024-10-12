using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            ////double number;
            ////number = 4.85;
            ////Console.WriteLine(number);

            //Console.WriteLine("*********Fiyat Listesi");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, patotoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patotoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----- Elma Birim Fiyatı: " + applePrice + "TL");
            //Console.WriteLine("----- Portakal Birim FFiyatı: " + orangePrice + "TL");
            //Console.WriteLine("----- Çilek Birim FFiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("----- Patates Birim FFiyatı: " + patotoPrice + "TL");
            //Console.WriteLine("----- Domates Birim FFiyatı: " + tomatoPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGraw, orangeGraw, strawberryGraw, potatoGraw, tomatoGraw;

            //appleGraw = 1.245;
            //orangeGraw = 2.658;
            //strawberryGraw = 0.750;
            //potatoGraw = 4.859;
            //tomatoGraw = 3.745;

            //double appleTotalPrice = appleGraw * applePrice;
            //double orangeTotalPrice = orangeGraw * orangePrice;
            //double strawberryTotalPrice = strawberryGraw * strawberryPrice;
            //double tomatoTotalPrice = tomatoGraw * tomatoPrice; 
            //double patotoTotalPrice = potatoGraw * patotoPrice;


            //Console.WriteLine("AlınaN Ürün: Elma" + "Birim Fiyat:" + applePrice + "- Gramaj: " + appleGraw+ " Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("AlınaN Ürün: Portakal" + "Birim Fiyat:" + orangePrice + "- Gramaj: " + orangeGraw + " Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("AlınaN Ürün: Çilek" + "Birim Fiyat:" + strawberryPrice + "- Gramaj: " + strawberryGraw + " Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("AlınaN Ürün: Domates" + "Birim Fiyat:" + tomatoPrice + "- Gramaj: " + tomatoGraw + " Toplam Tutar: " + tomatoTotalPrice);
            //Console.WriteLine("AlınaN Ürün: Patates" + "Birim Fiyat:" + patotoPrice + "- Gramaj: " + potatoGraw + " Toplam Tutar: " + patotoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + patotoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + "TL");
            //Console.Read();



            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            // TOPLANTI SAAT 20:00 'DE
            // " '

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("******** CSharp Hava Yolları Yolcu Bilgisi");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write(" Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("------------------------");
            //Console.WriteLine(" Yolcu TC kİMLİK No: " + passengerIdentityNumber +"Yolcu: " + passengerName + " " + passengerSurname + "" + passengerDistrict + "/" + passengerCity + "" + passengerAge);


            #endregion


            #region Klavyeden Tam Sayı Gitişleri ve Dönüşümler

            //ABC12D 

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığının ayakkabı sayısını giriniz: " );
            //shoesCount = int.Parse( Console.ReadLine() ); // #C bütün veri girişlerini string olarak alır

            //Console.Write("Lütfen aldığının bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığının sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığının televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine( "Toplam ödemeniz gereken tutar: ");



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen 1. sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Kalvyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());    

            Console.Write("Seçtiğiniz Cinsiyet: " + gender); // sadece bir karakter girişi

            #endregion


            Console.Read();

        }
    }
}
