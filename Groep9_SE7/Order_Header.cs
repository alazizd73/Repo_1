using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groep9_SE7
{
    public class Order_Header
    {
        [Key]
        public int Order_number { get; set; }
        public DateTime Order_date { get; set; }
        public string Region { get; set; }
        public int Emp_ID { get; set; }
        public int? Dept_ID { get; set; }
        public int Cust_ID { get; set; }
        public int? Order_method { get; set; }
       
    }
}
