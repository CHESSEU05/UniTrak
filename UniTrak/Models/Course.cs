using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniTrak.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }
  
        [Required]
        public string Title { get; set; }
        
        [Required]
        public byte CreditValue { get; set; }

        [Required]
        public DateTime DateAdded { get; set; } = DateTime.Today;
        
        [Required] 
        public CategoryType CategoryType { get; set; }
        
        [Required]
        public byte CategoryTypeId { get; set; }
    }
}