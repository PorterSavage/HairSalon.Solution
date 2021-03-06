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
        public void SpecialtyConstructer_CreatesInstanceOfClass_Specialty()
        {
            Specialty newSpecialty = new Specialty("buzz head", 0);
            Assert.AreEqual(typeof(Specialty), newSpecialty.GetType());
        }

        [TestMethod]
        public void GetSpecialty_ReturnsSpecialtyName_String()
        {
            string specialty = "shave";
            int id = 0;
            Specialty newSpecialty = new Specialty(specialty, id);
            string result = newSpecialty.GetSpecialty();
            Assert.AreEqual(specialty, result);
        }

        [TestMethod]
        public void Save_SaveSpecialtyToDatabase_SpecialtyList()
        {
            Specialty testSpecialty = new Specialty("dying hair");
            testSpecialty.Save();
            List<Specialty> result = Specialty.GetAll();
            List<Specialty> testList = new List<Specialty> { testSpecialty };
            CollectionAssert.AreEqual(testList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAllObjectSpecialties_SpecialtyList()
        {
            string name1 = "buzz cut";
            string name2 = "face shave";
            Specialty newSpecialty1 = new Specialty(name1);
            newSpecialty1.Save();
            Specialty newSpecialty2 = new Specialty(name2);
            newSpecialty2.Save();
            List<Specialty> newList = new List<Specialty> { newSpecialty1, newSpecialty2 };
            List<Specialty> result = Specialty.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void Find_ReturnSpecilatyInDatabase_Specialty()
        {
            Specialty testSpecialty = new Specialty("fire cutting");
            testSpecialty.Save();
            Specialty foundSpecialty = Specialty.Find(testSpecialty.GetId());
            Assert.AreEqual(testSpecialty, foundSpecialty);
        }
    }
}