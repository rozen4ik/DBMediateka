using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBMediateka.Models;

namespace DBMediateka.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Country()
        {
            DbMediatekaContext context = HttpContext.RequestServices.GetService(typeof(DBMediateka.Models.DbMediatekaContext)) as DbMediatekaContext;
            return View(context.GetAllCountry());
        }

        public IActionResult Artist()
        {
            DbMediatekaContext context = HttpContext.RequestServices.GetService(typeof(DBMediateka.Models.DbMediatekaContext)) as DbMediatekaContext;
            return View(context.GetAllArtist());
        }

        public IActionResult City()
        {
            DbMediatekaContext context = HttpContext.RequestServices.GetService(typeof(DBMediateka.Models.DbMediatekaContext)) as DbMediatekaContext;
            return View(context.GetAllCity());
        }

        public IActionResult User()
        {
            DbMediatekaContext context = HttpContext.RequestServices.GetService(typeof(DBMediateka.Models.DbMediatekaContext)) as DbMediatekaContext;
            return View(context.GetAllUser());
        }

        public IActionResult Like()
        {
            DbMediatekaContext context = HttpContext.RequestServices.GetService(typeof(DBMediateka.Models.DbMediatekaContext)) as DbMediatekaContext;
            return View(context.GetAllLike());
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
