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
    public class ikibinyirmidortsecimController : Controller
    {

        Context c = new Context();
        ikibinyirmidortsecimBl secim = new ikibinyirmidortsecimBl(new EfikibinyirmidortsecimDal());

        public IActionResult Index()
        {
            ViewBag.hakkari = c.ikibinonyedisecims.Where(x => x.SehirID == 30).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.adana = c.ikibinonyedisecims.Where(x => x.SehirID == 1).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.adiyaman = c.ikibinonyedisecims.Where(x => x.SehirID == 2).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.afyon = c.ikibinonyedisecims.Where(x => x.SehirID == 3).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.agri = c.ikibinonyedisecims.Where(x => x.SehirID == 4).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.amasya = c.ikibinonyedisecims.Where(x => x.SehirID == 5).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.ankara = c.ikibinonyedisecims.Where(x => x.SehirID == 6).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.antalya = c.ikibinonyedisecims.Where(x => x.SehirID == 7).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.artvin = c.ikibinonyedisecims.Where(x => x.SehirID == 8).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.aydin = c.ikibinonyedisecims.Where(x => x.SehirID == 9).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.balikesir = c.ikibinonyedisecims.Where(x => x.SehirID == 10).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.bilecik = c.ikibinonyedisecims.Where(x => x.SehirID == 11).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.bingol = c.ikibinonyedisecims.Where(x => x.SehirID == 12).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.bitlis = c.ikibinonyedisecims.Where(x => x.SehirID == 13).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.bolu = c.ikibinonyedisecims.Where(x => x.SehirID == 14).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.burdur = c.ikibinonyedisecims.Where(x => x.SehirID == 15).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.bursa = c.ikibinonyedisecims.Where(x => x.SehirID == 16).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.canakkale = c.ikibinonyedisecims.Where(x => x.SehirID == 17).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.cankiri = c.ikibinonyedisecims.Where(x => x.SehirID == 18).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.corum = c.ikibinonyedisecims.Where(x => x.SehirID == 19).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.denizli = c.ikibinonyedisecims.Where(x => x.SehirID == 20).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.diyarbakir = c.ikibinonyedisecims.Where(x => x.SehirID == 21).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.edirne = c.ikibinonyedisecims.Where(x => x.SehirID == 22).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.elazig = c.ikibinonyedisecims.Where(x => x.SehirID == 23).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.erzincan = c.ikibinonyedisecims.Where(x => x.SehirID == 24).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.erzurum = c.ikibinonyedisecims.Where(x => x.SehirID == 25).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.eskisehir = c.ikibinonyedisecims.Where(x => x.SehirID == 26).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.gaziantep = c.ikibinonyedisecims.Where(x => x.SehirID == 27).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.giresun = c.ikibinonyedisecims.Where(x => x.SehirID == 28).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.gumushane = c.ikibinonyedisecims.Where(x => x.SehirID == 29).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.hatay = c.ikibinonyedisecims.Where(x => x.SehirID == 31).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.isparta = c.ikibinonyedisecims.Where(x => x.SehirID == 32).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.mersin = c.ikibinonyedisecims.Where(x => x.SehirID == 33).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.istanbul = c.ikibinonyedisecims.Where(x => x.SehirID == 34).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.izmir = c.ikibinonyedisecims.Where(x => x.SehirID == 35).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kars = c.ikibinonyedisecims.Where(x => x.SehirID == 36).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kastamonu = c.ikibinonyedisecims.Where(x => x.SehirID == 37).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kayseri = c.ikibinonyedisecims.Where(x => x.SehirID == 38).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kirklareli = c.ikibinonyedisecims.Where(x => x.SehirID == 39).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kirsehir = c.ikibinonyedisecims.Where(x => x.SehirID == 40).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kocaeli = c.ikibinonyedisecims.Where(x => x.SehirID == 41).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.konya = c.ikibinonyedisecims.Where(x => x.SehirID == 42).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kutahya = c.ikibinonyedisecims.Where(x => x.SehirID == 43).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.malatya = c.ikibinonyedisecims.Where(x => x.SehirID == 44).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.manisa = c.ikibinonyedisecims.Where(x => x.SehirID == 45).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kahramanmaras = c.ikibinonyedisecims.Where(x => x.SehirID == 46).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.mardin = c.ikibinonyedisecims.Where(x => x.SehirID == 47).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.mugla = c.ikibinonyedisecims.Where(x => x.SehirID == 48).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.mus = c.ikibinonyedisecims.Where(x => x.SehirID == 49).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.nevsehir = c.ikibinonyedisecims.Where(x => x.SehirID == 50).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.nigde = c.ikibinonyedisecims.Where(x => x.SehirID == 51).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.ordu = c.ikibinonyedisecims.Where(x => x.SehirID == 52).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.rize = c.ikibinonyedisecims.Where(x => x.SehirID == 53).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.sakarya = c.ikibinonyedisecims.Where(x => x.SehirID == 54).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.samsun = c.ikibinonyedisecims.Where(x => x.SehirID == 55).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.siirt = c.ikibinonyedisecims.Where(x => x.SehirID == 56).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.sinop = c.ikibinonyedisecims.Where(x => x.SehirID == 57).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.sivas = c.ikibinonyedisecims.Where(x => x.SehirID == 58).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.tekirdag = c.ikibinonyedisecims.Where(x => x.SehirID == 59).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.tokat = c.ikibinonyedisecims.Where(x => x.SehirID == 60).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.trabzon = c.ikibinonyedisecims.Where(x => x.SehirID == 61).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.tunceli = c.ikibinonyedisecims.Where(x => x.SehirID == 62).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.sanliurfa = c.ikibinonyedisecims.Where(x => x.SehirID == 63).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.usak = c.ikibinonyedisecims.Where(x => x.SehirID == 64).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.van = c.ikibinonyedisecims.Where(x => x.SehirID == 65).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.yozgat = c.ikibinonyedisecims.Where(x => x.SehirID == 66).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.zonguldak = c.ikibinonyedisecims.Where(x => x.SehirID == 67).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.aksaray = c.ikibinonyedisecims.Where(x => x.SehirID == 68).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.bayburt = c.ikibinonyedisecims.Where(x => x.SehirID == 69).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.karaman = c.ikibinonyedisecims.Where(x => x.SehirID == 70).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kirikkale = c.ikibinonyedisecims.Where(x => x.SehirID == 71).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.batman = c.ikibinonyedisecims.Where(x => x.SehirID == 72).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.sirnak = c.ikibinonyedisecims.Where(x => x.SehirID == 73).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.bartin = c.ikibinonyedisecims.Where(x => x.SehirID == 74).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.ardahan = c.ikibinonyedisecims.Where(x => x.SehirID == 75).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.igdir = c.ikibinonyedisecims.Where(x => x.SehirID == 76).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.yalova = c.ikibinonyedisecims.Where(x => x.SehirID == 77).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.karabuk = c.ikibinonyedisecims.Where(x => x.SehirID == 78).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.kilis = c.ikibinonyedisecims.Where(x => x.SehirID == 79).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.osmaniye = c.ikibinonyedisecims.Where(x => x.SehirID == 80).Select(y => y.SehirID).FirstOrDefault();
            ViewBag.duzce = c.ikibinonyedisecims.Where(x => x.SehirID == 81).Select(y => y.SehirID).FirstOrDefault();
            return View();
        }


        public IActionResult Bilgi(int id)
        {
            var values = secim.TGetIDbyFilter(id);
            return View(values);
        }


    }
}
