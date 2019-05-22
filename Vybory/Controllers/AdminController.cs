﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vybory.Models;

namespace Vybory.Controllers
{
    public class AdminController : Controller
    {
        IUnitOfWork db;

        public AdminController(IUnitOfWork unitOfWork)
        {
            db = unitOfWork;
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult StartAdminPage()
        {
            return View();
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult AdminElection()
        {
            var elections = db.Elections.GetAll();
            if (elections == null)
            {
                return NotFound();
            }
            return View(elections);
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult AdminDistrict()
        {
            var districts = db.Districts.GetAll();
            if (districts == null)
            {
                return NotFound();
            }
            return View(districts);
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult AdminPollingStation()
        {
            var pollingStation = db.PollingStations.GetAll();
            if (pollingStation == null)
            {
                return NotFound();
            }
            return View(pollingStation);
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult AdminAddress()
        {
            var addresses = db.Addresses.GetAll();
            if (addresses == null)
            {
                return NotFound();
            }
            return View(addresses);
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult AdminCitizen()
        {
            var citizens = db.Citizens.GetAll();
            if (citizens == null)
            {
                return NotFound();
            }
            return View(citizens);
        }

      
        public IActionResult AdminAppeal()
        {
            var appeals = db.Appeals.GetAll();
            if (appeals == null)
            {
                return NotFound();
            }
            return View(appeals);
        }

        #region  Editing

        [Authorize(Roles = "Адміністратор")]
        public IActionResult EditAddress(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var address = db.Addresses.Get(id.Value);
            if (address == null)
            {
                return NotFound();
            }
            return View(address);
        }

        [HttpPost, ActionName("EditAddress")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Адміністратор")]
        public IActionResult EditAddress(int id, Address address)
        {
            if (id != address.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Addresses.Update(address);
                    db.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddressExists(address.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("StartAdminPage","Admin");
            }
            return View(address);
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult EditDistrict(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var district = db.Districts.Get(id.Value);
            if (district == null)
            {
                return NotFound();
            }
            return View(district);
        }

        [HttpPost, ActionName("EditDistrict")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Адміністратор")]
        public IActionResult EditDistrict(int id, District district)
        {
            var adress = db.Addresses.Get(district.AddressId.Value);
            if (id != district.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid && adress!= null)
            {
                try
                {
                    db.Districts.Update(district);
                    db.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DistrictExists(district.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("StartAdminPage", "Admin");
            }
            return View(district);
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult EditElection(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var election = db.Elections.Get(id.Value);
            if (election == null)
            {
                return NotFound();
            }
            return View(election);
        }

        [HttpPost, ActionName("EditElection")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Адміністратор")]
        public IActionResult EditElection(int id, Election election)
        {
            var tour = db.Tours.Get(election.TourId.Value);
            if (id != election.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid && tour != null)
            {
                try
                {
                    db.Elections.Update(election);
                    db.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ElectionExists(election.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("StartAdminPage", "Admin");
            }
            return View(election);
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult EditPollingStation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var station = db.PollingStations.Get(id.Value);
            if (station == null)
            {
                return NotFound();
            }
            return View(station);
        }

        [HttpPost, ActionName("EditPollingStation")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Адміністратор")]
        public IActionResult EditPollingStation(int id, PollingStation station)
        {
            var address = db.Addresses.Get(station.AddressId.Value);
            var district = db.Districts.Get(station.DistrictId.Value);
            if (id != station.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid && address != null && district != null)
            {
                try
                {
                    db.PollingStations.Update(station);
                    db.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PollingStationExists(station.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("StartAdminPage", "Admin");
            }
            return View(station);
        }

        [Authorize(Roles = "Адміністратор")]
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
        [Authorize(Roles = "Адміністратор")]
        public IActionResult EditCitizen(int id, Citizen citizen)
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
                return RedirectToAction("StartAdminPage", "Admin");
            }
            return View(citizen);
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult EditUser(int? id)
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

        [HttpPost, ActionName("EditUser")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Адміністратор")]
        public IActionResult EditUser(int id, User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    user.Login = user.IPN.ToString();
                    db.Users.Update(user);
                    db.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("StartAdminPage", "Admin");
            }
            return View(user);
        }

        [Authorize(Roles = "Адміністратор")]
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
        [Authorize(Roles = "Адміністратор")]
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
                return RedirectToAction("StartAdminPage", "Admin");
            }
            return View(appeal);
        }

        #endregion

        #region Deleting

        [Authorize(Roles = "Адміністратор")]
        public IActionResult DeleteAddress(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var address = db.Addresses.Get(id.Value);
            if (address == null)
            {
                return NotFound();
            }

            return View(address);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Адміністратор")]
        public IActionResult DeleteAddress(int id)
        {
            db.Addresses.Delete(id);
            db.Save();
            return RedirectToAction("StartAdminPage", "Admin");
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult DeleteDistrict(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var districts = db.Districts.Get(id.Value);
            if (districts == null)
            {
                return NotFound();
            }

            return View(districts);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Адміністратор")]
        public IActionResult DeleteDistrict(int id)
        {
            db.Districts.Delete(id);
            db.Save();
            return RedirectToAction("StartAdminPage", "Admin");
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult DeleteElection(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var election = db.Elections.Get(id.Value);
            if (election == null)
            {
                return NotFound();
            }

            return View(election);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Адміністратор")]
        public IActionResult DeleteElection(int id)
        {
            db.Elections.Delete(id);
            db.Save();
            return RedirectToAction("StartAdminPage", "Admin");
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult DeletePollingStation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var station = db.PollingStations.Get(id.Value);
            if (station == null)
            {
                return NotFound();
            }

            return View(station);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Адміністратор")]
        public IActionResult DeletePollingStation(int id)
        {
            db.PollingStations.Delete(id);
            db.Save();
            return RedirectToAction("StartAdminPage", "Admin");
        }

        #endregion

        #region Creating

        [Authorize(Roles = "Адміністратор")]
        public IActionResult CreateAddress()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Адміністратор")]
        public IActionResult CreateAddress(Address address)
        {
            if (ModelState.IsValid && db.Addresses.Get(address.Id) == null)
            {
                db.Addresses.Create(address);
                db.Save();
                return RedirectToAction("StartAdminPage", "Admin");
            }
            return View(address);
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult CreateDistrict()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Адміністратор")]
        public IActionResult CreateDistrict(District distric)
        {
            if (ModelState.IsValid && db.Districts.Get(distric.Id) == null)
            {
                db.Districts.Create(distric);
                db.Save();
                return RedirectToAction("StartAdminPage", "Admin");
            }
            return View(distric);
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult CreateElection()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Адміністратор")]
        public IActionResult CreateElection(Election election)
        {
            if (ModelState.IsValid && db.Elections.Get(election.Id) == null)
            {
                db.Elections.Create(election);
                db.Save();
                return RedirectToAction("StartAdminPage", "Admin");
            }
            return View(election);
        }

        [Authorize(Roles = "Адміністратор")]
        public IActionResult CreatePollingStation()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Адміністратор")]
        public IActionResult CreatePollingStation(PollingStation station)
        {
            if (ModelState.IsValid && db.PollingStations.Get(station.Id) == null)
            {
                db.PollingStations.Create(station);
                db.Save();
                return RedirectToAction("StartAdminPage", "Admin");
            }
            return View(station);
        }

        #endregion

        private bool AddressExists(int id)
        {
            return db.Addresses.Get(id) != null;
        }

        private bool DistrictExists(int id)
        {
            return db.Districts.Get(id) != null;
        }

        private bool ElectionExists(int id)
        {
            return db.Elections.Get(id) != null;
        }

        private bool PollingStationExists(int id)
        {
            return db.PollingStations.Get(id) != null;
        }

        private bool UserExists(int id)
        {
            return db.Users.Get(id) != null;
        }

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