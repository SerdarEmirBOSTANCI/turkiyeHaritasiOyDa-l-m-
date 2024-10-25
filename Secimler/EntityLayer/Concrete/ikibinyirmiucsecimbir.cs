using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class ikibinyirmiucsecimbir
    {
        [Key]
        public int ID { get; set; }

        public int? SehirID { get; set; }
        public virtual sehir Sehir { get; set; }
        public string SehirAd { get; set; }
        public double RTE { get; set; }
        public double KK { get; set; }
        public double SO { get; set; }
        public double MI { get; set; }



    }
}
