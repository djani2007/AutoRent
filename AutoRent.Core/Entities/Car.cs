using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent.Core.Entities
{
    
        public class Car
        {
          
            public int Id { get; set; }

            [Required]
            public string Make { get; set; } = null!;
        [Required]
        public string Model { get; set; } = null!;

        [Required]
        public string RegNumber { get; set; } = null!;

        //трябва да има precision (за да няма warning/рязане)
        [DataType(DataType.Currency)]
        public decimal PricePerDay { get; set; }


        public bool IsActive { get; set; } = true;
        }
    
     
}
