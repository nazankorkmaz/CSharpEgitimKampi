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

            Console.WriteLine("****** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi ****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numrasını giriniz : ");
            string tableNumber = Console.ReadLine();

            Console.WriteLine("----------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=KORKMAZ\\SQLEXPRESS;Initial Catalog=EgitimKampiC#;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Category",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);  // c# komutlari ile sql arasında kopru gorevi yapar
            DataTable dataTable = new DataTable(); // verileri gecici ram bellege almayı saglayacak
            adapter.Fill(dataTable); // sqlden gelen verileri datatable a dolduruyoruz
            connection.Close(); // bağlantıyı kapatıyoruz

            foreach(var item in dataTable.Rows) // datatable içindeki satırları tek tek alıyoruz
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach(DataRow row in dataTable.Rows) // datatable içindeki satırları tek tek alıyoruz
            {
                foreach(var item in row.ItemArray) // satırdaki her bir elemanı alıyoruz
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
