using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi ****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("----------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("Siparişler");
            Console.WriteLine("Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarası: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("----------------------------");

            SqlConnection connection = new SqlConnection("Data Source= LAPTOP-CHH5M51E\\SQLEXPRESS; initial Catalog/*=EgitimKampiDb; integrated security=true"); //Bağlantıyı yazdık*/
            connection.Open(); //bağlantıyı açtık
            SqlCommand command = new SqlCommand("Select *From TablCotegory", connection); //hangi tablodan veri alacağımız belirtmek in connectionu yazdık
            SqlDataAdapter adapter = new SqlDataAdapter(command); //SQL ile C# kodum arasında köpri görevi görür
            DataTable dataTable = new DataTable(); // verileri geçici belleğe almayı sağlayacak
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
