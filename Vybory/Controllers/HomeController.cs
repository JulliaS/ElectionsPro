using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Vybory.Models;

namespace Vybory.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork db;

        public HomeController(IUnitOfWork unitOfWork)
        {
            db = unitOfWork;
        }

        public IActionResult Index()
        {
            return View("View1");
        }

        public IActionResult Index2()
        {
            var userId = Convert.ToInt16(User.Claims.Where(x => x.Type == "userId").First().Value);
            var citizen = db.Citizens.Get(userId);
            var status = citizen.StatusId;
            switch (status)
            {
                case 6: ViewBag.Message = string.Format("6"); break;
                case 2: ViewBag.Message = string.Format("2"); break;
                case 3: ViewBag.Message = string.Format("3"); break;
                case 5: ViewBag.Message = string.Format("5"); break;
                default: ViewBag.Message = null; break;

            }
            return View("View2");
        }

        public IActionResult InstructionFoVote()
        {
            return View("InstructionFoVote");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

      
    }
}
