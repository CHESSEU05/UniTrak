using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniTrak.Models
{
    public class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; } // Can be Mr. Dr. Pr.
        public char Gender { get; set; }
        public DateTime DoB { get; set; }
        public string InstitutionalEmail { get; set; }
        public string PhoneNumber { get; set; }
    }
}