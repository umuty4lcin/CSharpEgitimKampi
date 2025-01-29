using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tableNumber;

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****\n");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış yap");
            Console.WriteLine("-------------------------------------\n");


            Console.Write("Lütfen yapmak istediğiniz işlem numarasını giriniz : ");

            
            SqlConnection connection = new SqlConnection("Data source = UMUT\\TEW_SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    Console.Write(row[column]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
