using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vybory.Models;

namespace Vybory.Controllers
{
    public class ObserverController : Controller
    {
        IUnitOfWork db;

        public ObserverController(IUnitOfWork unitOfWork)
        {
            db = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ObserverAppeal()
        {
            var citizens = db.Citizens.Find(c => c.StatusId == 1 || c.StatusId == 5);
            IEnumerable<Appeal> appeals = new List<Appeal>();
            foreach (var citizen in citizens)
            {
                appeals = db.Appeals.Find(a => (a.AppealTypeId != 6 || a.AppealTypeId != 4 || a.AppealTypeId != 5) && a.CitizenId == citizen.Id);
            }
            if (appeals == null)
            {
                return NotFound();
            }
            return View(appeals);
        }

        public IActionResult DetailUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = db.Users.Get(id.Value);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        public IActionResult EditAppeal(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appeal = db.Appeals.Get(id.Value);
            if (appeal == null)
            {
                return NotFound();
            }
            return View(appeal);
        }

        [HttpPost, ActionName("EditAppeal")]
        [ValidateAntiForgeryToken]
        public IActionResult EditAppeal(int id, Appeal appeal)
        {
            if (id != appeal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Appeals.Update(appeal);
                    db.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppealExists(appeal.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(appeal);
        }

        private bool AppealExists(int id)
        {
            return db.Appeals.Get(id) != null;
        }
    }
}