using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groep9_SE7
{
    public class Travel_product
    {
        [Key]
        public int Trav_prod_ID { get; set; }
        public int Length { get; set; }
        public string Desciption { get; set; }
        public int Price { get; set; }
        public int Min_capacity { get; set; }
        public int Max_capacity { get; set; }
        public char Kids_Allowed { get; set; }
        
    }
}
