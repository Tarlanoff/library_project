﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_project.Models
{
    class Admin
    {
        public int Id { get; set; }
        [MaxLength(20), Required]
        public string Name { get; set; }
        [MaxLength(20), Required]
        public string Surname { get; set; }
        [MaxLength(50), Required]
        public string Nickname { get; set; }
        [MaxLength(20), Required]
        public string Password { get; set; }
    }
}
