using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniTrak.Models
{
    public class CategoryType
    {
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(75)]
        public string ShortDescription { get; set; }
    }
}