using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.DAL.Entities
{
    public class Categories: BaseClass
    {
        
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public Product Products { get; set; }
    }
}
