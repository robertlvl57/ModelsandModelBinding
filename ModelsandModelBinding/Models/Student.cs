using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;

namespace ModelsandModelBinding.Models
{
    /// <summary>
    /// Represents an individual student
    /// </summary>
    public class Student
    {
        public int StudentId { get; set; }

        /// <summary>
        /// The legal First and Last name
        /// ex. J Doe
        /// </summary>
        [Required(ErrorMessage = "Gimme that name!")]
        [Display(Name = "Full Legal Name")]
        public string FullName { get; set; }

        /// <summary>
        /// The program the student intends to complete
        /// </summary>
        [Required]
        [Display(Name = "Choose Program")]
        public string ProgramOfChoice { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        // Max 30 chars just for demo
        [StringLength(30, MinimumLength = 5)]
        public string HomeAddress { get; set; }
    }
}
