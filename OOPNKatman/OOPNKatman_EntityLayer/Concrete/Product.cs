using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNKatman_EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductDescription { get; set; }
        
        // Producttan category tablosuna ve category ismine buradan erisilmesi iicn
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        // bunu kategori ile iliskilendirdik ama categoryı de haberdar etmemiz lazım
        
        public List<Order> Orders { get; set; }

        // bu CodeFirst classları olusturduktan sonra EntityFramework NuGetini yukluyoruz
        // sonra bu katmanlar birbirini referans etsin diye DataAccesLayera entity katmanını referans olrak verdik sağ tıktan
        // sonra da Presantationdanki App.confige giderek connectionStringi yazıp db ile bagladik
    }
}
