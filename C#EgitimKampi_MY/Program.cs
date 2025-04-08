using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EgitimKampi_MY
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Diziler

            // Degisken turu [] DiziAdi = new DegiskenTuru[Eleman sayisi];
            string[] dizi1 = new string[5];
            dizi1[0] = "İstanbul";
            Console.WriteLine(dizi1[0]);
            Console.WriteLine(dizi1[1]);  // hata vermnedi cunku null atandi.
            //dizi1[5] = "hata verir";

            //---------
            int[] dizi2 = new int[5];
            Console.WriteLine(dizi2[0]);// 0 verdi cunku int dizilerinde default olarak 0 atar.
            Console.WriteLine("");

            // ------
            string[] dizi3 = { "istanbul", "ankara" };

            int [] dizi4 =  new int[]{ 1, 2, 3, 4, 5 };
            Console.WriteLine(dizi4.Length + " dizinin boyutu"+"\n");
            Array.Sort(dizi4); // diziyi sıralar

            for (int i = 0; i < dizi4.Length; i++)
            {
                Console.WriteLine(dizi4[i]);
            }
            Console.WriteLine(" ");

            Array.Reverse(dizi4); // diziyi tersten sıralar

            for (int i = 0; i < dizi4.Length; i++)
            {
                Console.WriteLine(dizi4[i]);
            }

            string[] customers = { "Ali", "Ayşe", "Mehmed", "Sümbül", "Kaya" };
            int index = Array.IndexOf(customers, "Mehmed");
            Console.WriteLine(index); // 2

            //dizi.Max()
            #endregion

            #region Kullanıcıdan Veri alma

            string[] sehir = new string[5];
            for ( int i = 0; i < sehir.Length; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. şehri giriniz: ");
                sehir[i] = Console.ReadLine();
            }

            for (int i = 0; i < sehir.Length; i++)
            {
                Console.WriteLine(sehir[i]);
            }

            #endregion


            Console.Read();

        }
    }
}
