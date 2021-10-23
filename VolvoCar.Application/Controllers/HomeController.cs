using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VolvoCar.Application.Models;
using VolvoCar.Core;
using VolvoCar.Domain.Exception;
using VolvoCar.Domain.Model;
using VolvoCar.SharedKernel;

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

        public IActionResult Index() => View(_bll.ListAllTruck());


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Trucks/Edit/5
        public IActionResult Edit(int? id)
        {
            try
            {
                if (id.Equals(null))
                {
                    return BadRequest();
                }

                Truck obj = _bll.FindObjectById(id);
                return View(obj);
            }
            catch (Exception e)
            {
                new TruckException(e.Message);
                return BadRequest();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="truck"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ModelName,YearModel, YearFabrication, CreationDate, UpdateDate")] Truck truck)
        {
            TruckSK truckSK = new();
            if (truckSK.InvalidId(truck.Id, id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _bll.UpdateTruck(truck);
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(truck);
        }

        /// <summary>
        /// 
        /// </summary>
        public IActionResult Privacy => View();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
