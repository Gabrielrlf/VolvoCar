using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VolvoCar.Application.Models;
using VolvoCar.Core;
using VolvoCar.Domain.Model;

namespace VolvoCar.Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly TruckBLL _bll;

        public HomeController(ILogger<HomeController> logger, TruckBLL bll)
        {
            _logger = logger;
            _bll = bll;
        }

        public async Task<IActionResult> Index() => View(_bll.ListAllTruck());

        public IActionResult Privacy()
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
