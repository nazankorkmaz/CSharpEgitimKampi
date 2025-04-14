using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNKatman_EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        // 1- 246-1adet-100tl -100Tl - 3685 Nolu Musteri

        public int Quantity { get; set; } // adet
        public decimal UnitPrice { get; set; } // fiyat
        public decimal TotalPrice { get; set; } // toplam fiyat
        
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
