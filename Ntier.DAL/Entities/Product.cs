using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.DAL.Entities
{
    public class Product: BaseClass
    {
        
        public string ProductName { get; set; }
        //supplier
        public Supplier Supplier { get; set; }
        public int SupplierID { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        //category
        public List<Categories> CategoriesID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitInStock {  get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

    }
}
