using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventRegistration.Shared.Domain
{
    public class Category :BaseDomainModel
    {


        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Category name does not meet length requirements")]
        public string Categoryname { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Category description does not meet length requirements")]
        public string Categorydescription { get; set; }


    }
}
