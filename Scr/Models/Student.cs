using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Code_First_Approach_in_Entity_Framework.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required(ErrorMessage="You can't leave it blank.")]
        [StringLength(10, MinimumLength = 3, ErrorMessage="Enter minimum 3 or maximum 10 chars.")]
        [RegularExpression(@"(\S)+", ErrorMessage = "White space is not allowed.")]
       
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
    }
}