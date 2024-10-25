using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class sehir
    {
        [Key]
        public int SehirID { get; set; }
        public string SehirAd { get; set; }
        public ICollection<ikibinonyedisecim> ikibinonyedisecims { get; set; }
    }
}
