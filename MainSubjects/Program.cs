using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

// usingler yuklenen kutuphaneleri gosterir
// namespace projeye verilen isim
namespace MainSubjects
{
    internal class Program
    {
        static void Main(string[] args) // main methodu
        {
            #region Yazdirma komutlari
            Console.Write("Merhaba Dünya"); // method oldugunu solunda cıkan mor kupten anlarsin
            Console.Write("selam");
            //Console.Read();
            #endregion 
            // bu regionlari kapatabiliyorusn sagdaki ok ile.
            int deneme = 5;

            Console.WriteLine(); // deneme degiskenini yazdirir

            #region Girilen sayının basamakları toplamını yazdirma

            Console.WriteLine("Basamaklarının toplanmasını istediğiniz sayıyı giriniz: ");
            
            string sayi = Console.ReadLine();

            //  int sayi = int.Parse(Console.ReadLine());
            // console'dan veri almak ve onu strinten istenen ture donustrume islemi yapildi.

            int toplam = 0;
            Console.WriteLine("Sayı: " + sayi.GetType()); 

            
            for (int i = 0; i< sayi.Length; i++)
            {
                Console.WriteLine(sayi[i].GetType());
          
                toplam  = toplam + int.Parse(sayi[i].ToString());
            }
            Console.WriteLine(sayi +"'sının basamkları toplamı : "+toplam);


            #endregion



            #region Alt Alta yıldız oluşturma


            Console.WriteLine("Kaç satır yıldız oluşturmak istersiniz: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for(int j = 1; j<= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            #endregion


            #region Elmas cizdirme

            Console.WriteLine("Kaç satır elmas oluşturmak istersiniz: ");
            int elmas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= elmas; i++)
            {
                for(int j = 1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = elmas; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion


            #region Piramit oluşturma

            int pi = 5;

            for (int i = 1; i<= pi; i++)
            {
                for(int j= pi-i; j<0 ; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i -1 ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion







            Console.Read();

        }
    }
}
