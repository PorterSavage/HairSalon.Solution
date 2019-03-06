using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class ClientControllerTest
    {
        [TestMethod]
        public void New_ReturnsCorrectView_True()
        {
            string name = "jen";
            int stylistId = 0;
            Stylist newStylist = new Stylist(name, stylistId);
            newStylist.Save();
            stylistId = newStylist.GetId();
            ClientController controller = new ClientController();
            ActionResult View = controller.New(stylistId);
            Assert.IsInstanceOfType(View, typeof(ViewResult));
        }

        [TestMethod]
        public void New_HasCorrectModelType_Stylist()
        {
            string name = "jen";
            int stylistId = 0;
            Stylist newStylist = new Stylist(name, stylistId);
            newStylist.Save();
            stylistId = newStylist.GetId();
            ClientController controller = new ClientController();
            ViewResult view = controller.New(stylistId) as ViewResult;
            var result = view.ViewData.Model;
            Assert.IsInstanceOfType(result, typeof(Stylist));
        }

        [TestMethod]
        public void Show_ReturnsCorrectView_True()
        {
            string stylistName = "jen";
            int stylistId = 0;
            string clientName = "bob";
            int clientId = 0;
            Stylist newStylist = new Stylist(stylistName, stylistId);
            Client newClient = new Client(clientName, clientId);
            newStylist.Save();
            newClient.Save();
            stylistId = newStylist.GetId();
            clientId = newClient.GetId();
            ClientController controller = new ClientController();
            ActionResult view = controller.Show(stylistId, clientId);
            Assert.IsInstanceOfType(view, typeof(ViewResult));
        }

        [TestMethod]
        public void Show_HasCorrectModelType_Client()
        {
            string stylistName = "jen";
            int stylistId = 0;
            string clientName = "bob";
            int clientId = 0;
            Stylist newStylist = new Stylist(stylistName, stylistId);
            Client newClient = new Client(clientName, clientId);
            newStylist.Save();
            newClient.Save();
            stylistId = newStylist.GetId();
            clientId = newClient.GetId();
            ClientController controller = new ClientController();
            ViewResult view = controller.Show(stylistId, clientId) as ViewResult;
            var result = view.ViewData.Model;
            Assert.IsInstanceOfType(result, typeof(Dictionary<string, object>));
        }
    }
}