using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_project.Models
{
    class Customer
    {

        public int Id { get; set; }
        [MaxLength(20), Required]
        public string Name { get; set; }
        [MaxLength(20), Required]
        public string Surname { get; set; }
        [Required, MaxLength(10), MinLength(10)]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime Birthday { get; set; }
        public DateTime CreateAt { get; set; }

        public List<Order> Orderds { get; set; }
    }
}
