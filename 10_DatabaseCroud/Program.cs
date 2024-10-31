using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCroud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kategori Ekleme İşlemi
            //Crud--!Create-Read-Update-Delete

            Console.WriteLine("***** Menü İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("------------------------------");
            Console.WriteLine("Eklemek İstediğiniz Kategori Adı: ");
            string categoryName = Console.ReadLine();
            
            SqlConnection connection = new SqlConnection("Data Source =  LAPTOP-CHH5M51E\\SQLEXPRESS; initial catalog =EgitimKampiDb; integrated security=true");
            
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            command.Parameters.AddWithValue("@p1", categoryName); //sql tablosuna kategori ekledik
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Kategori başarı ile eklendi");
            #endregion

            #region Ürün Ekleme İşlemi

            string productName;
            decimal productPrice;
            //bool productStatus;

            Console.WriteLine("Eklemek istediğiniz ürün adı: ");
            productName = Console.ReadLine();
            Console.WriteLine("Ürün Fiyatı: ");
            productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection1 = new SqlConnection("Data source =  LAPTOP-CHH5M51E\\SQLEXPRESS; initial catalog =EgitimKampiDb; integrated security=true");
            SqlCommand command1 = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection1);
            command1.Parameters.AddWithValue("@productName", productName);
            command1.Parameters.AddWithValue("productPrice", productPrice);
            command1.Parameters.AddWithValue("productStatus", true);
            command1.ExecuteNonQuery(); //değişiklikleri kaydet ve veri tabanına yansıt
            connection1.Close();
            Console.WriteLine("Ürün eklemesi başarılı");



            #endregion

            #region Ürün Listeleme İşlemi

            SqlConnection connection2 = new SqlConnection("Data source =  LAPTOP-CHH5M51E\\SQLEXPRESS; initial catalog =EgitimKampiDb; integrated security=true");

            connection2.Open(); 
            SqlCommand command2 = new SqlCommand("Select * From TblProduct", connection2);
            SqlDataAdapter adapter = new SqlDataAdapter(command2);
            DataTable dataTable = new DataTable(); // bellekte bir tablonun tutulmasını sağladık
            adapter.Fill(dataTable); // burda veriler mevcut

            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray) // ilgili satırların sutünların içini girmiş olacağız
                {
                    Console.WriteLine(item.ToString() +" ");
                }
                Console.WriteLine();
            }

            connection2.Close();

            #endregion

            #region Ürün silme işlemi

            Console.Write("Silinecek ürün Id girin: ");
            int productId = int.Parse(Console.ReadLine());  

            SqlConnection connection3 = new SqlConnection("Data source =  LAPTOP-CHH5M51E\\SQLEXPRESS; initial catalog =EgitimKampiDb; integrated security=true");

            connection3.Open();

            SqlCommand command3 = new SqlCommand("Delete From TblProdudct Where ProductId=@productId" , connection3);
            command3.Parameters.AddWithValue("@productId",productId);
            command.ExecuteNonQuery();

            Console.WriteLine("Silme işlemi gerçekleşti");

            connection3.Close();

            #endregion

            #region Ürün Güncelleme İşlemi

            Console.WriteLine("Güncellenecek Ürün Id: ");
            int productId1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Güncellencek Ürün Adı: ");
            string productName1 = Console.ReadLine();
            
            Console.WriteLine("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice1 = decimal.Parse(Console.ReadLine());

            SqlConnection connection4 = new SqlConnection("Data source =  LAPTOP-CHH5M51E\\SQLEXPRESS; initial catalog =EgitimKampiDb; integrated security=true");

            connection4.Open();
            SqlCommand command4 = new SqlCommand("USet Prodpdate TblProduct Set ProductName=@productName , ProductPrice=@productPrice where ProductId =@productId", connection);
            command4.Parameters.AddWithValue("@productName", productName1);
            command4.Parameters.AddWithValue("@productPrice", productPrice1);
            command4.Parameters.AddWithValue("@productId", productId1);
            command4.ExecuteNonQuery();

            Console.WriteLine("Güncelleme başarılı");

            connection4.Close();

            #endregion

            Console.Read();
        }
    }
}
