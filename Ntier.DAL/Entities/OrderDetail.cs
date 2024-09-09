using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.DAL.Entities
{
    public class OrderDetail: BaseClass
    {
         

        public string OrderID { get; set; }
        public int ProductID { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        //discount??
        public decimal Discount { get; set; }
    }
}
