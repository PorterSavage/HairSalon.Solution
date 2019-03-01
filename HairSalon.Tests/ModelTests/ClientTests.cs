using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class ClientTest : IDisposable
    {
        public void Dispose()
        {
            Client.ClearAll();
        }

        public ClientTest()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=porter_savage_test;";
        }

        [TestMethod]
        public void ClientConstructer_CreatesInstanceOfClient_Item()
        {
            Client newClient = new Client("test", 0);
            Assert.AreEqual(typeof(Client), newClient.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "jon";
            Client newClient = new Client(name, 0);
            string result = newClient.GetName();
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_ClientList()
        {
            List<Client> newList = new List<Client> {};
            List<Client> result = Client.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }
    }
}