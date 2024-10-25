using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Secimler.Controllers
{
    public class ikibinondortsecimController : Controller
    {

        ikibinondortsecimBl secim = new ikibinondortsecimBl(new EfikibinondortsecimDal());
        Context c = new Context();

        public IActionResult Index()
        {
            ViewBag.hakkari = c.İkibinondortsecims.Where(x => x.SehirID == 30).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.adana = c.İkibinondortsecims.Where(x => x.SehirID == 1).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.adiyaman = c.İkibinondortsecims.Where(x => x.SehirID == 2).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.afyon = c.İkibinondortsecims.Where(x => x.SehirID == 3).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.agri = c.İkibinondortsecims.Where(x => x.SehirID == 4).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.amasya = c.İkibinondortsecims.Where(x => x.SehirID == 5).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.ankara = c.İkibinondortsecims.Where(x => x.SehirID == 6).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.antalya = c.İkibinondortsecims.Where(x => x.SehirID == 7).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.artvin = c.İkibinondortsecims.Where(x => x.SehirID == 8).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.aydin = c.İkibinondortsecims.Where(x => x.SehirID == 9).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.balikesir = c.İkibinondortsecims.Where(x => x.SehirID == 10).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.bilecik = c.İkibinondortsecims.Where(x => x.SehirID == 11).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.bingol = c.İkibinondortsecims.Where(x => x.SehirID == 12).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.bitlis = c.İkibinondortsecims.Where(x => x.SehirID == 13).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.bolu = c.İkibinondortsecims.Where(x => x.SehirID == 14).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.burdur = c.İkibinondortsecims.Where(x => x.SehirID == 15).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.bursa = c.İkibinondortsecims.Where(x => x.SehirID == 16).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.canakkale = c.İkibinondortsecims.Where(x => x.SehirID == 17).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.cankiri = c.İkibinondortsecims.Where(x => x.SehirID == 18).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.corum = c.İkibinondortsecims.Where(x => x.SehirID == 19).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.denizli = c.İkibinondortsecims.Where(x => x.SehirID == 20).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.diyarbakir = c.İkibinondortsecims.Where(x => x.SehirID == 21).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.edirne = c.İkibinondortsecims.Where(x => x.SehirID == 22).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.elazig = c.İkibinondortsecims.Where(x => x.SehirID == 23).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.erzincan = c.İkibinondortsecims.Where(x => x.SehirID == 24).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.erzurum = c.İkibinondortsecims.Where(x => x.SehirID == 25).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.eskisehir = c.İkibinondortsecims.Where(x => x.SehirID == 26).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.gaziantep = c.İkibinondortsecims.Where(x => x.SehirID == 27).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.giresun = c.İkibinondortsecims.Where(x => x.SehirID == 28).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.gumushane = c.İkibinondortsecims.Where(x => x.SehirID == 29).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.hatay = c.İkibinondortsecims.Where(x => x.SehirID == 31).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.isparta = c.İkibinondortsecims.Where(x => x.SehirID == 32).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.mersin = c.İkibinondortsecims.Where(x => x.SehirID == 33).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.istanbul = c.İkibinondortsecims.Where(x => x.SehirID == 34).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.izmir = c.İkibinondortsecims.Where(x => x.SehirID == 35).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kars = c.İkibinondortsecims.Where(x => x.SehirID == 36).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kastamonu = c.İkibinondortsecims.Where(x => x.SehirID == 37).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kayseri = c.İkibinondortsecims.Where(x => x.SehirID == 38).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kirklareli = c.İkibinondortsecims.Where(x => x.SehirID == 39).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kirsehir = c.İkibinondortsecims.Where(x => x.SehirID == 40).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kocaeli = c.İkibinondortsecims.Where(x => x.SehirID == 41).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.konya = c.İkibinondortsecims.Where(x => x.SehirID == 42).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kutahya = c.İkibinondortsecims.Where(x => x.SehirID == 43).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.malatya = c.İkibinondortsecims.Where(x => x.SehirID == 44).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.manisa = c.İkibinondortsecims.Where(x => x.SehirID == 45).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kahramanmaras = c.İkibinondortsecims.Where(x => x.SehirID == 46).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.mardin = c.İkibinondortsecims.Where(x => x.SehirID == 47).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.mugla = c.İkibinondortsecims.Where(x => x.SehirID == 48).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.mus = c.İkibinondortsecims.Where(x => x.SehirID == 49).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.nevsehir = c.İkibinondortsecims.Where(x => x.SehirID == 50).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.nigde = c.İkibinondortsecims.Where(x => x.SehirID == 51).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.ordu = c.İkibinondortsecims.Where(x => x.SehirID == 52).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.rize = c.İkibinondortsecims.Where(x => x.SehirID == 53).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.sakarya = c.İkibinondortsecims.Where(x => x.SehirID == 54).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.samsun = c.İkibinondortsecims.Where(x => x.SehirID == 55).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.siirt = c.İkibinondortsecims.Where(x => x.SehirID == 56).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.sinop = c.İkibinondortsecims.Where(x => x.SehirID == 57).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.sivas = c.İkibinondortsecims.Where(x => x.SehirID == 58).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.tekirdag = c.İkibinondortsecims.Where(x => x.SehirID == 59).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.tokat = c.İkibinondortsecims.Where(x => x.SehirID == 60).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.trabzon = c.İkibinondortsecims.Where(x => x.SehirID == 61).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.tunceli = c.İkibinondortsecims.Where(x => x.SehirID == 62).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.sanliurfa = c.İkibinondortsecims.Where(x => x.SehirID == 63).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.usak = c.İkibinondortsecims.Where(x => x.SehirID == 64).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.van = c.İkibinondortsecims.Where(x => x.SehirID == 65).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.yozgat = c.İkibinondortsecims.Where(x => x.SehirID == 66).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.zonguldak = c.İkibinondortsecims.Where(x => x.SehirID == 67).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.aksaray = c.İkibinondortsecims.Where(x => x.SehirID == 68).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.bayburt = c.İkibinondortsecims.Where(x => x.SehirID == 69).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.karaman = c.İkibinondortsecims.Where(x => x.SehirID == 70).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kirikkale = c.İkibinondortsecims.Where(x => x.SehirID == 71).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.batman = c.İkibinondortsecims.Where(x => x.SehirID == 72).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.sirnak = c.İkibinondortsecims.Where(x => x.SehirID == 73).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.bartin = c.İkibinondortsecims.Where(x => x.SehirID == 74).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.ardahan = c.İkibinondortsecims.Where(x => x.SehirID == 75).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.igdir = c.İkibinondortsecims.Where(x => x.SehirID == 76).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.yalova = c.İkibinondortsecims.Where(x => x.SehirID == 77).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.karabuk = c.İkibinondortsecims.Where(x => x.SehirID == 78).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kilis = c.İkibinondortsecims.Where(x => x.SehirID == 79).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.osmaniye = c.İkibinondortsecims.Where(x => x.SehirID == 80).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.duzce = c.İkibinondortsecims.Where(x => x.SehirID == 81).Select(y => y.SehirID).FirstOrDefault();
            return View();
        }


        public IActionResult Bilgi(int id) 
        {
            var values = secim.TGetIDbyFilter(id);
            return View(values);
        }


    }
}
