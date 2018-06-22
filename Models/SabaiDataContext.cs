using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SabaiWebApp.Models;
using MySql.Data.MySqlClient;

namespace SabaiWebApp.Models
{
    public class SabaiDataContext
    {
        public string ConnectionString { get; set; }

        public SabaiDataContext(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Patient> GetAllPatients()
        {
            List<Patient> patientList = new List<Patient>();

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from patients", connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patientList.Add(new Patient()
                        {
                            PatientId = Convert.ToInt32(reader["PatientId"]),
                            DoctorId = Convert.ToInt32(reader["DoctorId"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString(),
                            Verified = Convert.ToBoolean((reader["Verified"]))
                        });
                    }
                }
            }
            return patientList;
        }
    }
}
