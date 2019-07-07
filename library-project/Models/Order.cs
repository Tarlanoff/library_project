using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace library_project.Models
{
    class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int BookId { get; set; }
        [DefaultValue(0)]
        public decimal Price { get; set; }
        public Customer Customer { get; set; }
        public Book Book { get; set; }
        public DateTime RentAt { get; set; }
        public DateTime ReturnAt { get; set; }
        public DateTime? ReturnTime { get; set; }
    }
}
