using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OverSurgery
{
    public class Patient
    {
        int id;
        string name;
        string mykad;
        int age;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Mykad { get => mykad; set => mykad = value; }
        public int Age { get => age; set => age = value; }
        
    }
}
