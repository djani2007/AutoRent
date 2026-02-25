using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent.Core.Entities
{
    public class Rental
    {
       
        public int Id { get; set; }
        
        public int CarId { get; set; }
        [Required]
        public string UserId { get; set; } = null!;
        
        public DateTime From { get; set; }
        
        public DateTime To { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public string Status { get; set; } = "Active";
    }
}
