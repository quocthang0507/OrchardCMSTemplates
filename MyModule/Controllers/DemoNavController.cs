using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrchardCore.Admin;

namespace MyModule.Controllers
{
    [Admin]
    public class DemoNavController : Controller
    {
        public ActionResult ChildOne()
        {
            return View();
        }

        public ActionResult ChildTwo()
        {
            return View();
        }
    }
}