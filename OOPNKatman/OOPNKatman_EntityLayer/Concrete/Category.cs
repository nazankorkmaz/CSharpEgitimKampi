using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNKatman_EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; } // bu sınıf ismi ve ID eklemek onun otomatik kendi artan ıd olarak algılıyormuş
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        
        // bu kategorideki urunler
        public List<Product> Products { get; set; }
    }
}
