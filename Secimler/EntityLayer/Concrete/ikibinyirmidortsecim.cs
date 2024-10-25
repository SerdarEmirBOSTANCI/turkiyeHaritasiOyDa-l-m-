using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class ikibinyirmidortsecim
    {
        [Key]

        public int ID { get; set; }
        public int? SehirID { get; set; }
        public virtual sehir Sehir { get; set; }

        public string SehirAd { get; set; }
        public double AKP { get; set; }
        public double CHP { get; set; }
        public double MHP { get; set; }
        public double YRefah { get; set; }
        public double DP { get; set; }
        public double iyiparti { get; set; }
        public double BBP { get; set; }
        public double Bagimsiz { get; set; }
        public double Hudapar { get; set; }

    }
}
