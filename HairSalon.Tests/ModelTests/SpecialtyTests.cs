using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{
    [TestClass]
    public class SpecialtyTest : IDisposable
    {
        public void Dispose()
        {
            Specialty.ClearAll();
        }
        public SpecialtyTest()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id =root;password=root;port=8889;database=porter_savage_test;";
        }

        [TestMethod]
        public void SpecialtyConstructer_CreatesInstance_Specialty()
        {
            Specialty newSpecialty = new Specialty("buzz head", 0);
            Assert.AreEqual(typeof(Specialty), newSpecialty.GetType());
        }
     }
}