using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OptimisedGolf.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OptimisedGolf.Controllers
{
    public class HoleController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult StartNewHole(int par)
        {
            var viewmodel = new Hole(par);

            return View(viewmodel);
        }
    }
}
