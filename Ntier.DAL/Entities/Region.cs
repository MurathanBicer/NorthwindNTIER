using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.DAL.Entities
{
    public class Region: BaseClass
    {
         
        public string RegionDescription { get; set; }
        public Territory Territories { get; set; }
    }
}
