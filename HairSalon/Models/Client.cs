using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
    public class Client
    {
        private int _id;
        private string _name;
        private int _stylist_id;

        public Client(string name, int stylist_id, int id = 0)
        {
            _name = name;
            _stylist_id = stylist_id;
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetId()
        {
            return _id;
        }
    }
}