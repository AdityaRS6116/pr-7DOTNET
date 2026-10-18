using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical_7.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Please enter student name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Please enter enrollment number")]
        public string EnrollmentNumber { get; set; }

        [Required(ErrorMessage = "Please enter subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please select rating")]
        public string Rating { get; set; }

        [Required(ErrorMessage = "Please enter your comment")]
        public string Comment { get; set; }
    }
}