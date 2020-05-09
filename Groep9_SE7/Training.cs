using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groep9_SE7 {
    public class Training {

        public int ID { get; set; }
        public int? Emp_ID { get; set; }
        public int? Year { get; set; }
        public string Course { get; set; }

        public override string ToString()
        {
            return $"{Course} in {Year}";
        }
    }
}
