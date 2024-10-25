using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class ikibinonsekizsecim
    {
        [Key]
        public int ID { get; set; }
        public int? SehirID { get; set; }
        public virtual sehir Sehir { get; set; }

        public string SehirAd { get; set; }
        public double RTE { get; set; }
        public double MI { get; set; }
        public double SD { get; set; }
        public double MA { get; set; }
        public double TK { get; set; }
        public double DP { get; set; }

    }
}
