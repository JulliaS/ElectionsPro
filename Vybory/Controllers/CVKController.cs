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
    public class CVKController : Controller
    {
        IUnitOfWork db;

        public CVKController(IUnitOfWork unitOfWork)
        {
            db = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
        
      
        public IActionResult CVKCitizen()
        {
            var citizens = db.Citizens.Find(c=>c.StatusId == 2);
            if (citizens == null)
            {
                return NotFound();
            }
            return View(citizens);
        }


        public IActionResult CVKAppeal()
        {
            var citizens = db.Citizens.Find(c => c.StatusId == 2);
            IEnumerable<Appeal> appeals = new List<Appeal>();
            foreach (var citizen in citizens)
            {
                appeals = db.Appeals.Find(a => a.AppealTypeId == 6 || a.CitizenId == citizen.Id);
            }
            if (appeals == null)
            {
                return NotFound();
            }
            return View(appeals);
        }

        #region  Editing

        public IActionResult EditCitizen(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var citizen = db.Citizens.Get(id.Value);
            if (citizen == null)
            {
                return NotFound();
            }
            return View(citizen);
        }

        [HttpPost, ActionName("EditCitizen")]
        [ValidateAntiForgeryToken]
        public IActionResult EditCitizen(int id, Citizen citizen)
        {
            try
            {
                var election = db.Elections.Get(citizen.ElectionId.Value);
                var station = db.PollingStations.Get(citizen.PollingStationId.Value);
                var district = db.Districts.Get(citizen.DistrictId.Value);
                var status = db.Statuses.Get(citizen.StatusId.Value);
                var user = db.Users.Get(citizen.Id);
                if (id != citizen.Id)
                {
                    return NotFound();
                }
           

                if (ModelState.IsValid && election != null
                    && district != null && station != null
                    && status != null && user != null)
                {
                    try
                    {
                        db.Citizens.Update(citizen);
                        db.Save();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CitizenExists(citizen.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction("Index", "CVK");
                }
                return View(citizen);
            }
            catch (InvalidOperationException)
            {
                return EditCitizen(id, citizen);
            }
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
                return RedirectToAction("Index", "CVK");
            }
            return View(appeal);
        }

        #endregion

        private bool CitizenExists(int id)
        {
            return db.Citizens.Get(id) != null;
        }

        private bool AppealExists(int id)
        {
            return db.Appeals.Get(id) != null;
        }
       
    }
}