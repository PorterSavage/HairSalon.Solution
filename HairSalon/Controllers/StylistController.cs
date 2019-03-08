using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class StylistController : Controller
    {
        [HttpGet("/stylists")]
        public ActionResult Index()
        {
            List<Stylist> allStylists = Stylist.GetAll();
            return View(allStylists);
        }

        [HttpGet("/stylists/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/stylists")]
        public ActionResult Create(string stylistName)
        {
            Stylist newStylist = new Stylist(stylistName);
            newStylist.Save();
            return RedirectToAction("Index");
        }

        [HttpGet("/stylists/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Stylist selectedStylist = Stylist.Find(id);
            List<Client> stylistClients = selectedStylist.GetClients();
            model.Add("stylist", selectedStylist);
            model.Add("clients", stylistClients);
            return View(model);
        }

        [HttpPost("/stylists/{stylistId}/clients")]
        public ActionResult Create(string clientName, int stylistId)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Stylist foundStylist = Stylist.Find(stylistId);
            Client newClient = new Client(clientName, stylistId);
            newClient.Save();
            List<Client> stylistClients = foundStylist.GetClients();
            model.Add("clients", stylistClients);
            model.Add("stylist", foundStylist);
            return View("Show", model);
        }

        [HttpPost("/stylists/{stylistId}/delete")]
        public ActionResult Delete(int stylistId)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Stylist stylist = Stylist.Find(stylistId);
            stylist.Delete();
            model.Add("stylist", stylist);
            return View(model);
        }

        [HttpGet("/stylists/delete")]
        public ActionResult DeleteStylist(int stylistId)
        {
            Stylist stylist = Stylist.Find(stylistId);
            stylist.Delete();
            return RedirectToAction("Index");
        }

        [HttpGet("/stylists/deleteAll")]
        public ActionResult DeleteAll()
        {
            Stylist.ClearAll();
            return View();
        }
    }
}