using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRZ_Generator_TD1
{
    public class district
    {
        public string level2_id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public List<ward> level3s { get; set; }
    }
}
