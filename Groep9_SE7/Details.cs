using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groep9_SE7
{
    class Details
    {
        public DateTime Date_start { get; set; }
        public DateTime Date_end { get; set; }
        public string Location { get; set; }
        public List<Customer> customers { get; set; }
    }
}
