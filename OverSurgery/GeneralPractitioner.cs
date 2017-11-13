using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class GeneralPractitioner
    {
        string name;
        int status;
        DateTime dateJoined;
        string loginName;
        string password;

        public string Name { get => name; set => name = value; }
        public int Status { get => status; set => status = value; }
        public DateTime DateJoined { get => dateJoined; set => dateJoined = value; }
        public string LoginName { get => loginName; set => loginName = value; }
        public string Password { get => password; set => password = value; }
       
    }
}
