using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateTimeCoreWeb.Controllers
{
    public class ShowDateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
