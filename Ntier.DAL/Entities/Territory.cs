using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.DAL.Entities
{
    public class Territory:BaseClass
    {
         
        public string TerritoryDescription { get; set; }
        public List<Region> Regions { get; set; }
    }
}
