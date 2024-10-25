using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class denemeicin
    {
        [Key]
        public int ID { get; set; }
        public double Galatasaray { get; set; }
        public double FB { get; set; }
        public double BJK { get; set; }
        public double TS { get; set; }
    }
}
