using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class StylistControllerTest
    {
        [TestMethod]
        public void Create_ReturnsCorrectActionType_RedirctToActionResult()
        {
            StylistController controller = new StylistController();
            ActionResult view = controller.Create("style their hair");
            Assert.InstanceOfType(view, typeof(RedirectToActionResult));
        }
    }
}