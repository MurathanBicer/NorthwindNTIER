using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.DAL.Entities
{
    public class CustomerCustomerDemo: BaseClass
    {
       
        public int CustomerID { get; set; }
        public int CustomerDemographicsID { get; set; }

        public Customer Customer { get; set; }
        public CustomerDemographics Customerdemographics { get; set; }
    }
}
