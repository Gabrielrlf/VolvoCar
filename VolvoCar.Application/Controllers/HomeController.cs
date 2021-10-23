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
    /// <summary>
    /// Controller principal da aplicação
    /// </summary>
    public class HomeController : Controller
    {
        private TruckSK truckSK = new();
        private readonly ILogger<HomeController> _logger;

        private readonly ITruckService _bll;


        /// <summary>
        /// Constructor da Controller, passando o TruckBLL e um Logger.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="bll"></param>
        public HomeController(ILogger<HomeController> logger, ITruckService bll)
        {
            _logger = logger;
            _bll = bll;
        }

        /// <summary>
        /// É o Index/pag home
        /// </summary>
        /// <returns></returns>
        public IActionResult Index() => View(_bll.ListAllTruck());


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// Chama a View do Delete
        /// </summary>
        /// <param name="id"></param>
        public IActionResult Delete(int? id)
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
        /// Deleção confirmada
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {

            _bll.DeleteTruck(id);
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Chamará a view do Create
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Fará a recuperação do Create e adicionar ao banco.
        /// </summary>
        /// <param name="truck"></param>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id, ModelName, YearModel, YearFabrication, CreationDate, UpdateDate")] Truck truck)
        {
            if (ModelState.IsValid)
            {
                _bll.RegisterTruck(truck);
                return RedirectToAction(nameof(Index));
            }
            return View(truck);
        }

        /// <summary>
        /// Fará a recuperação do Edit e salvar.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="truck"></param>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id, ModelName, YearModel, YearFabrication, CreationDate, UpdateDate")] Truck truck)
        {
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
