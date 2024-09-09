using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.DAL.Entities
{
    public class CustomerDemographics: BaseClass
    {
        
        public string CustomerDescription { get; set; }
        public List<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
         
    }
}
