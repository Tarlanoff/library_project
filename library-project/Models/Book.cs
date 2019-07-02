using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace library_project.Models
{
    class Book
    {
        public int Id { get; set; }
        [MaxLength(20), Required]
        public string Name { get; set; }
        
        [Required]
        public decimal PricePerMonth { get; set; }
        [Required]
        public int Count { get; set; }
        public List<Order> Orders { get; set; }
    }

}

