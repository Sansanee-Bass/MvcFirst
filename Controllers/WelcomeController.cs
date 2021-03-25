using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcFirst.Models;

namespace MvcFirst.Controllers
{
    public class WelcomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public WelcomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [BindProperty(SupportsGet = true)]
        public string Message { get; set; }
        public IActionResult Greet(int count = 1)
        {

            if (!string.IsNullOrEmpty(Message))
            {
                string msg = "";
                for (int i = 0; i <= count; i++)
                {
                    msg += HtmlEncoder.Default.Encode(Message) + "<br>";
                }

                ViewBag.msg = msg;
            }
            else
            {
                ViewBag.msg = "";
            }

            return View();
        }
        public string Index()
        {
            return "Wahoo";
        }
    }

}
