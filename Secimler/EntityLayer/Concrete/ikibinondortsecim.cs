using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public class ikibinondortsecim
    {
        [Key]

        public int ID { get; set; }

        public int? SehirID { get; set; }
        public virtual sehir Sehir { get; set; }

        public  string SehirAd { get; set; }
        public double RTEaldiğioy { get; set; }
        public double RTEoyorani { get; set; }
        public double EIaldiğioy { get; set; }
        public double EIoyorani { get; set; }
        public double SDaldiğioy { get; set; }
        public double SDoyorani { get; set; }
        public double Toplamoy { get; set; }

    }
}
