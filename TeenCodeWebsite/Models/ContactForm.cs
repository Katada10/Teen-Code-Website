using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeenCodeWebsite.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email is required"), EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Subject is required")]
        public string Subject { get; set; }

        [Required(ErrorMessage ="Please Enter A Message")]
        public string Message { get; set; }
    }
}