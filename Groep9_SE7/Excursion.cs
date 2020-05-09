using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groep9_SE7 {
   public class Excursion {
        [Key]
        public int Exc_ID { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
