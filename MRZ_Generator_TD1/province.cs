using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRZ_Generator_TD1
{
    public class province
    {
        public string level1_id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public List<district> level2s { get; set; }
    }
}
