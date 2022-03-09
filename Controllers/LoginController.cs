using Hotel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class LoginController : Controller
    {
        Context cont = new Context();
        public IActionResult Login()
        {
            return View();
        }

        /*
        public async List<IActionResult> Login(account p)
        {

            return View();
        }
        */

    }
}
