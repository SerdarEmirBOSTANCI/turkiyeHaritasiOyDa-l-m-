using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class ikibinonyedisecim
    {
        [Key]
        public int ID { get; set; }
        public int? SehirID { get; set; }
        public virtual sehir Sehir { get; set; }
        public int Kayitlisecmen { get; set; }
        public int oylayaninsansayisi { get; set; }
        public int gecerlioysayisi { get; set; }
        public int gecersizoysayisi { get; set; }
        public int evetoysayisi { get; set; }
        public double evetoyorani { get; set; }
        public int hayiroysayisi { get; set; }
        public double hayiroyorani { get; set; }
        public double katilimorani { get; set; }
    }
}
