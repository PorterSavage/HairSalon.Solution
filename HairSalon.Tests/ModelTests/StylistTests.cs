using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class StylistTest : IDisposable
    {
        public StylistTest()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=porter_savage_test;";
        }

        public void Dispose()
        {
            Stylist.ClearAll();
        }

        [TestMethod]
        public void StylistConstructer_CreateInstanceOfStylist_Stylist()
        {
            Stylist newStylist = new Stylist("test stylist");
            Assert.AreEqual(typeof(Stylist), newStylist.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "Test Stylist";
            Stylist newStylist = new Stylist(name);
            string result = newStylist.GetName();
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetId_ReturnsId_Int()
        {
            string name = "Test Stylist";
            Stylist newStylist = new Stylist(name);
            int result = newStylist.GetId();
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAllStylistObjects_StylistList()
        {
            string name1 = "Work";
            string name2 = "School";
            Stylist newStylist1 = new Stylist(name1);
            newStylist1.Save();
            Stylist newStylist2 = new Stylist(name2);
            newStylist2.Save();
            List<Stylist> newList = new List<Stylist> { newStylist1, newStylist2 };
            List<Stylist> result = Stylist.GetAll();
            CollectionAssert.AreEqual(newList, result);     
        }
        
        [TestMethod]
        public void Find_ReturnsStylistInDatabase_Stylist()
        {
            Stylist testStylist = new Stylist("List of Clients");
            testStylist.Save();
            Stylist foundStylist = Stylist.Find(testStylist.GetId());
            Assert.AreEqual(testStylist, foundStylist);
        }

        [TestMethod]
        public void GetClients_ReturnsEmptyClientList_ClientList()
        {
            string name = "Work";
            Stylist newStylist = new Stylist(name);
            List<Client> newList = new List<Client> {};
            List<Client> result = newStylist.GetClients();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetAll_StylistsEmptyAtFirst_List()
        {
            int result = Stylist.GetAll().Count;
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Equals_ReturnsTrueIfNamesAreTheSame_Stylist()
        {
            Stylist firstStylist = new Stylist("brenda");
            Stylist secondStylist = new Stylist("brenda");
            Assert.AreEqual(firstStylist, secondStylist);
        }
       
    }
}