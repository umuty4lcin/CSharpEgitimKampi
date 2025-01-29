using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crude -> Create, Read, Update, Delete
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****\n");

            Console.WriteLine("-------------------------------------\n");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data source = UMUT\\TEW_SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;

            //Console.Write("Eklemek İstediğiniz Ürün Adı : ");
            //productName = Console.ReadLine();

            //Console.Write("Eklemek İstediğiniz Ürün Fiyatı : ");
            //productPrice = Convert.ToDecimal(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data source = UMUT\\TEW_SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT INTO TblProduct (ProductName,ProductPrice,ProductStatus) VALUES (@productName,@productPrice,@productStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün başarıyla eklendi.");


            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data source = UMUT\\TEW_SQLEXPRESS; initial catalog = EgitimKampiDb;integrated security = true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("SELECT * FROM TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //connection.Close();

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach (DataColumn column in dataTable.Columns)
            //    {
            //        Console.Write(row[column]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("\n");
            //}

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün ID : ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source = UMUT\\TEW_SQLEXPRESS; initial catalog = EgitimKampiDb;integrated security = true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("DELETE FROM TblProduct WHERE ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün başarıyla silindi.");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün ID : ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı : ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı : ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());
            

            //SqlConnection connection = new SqlConnection("Data source = UMUT\\TEW_SQLEXPRESS; initial catalog = EgitimKampiDb;integrated security = true");

            //connection.Open();
            
            //SqlCommand command = new SqlCommand("UPDATE TblProduct SET ProductName = @productName, ProductPrice = @productPrice WHERE ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);

            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün başarıyla güncellendi.");

            #endregion

            Console.Read();

        }
    }
}
