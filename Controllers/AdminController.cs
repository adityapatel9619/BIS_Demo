using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIS_Demo.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult RegisterAuthor()
        {
            return View();
        }


        // Manage Books

        public IActionResult AddBook()
        {
            return View();
        }

        public IActionResult SearchBook()
        {
            return View();
        }

        public IActionResult UpdateBook()
        {
            return View();
        }

        // Table Display

        public IActionResult TableDisplay()
        {
            return View();
        }
    }
}
