using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniTrak.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string MatriculationNumber { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTime? DoB { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; } // This is what we call a navigation property.
        public byte MembershipTypeId { get; set; } // EF recognises this convention and treats it as a foreign key.
    }
} 