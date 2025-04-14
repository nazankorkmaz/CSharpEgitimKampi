using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNKatman_EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDistinct { get; set; }
        public string CustomerCity { get; set; }
        
        public List<Order> Orders { get; set; } // yani sen orderla calisacaksin

        public bool CustomerStatus { get; set; }
    }
}
