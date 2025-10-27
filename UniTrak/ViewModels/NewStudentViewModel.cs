using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniTrak.Models;

namespace UniTrak.ViewModels
{
    public class NewStudentViewModel
    {
        public IEnumerable<MembershipType> MembershipType { get; set; }
        public Student Student { get; set; }
    }
}