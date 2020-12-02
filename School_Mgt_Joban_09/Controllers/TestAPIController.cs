using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace School_Mgt_Joban_09.Controllers
{
    public class TestAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
