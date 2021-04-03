using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BridgeMonitor.Models;

namespace vcubtracker.Controllers
{
    public class ClosingController : Controller
    {
        private readonly ILogger<ClosingController> _logger;

        public ClosingController(ILogger<ClosingController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllClosing()
        {
            return View();
        }
        public IActionResult DetailsClosing()
        {
            return View();
        }
        public IActionResult NextClosing()
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
