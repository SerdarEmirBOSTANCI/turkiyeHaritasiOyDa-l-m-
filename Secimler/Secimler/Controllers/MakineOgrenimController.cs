using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Secimler.Controllers
{
    public class MakineOgrenimController : Controller
    {
        public IActionResult SecimTahmin2024()
        {
            return View();
        }

        public IActionResult GelecekSecimTahmin()
        {
            return View();
        }

    }
}
