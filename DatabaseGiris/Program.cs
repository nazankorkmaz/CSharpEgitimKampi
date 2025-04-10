using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGiris
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ado.Net --> C#da sql sorguları kullanmayı sağlayan yapı

            #region Sql Baglantisi

            //Console.WriteLine("****** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi ****");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("1-Kategoriler");
            //Console.WriteLine("2-Ürünler");
            //Console.WriteLine("3-Siparişler");
            //Console.WriteLine("4-Çıkış Yap");
            //Console.WriteLine("Lütfen getirmek istediğiniz tablo numrasını giriniz : ");
            //string tableNumber = Console.ReadLine();

            //Console.WriteLine("----------------------------------------------");

            //SqlConnection connection = new SqlConnection("Data Source=KORKMAZ\\SQLEXPRESS;Initial Catalog=EgitimKampiC#;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From Category",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);  // c# komutlari ile sql arasında kopru gorevi yapar
            //DataTable dataTable = new DataTable(); // verileri gecici ram bellege almayı saglayacak
            //adapter.Fill(dataTable); // sqlden gelen verileri datatable a dolduruyoruz
            //connection.Close(); // bağlantıyı kapatıyoruz

            //foreach(var item in dataTable.Rows) // datatable içindeki satırları tek tek alıyoruz
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //foreach(DataRow row in dataTable.Rows) // datatable içindeki satırları tek tek alıyoruz
            //{
            //    foreach(var item in row.ItemArray) // satırdaki her bir elemanı alıyoruz
            //    {
            //        Console.Write(item.ToString());
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            //#region Kategori Ekleme

            //Console.WriteLine("Eklemek istediğiniz kategori adi: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection1 = new SqlConnection("Data Source=KORKMAZ\\SQLEXPRESS;Initial Catalog=EgitimKampiC#;Integrated Security=True");
            //connection1.Open();
            //SqlCommand command1 = new SqlCommand("Insert into Category (CategoryName) values (@categoryName)", connection1);
            //command1.Parameters.AddWithValue("@categoryName", categoryName); // sql komutuna parametre ekliyoruz
            //command1.ExecuteNonQuery(); // sql komutunu çalıştırıyoruz
            //connection1.Close(); // bağlantıyı kapatıyoruz
            //Console.WriteLine("Kategori eklendi.");
            //#endregion

            //#region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //Console.WriteLine("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.WriteLine("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());
            //SqlConnection connection2 = new SqlConnection("Data Source=KORKMAZ\\SQLEXPRESS;Initial Catalog=EgitimKampiC#;Integrated Security=True");
            //connection2.Open();

            //SqlCommand command2 = new SqlCommand("Insert into Product (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection2);
            //command2.Parameters.AddWithValue("@productName", productName);
            //command2.Parameters.AddWithValue("@productPrice", productPrice);
            //command2.Parameters.AddWithValue("@productStatus", true);
            //command2.ExecuteNonQuery(); // sql komutunu çalıştırıyoruz
            //connection2.Close(); // bağlantıyı kapatıyoruz
            //Console.WriteLine("Ürün eklendi.");
            //#endregion


            #region Ürün Listeleme İşlemi
            SqlConnection connection3 = new SqlConnection("Data Source=KORKMAZ\\SQLEXPRESS;Initial Catalog=EgitimKampiC#;Integrated Security=True");
            connection3.Open();
            SqlCommand command3 = new SqlCommand("Select * From Product", connection3);
            SqlDataAdapter adapter3 = new SqlDataAdapter(command3);  // c# komutlari ile sql arasında kopru gorevi yapar
            DataTable dataTable3 = new DataTable(); // verileri gecici ram bellege almayı saglayacak
            adapter3.Fill(dataTable3); // sqlden gelen verileri datatable a dolduruyoruz

            foreach(DataRow row in dataTable3.Rows) // datatable içindeki satırları tek tek alıyoruz
            {
                foreach (var item in row.ItemArray) // satırdaki her bir elemanı alıyoruz
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }
            connection3.Close(); // bağlantıyı kapatıyoruz

            #endregion

            #region Ürün Silme İşlemi

            Console.WriteLine("Silmek istediğiniz ürünün id numarasını giriniz: ");
            int productId = int.Parse(Console.ReadLine());

            SqlConnection connection4 = new SqlConnection("Data Source=KORKMAZ\\SQLEXPRESS;Initial Catalog=EgitimKampiC#;Integrated Security=True");
            connection4.Open();
            SqlCommand command4 = new SqlCommand("Delete From Product Where ProductId=@productId",connection4);
            command4.Parameters.AddWithValue("@productId", productId);
            command4.ExecuteNonQuery(); // sql komutunu çalıştırıyoruz
            connection4.Close(); // bağlantıyı kapatıyoruz
            Console.WriteLine("Ürün silindi.");

            #endregion

            #region Ürün Güncelleme İşlemi

            Console.WriteLine("Güncellenecek Ürün Id:");
            int productId2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Güncellenecek Ürün Adı:");
            string productName2 = Console.ReadLine();

            Console.WriteLine("Güncellenecek Ürün Fiyatı:");
            decimal productPrice2 = decimal.Parse(Console.ReadLine());

            SqlConnection connection5 = new SqlConnection("Data Source=KORKMAZ\\SQLEXPRESS;Initial Catalog=EgitimKampiC#;Integrated Security=True");
            connection5.Open();
            SqlCommand command5 = new SqlCommand("Update Product Set ProductName=@productName,ProductPrice=@productPrice Where ProductId=@productId", connection5);
            command5.Parameters.AddWithValue("@productId", productId2);
            command5.Parameters.AddWithValue("@productName", productName2);
            command5.Parameters.AddWithValue("@productPrice", productPrice2);
            command5.ExecuteNonQuery(); // sql komutunu çalıştırıyoruz
            connection5.Close(); // bağlantıyı kapatıyoruz
            Console.WriteLine("Ürün güncellendi.");
            #endregion


            Console.ReadLine();
        }
    }
}
