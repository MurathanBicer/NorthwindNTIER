using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.DAL.Entities
{
    public class Order: BaseClass
    {
       
        public List<Customer> CustomerID { get; set; }
        public List<Employee> EmployeeID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequieredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public Shipper Shipper { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        //public List<Shippers> ShippersID { get; set; }
        public decimal? Freight { get; set; }//SqlMoney?
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode {get; set;}
        public string ShipCountry { get; set; }


    }
}
