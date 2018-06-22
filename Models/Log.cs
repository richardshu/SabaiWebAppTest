using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SabaiWebApp.Models;

namespace SabaiWebApp.Models
{
    public class Log
    {
        private SabaiDataContext context;

        public int LogID { get; set; }

        public int PatientID { get; set; }

        public string FirstName { get; set; }

        public Emoji Mood { get; set; }

        public string FreeResponse { get; set; }

        public DateTime DateTime { get; set; }
    }
    public enum Emoji
    {
        Happy,
        Neutral,
        Sad
    }
}
