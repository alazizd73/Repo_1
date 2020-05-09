using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groep9_SE7
{
    public class Travel_planned
    {
        [Key]
        public int Travel_plan_ID { get; set; }
        public DateTime Date_start { get; set; }
        public DateTime Date_end { get; set; }
        public int Travel_product { get; set; }
        public int Customer { get; set; }
    }
}
