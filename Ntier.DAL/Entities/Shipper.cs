using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.DAL.Entities
{
    public class Shipper: BaseClass
    {
         
        public string CompayName { get; set; }
        public string Phone { get; set; }

        public List<Order> Orders { get; set; }
        //public Orders Orders { get; set; }
    }
}
