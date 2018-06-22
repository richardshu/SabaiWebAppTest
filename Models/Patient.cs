using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SabaiWebApp.Models;

namespace SabaiWebApp.Models
{
    public class Patient
    {
        private SabaiDataContext context;

        public int PatientId { get; set; }

        public int DoctorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Verified { get; set; }
    }
}
