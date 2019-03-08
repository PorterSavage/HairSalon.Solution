using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
    public class Specialty
    {
        private int _id;
        private string _specialty;

        public Specialty(string specialty, int id = 0)
        {
            _id = id;
            _specialty = specialty;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetSpecialty()
        {
            return _specialty;
        }
    }
}