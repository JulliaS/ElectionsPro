using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using Vybory.Models;

namespace Vybory.Controllers
{
    public class VoteController : Controller
    {
        private IUnitOfWork db;

        public VoteController(IUnitOfWork unitOfWork)
        {
            db = unitOfWork;
        }

        [HttpPost]
        public IActionResult StartVote(string cndt)
        {
            if (cndt == "-1")
            {
                var userId = Convert.ToInt16(User.Claims.Where(x => x.Type == "userId").First().Value);
                var votes = db.Votes.GetAll();
                var electoin = db.Elections.Find(el => el.StartVote <= DateTime.Now && el.EndVote >= DateTime.Now && el.Year == DateTime.Now.Year).First();
                var citizen = db.Citizens.Get(userId);
                var vote = new Vote()
                {
                    Id = votes.Count() + 1,
                    ElectionId = electoin.Id,
                    PollingStationId = citizen.PollingStationId,
                    CitizenId = userId,
                    CandidatId = null
                };
                db.Votes.Create(vote);
                db.Save();
                return View("SuccessVote");
            }
            else
            {
                var userId = Convert.ToInt16(User.Claims.Where(x => x.Type == "userId").First().Value);
                var votes = db.Votes.GetAll();
                var electoin = db.Elections.Find(el => el.StartVote <= DateTime.Now && el.EndVote >= DateTime.Now && el.Year == DateTime.Now.Year).First();
                var citizen = db.Citizens.Get(userId);
                var candidatIdInCetizenTable = Convert.ToInt32(cndt);
                var candidat = db.Candidats.Find(cand => cand.CitizenId == candidatIdInCetizenTable).First();
                var vote = new Vote()
                {
                    Id = votes.Count() + 1,
                    ElectionId = electoin.Id,
                    PollingStationId = citizen.PollingStationId,
                    CitizenId = userId,
                    CandidatId = candidat.Id
                };
                db.Votes.Create(vote);
                db.Save();
                return View("SuccessVote");
            }
        }
        [HttpGet]
        public IActionResult StartVote()
        {
            bool is_now = true;
            var citizens = db.Citizens.GetAll();
            int choosen_el_id = 0;
            try
            {
                var electoin = db.Elections.Find(el => el.StartVote <= DateTime.Now && el.EndVote >= DateTime.Now && el.Year == DateTime.Now.Year).First();
                choosen_el_id = electoin.Id;
            }
            catch
            {
                is_now = false;
            }
            List<User> users = new List<User>();

            if (!is_now)
            {
                try
                {
                    var electoin = db.Elections.Find(el => el.StartVote >= DateTime.Now && el.Year == DateTime.Now.Year).Min();
                    if (electoin != null)
                    {
                        return View("TillElection", electoin);
                    }
                    else
                    {
                        return View();
                    }
                }
                catch
                {
                    return View("AnyPlanElection");
                }
            }
            else
            {
                foreach (var citizen in citizens)
                {
                    var candidats = db.Candidats.Find(cand => cand.CitizenId == citizen.Id && cand.ElectionId == choosen_el_id).ToList();
                    if (candidats.Count != 0)
                    {
                        foreach (var candidat in candidats)
                        {
                            users.Add(db.Users.Get((int)candidat.CitizenId));
                        }
                    }

                };
                var userId = Convert.ToInt16(User.Claims.Where(x => x.Type == "userId").First().Value);
                var votes = db.Votes.GetAll();
                foreach (var v in votes)
                {
                    if (userId == v.CitizenId)
                    {
                        ViewBag.Message = string.Format("Fill string");
                    }
                }
                return View(users);
            }
        }

        [HttpGet]
        public IActionResult VoteResults()
        {
            List<int> count = new List<int>();
            try
            {
                var electoin = db.Elections.Find(el => el.StartVote <= DateTime.Now).Last();
                var candidats = db.Candidats.Find(cand => cand.ElectionId == electoin.Id);
                var votes = db.Votes.GetAll().Where(c => c.ElectionId == electoin.Id);
                List<User> users = new List<User>();
                Dictionary<string[], int> res = new Dictionary<string[], int>();
                string[] str = new string[3];
                foreach (var v in votes)
                {
                    if (v.CandidatId == null)
                    {
                        str[0] = "None";
                        str[1] = "None";
                        str[2] = "None";
                    }
                    else
                    {
                        str[0] = db.Candidats.Get(v.CandidatId.Value).Number.ToString();
                        str[1] = db.Users.Get(db.Candidats.Get(v.CandidatId.Value).CitizenId.Value).Name.ToString();
                        str[2] = db.Users.Get(db.Candidats.Get(v.CandidatId.Value).CitizenId.Value).Surname.ToString();
                    }
                    bool is_in = false;
                    foreach (KeyValuePair<string[], int> k in res)
                    {
                        if (k.Key[0] == str[0])
                        {
                            is_in = true;
                            res[k.Key] += 1;
                            break;
                        }
                    }
                    if (!is_in)
                    {
                        res.Add(str, 1);
                        str = new string[3];
                    }
                }
                return View("VoteResults", res);
            }
            catch
            {
                return RedirectToAction("Index2", "Home");
            }
        }


        [HttpGet]
        public IActionResult AddAppeal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAppeal(Appeal appeal)
        {
            if (appeal.Text != string.Empty)
            {
                try
                {
                    var userId = Convert.ToInt16(User.Claims.Where(x => x.Type == "userId").First().Value);
                    var citizen = db.Citizens.Get(userId);
                    appeal.Id = db.Appeals.GetAll().Count() + 1;
                    appeal.CitizenId = citizen.Id;
                    appeal.PollingStationId = citizen.PollingStationId;
                    appeal.ElectionId = citizen.ElectionId;

                    db.Appeals.Create(appeal);
                    db.Save();
                    return View("Index2", "Home");
                }
                catch
                {
                    return AddAppeal();
                }
            }
            return AddAppeal();
        }

        public IActionResult ChangeStatus()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangeStatus(string status)
        {
            try
            {
                var appeal = new Appeal();
                var userId = Convert.ToInt16(User.Claims.Where(x => x.Type == "userId").First().Value);
                var citizen = db.Citizens.Get(userId);
                appeal.Id = db.Appeals.GetAll().Count() + 1;
                appeal.CitizenId = citizen.Id;
                appeal.PollingStationId = citizen.PollingStationId;
                appeal.ElectionId = citizen.ElectionId;
                appeal.Text = status;
                if(status == "спостерігач")
                {
                    appeal.AppealTypeId = 4;
                }
                if (status == "голова дільниці")
                {
                    appeal.AppealTypeId = 5;
                }
                if (status == "голова округу")
                {
                    appeal.AppealTypeId = 6;
                }

                db.Appeals.Create(appeal);

                db.Save();
                return RedirectToAction("Index2", "Home");
            }
            catch
            {
                return View("AddAppeal", "Vote");
            }
           
        }

        private void Tick(int seconds, int minutes, int hours)
        {
            seconds++;
            if(seconds == 60)
            {
                minutes++;
                seconds = 00;
            }
            if(minutes == 60)
            {
                hours++;
                minutes = 00;
            }
        }
    }
}