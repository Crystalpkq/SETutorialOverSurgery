using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OverSurgery
{
    public class PatientHandler
    {
        public int addNewPatient(MySqlConnection conn, Patient patient)
        {
            string sql = "INSERT INTO patient(name, mykadNo, age) VALUES ('" + patient.Name + "','" + patient.Mykad + "','" + patient.Age + "')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            return cmd.ExecuteNonQuery();
        }

    }
}
