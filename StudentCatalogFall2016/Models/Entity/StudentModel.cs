using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentCatalogFall2016.Models.Entity
{
    public class StudentModel
    {
        //[indsæt key ved primær nøgle medmindre du har døbt den ID]
        public int StudentModelId { get; set; }

        [Required(ErrorMessage = "You forgot most importantly the first name....")]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required (ErrorMessage ="use only numbers")]
        [Phone]
        [MaxLength(8, ErrorMessage = "Your number is too large, must be smaller")]
        [MinLength(8, ErrorMessage = "Your number is too small, must be larger")]
        public string MobilePhone { get; set; }

        
    }
}