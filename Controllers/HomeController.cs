using Hotel.DataProvider.EFDataProvider;
using Hotel.DataProvider.IDataProvider;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class HomeController : Controller
    {
        IReservationDataProvider _reservationDataProvider = new EFReservationDataProvider();
        private readonly ILogger<HomeController> _logger;

        Context c = new Context();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Kurumsal()
        {
            return View();
        }
        public IActionResult Odalar()
        {
            var degerler = c.room_type.ToList();
            return View(degerler);
        }


        public IActionResult Aktiviteler()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Rezervasyon()
        {
            var degerler = c.room_type.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult Rezervasyon2()
        {

            return View();
        }


        //String first_name, String last_name, String room_type,
        //String date_in, String date_out
    [HttpPost]
        public IActionResult Rezervasyon2 (reservationX r)
        {
            return Content(_reservationDataProvider.Add(r));
            //return View(); 
        }


        public IActionResult Galeri()
        {
            return View();
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
