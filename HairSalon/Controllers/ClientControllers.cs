using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;

namespace HairSalon.Controllers
{
    public class ClientController : Controller
    {
        [HttpGet("/clients")]
        public ActionResult Index()
        {
            List<Client> allClients = Client.GetAll();
            return View(allClients);
        }

        [HttpGet("clients/{clientId}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Client selectedClient = Client.Find(id);
            model.Add("client", selectedClient);
            return View(model);
        }

        [HttpGet("/stylists/{stylistId}/clients/new")]
        public ActionResult New(int stylistId)
        {
            Stylist stylist = Stylist.Find(stylistId);
            return View(stylist);
        }

        [HttpGet("/stylists/{stylistId}/clients/{clientId}")]
        public ActionResult Show(int stylistId, int clientId)
        {
            Client client = Client.Find(clientId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            Stylist stylist = Stylist.Find(stylistId);
            model.Add("client", client);
            model.Add("stylist", stylist);
            return View(model);
        }

        [HttpGet("/stylists/{stylistId}/clients/{clientId}/delete")]
        public ActionResult Delete(int stylistId, int clientId)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Client client = Client.Find(clientId);
            client.Delete();
            model.Add("client", client);
            return View(model);
        }

        [HttpPost("/clients/deleted")]
        public ActionResult DeleteClient(int clientId)
        {
            Client client = Client.Find(clientId);
            client.Delete();
            return RedirectToAction("Index");
        }
    }
}