using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EfCodeFirstApp.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        public int CarModelId { get; set; }
        public decimal Price { get; set; }
        public virtual CarModel CarModel { get; set; }
    }
}
