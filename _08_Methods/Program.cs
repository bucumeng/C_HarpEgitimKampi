using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar 
            void CustomerList()
            {
                Console.WriteLine("Ali Yıldız");
                Console.WriteLine("Ayşe Yıldız");
                Console.WriteLine("Hakan Öztürk");
                Console.WriteLine("Merve Çınar");
            }
            CustomerList();

            void Sum()
            {
                int number5 = 1;
                int number6 = 2;
                int number7 = number5 + number6;
            }
            Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametli Metotlar

            void WriteMethod(string customerName)
            {
                Console.WriteLine(customerName);
            }
            WriteMethod("Mehmet Yıldırım");

            void CustomerCard(string name, string surName)
            {
                Console.WriteLine("Müşteri: " + name + " " + surName);
            }

            CustomerCard("Mehmet", "Yıldız");
            CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametli Metotlar

            void SumNumbers(int number1, int number2, int number3)
            {
                int result = number1 + number2 + number3;
                Console.WriteLine(result);
            }

            SumNumbers(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            string BuyerName()
            {
                return "Buse Yıldız";
            }
            BuyerName();

            string StudentCard()
            {
                string name = "Ali";
                string surname = "Kaya";

                return name + "" + surname;

            }
            Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren String Parametli Metotlar

            string CountryCard(string countryName, string capital, string flagColor)
            {
                string cardInfo = "Ülke: " + countryName + "Başkent: " + capital + "Bayrak: " + flagColor;
                return cardInfo;
            }

            string x, y, z;
            Console.WriteLine("Ülke Adını Giriniz: ");
            x = Console.ReadLine();

            Console.WriteLine("Başkent Adını Giriniz: ");
            y = Console.ReadLine();

            Console.WriteLine("Bayrak Rengini Giriniz: ");
            z = Console.ReadLine();

            Console.WriteLine(x, y, z);

            Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmız-Beyaz"));

            #endregion

            #region Geriye Değer Döndürem Int Parametli Metotlar

            int SumNumber(int number3, int number4)
            {
                int result = number3 + number4;
                return result;
            }

            Console.WriteLine(SumNumber(45, 98));
            Console.WriteLine(SumNumber(36, 25));
            Console.WriteLine(SumNumber(44, 36));
            Console.WriteLine(SumNumber(14, 98));



            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + "Öğrenci sınavı geçti" + "Ortalama: " + result;
                }
                else
                {
                    return student + "Öğrenci sınavı geçti" + "Ortalama: " + result;
                }
            }
            Console.WriteLine("Ali", 25, 41, 55);
            Console.WriteLine("Ayşe", 36, 88, 33);

            #endregion

            Console.Read();
        }
    }
}
