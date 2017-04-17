﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Contact.Core.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
