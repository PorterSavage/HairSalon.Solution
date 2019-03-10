using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class SpecialtyControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            SpecialtyController controller = new SpecialtyController();
            ActionResult indexView = controller.Index();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void New_ReturnsCorrectView_True()
        {
            SpecialtyController controller = new SpecialtyController();
            ActionResult newView = controller.New(1);
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        [TestMethod]
        public void Create_ReturnsCorretView_True()
        {
            SpecialtyController controller = new SpecialtyController();
            ActionResult newView = controller.Create("john");
            Assert.IsInstanceOfType(newView, typeof(RedirectToActionResult));
        }
    }
}