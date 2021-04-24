using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingNowDemo.BLL
{
    class OrderBLL
    {
        public int orderID { get; set; }
        public int productID { get; set; }
        public decimal totalPrice { get; set; }
        public decimal quantity { get; set; }
    }
}
