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

            #region foreach  --> ama burada artım kuralı yok

            // 1: degisken turu
            // 2 degişken adı
            // 3: In
            // 4  Liste, koleksiyon,dizi

            string[] sehir2 = { "İstanbul", "Ankara", "İzmir", "Bursa" };
            foreach(string item in sehir2)
            {
                Console.WriteLine(item);
            }


            #endregion

            #region List

            List<int> numbers = new List<int>()
            {
                2,3,4,5,6
            };
            Console.WriteLine(numbers);  // bunu verir : System.Collections.Generic.List`1[System.Int32]
            numbers.Add(1);
            foreach(int item in numbers)
            {
                Console.WriteLine(item);
            }

            #endregion

            Console.Read();

        }
    }
}
