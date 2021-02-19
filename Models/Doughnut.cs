using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoughnutsFactory.Models
{
    public class Doughnut
    {
        public int ID { get; set; }
        [Display(Name = "Title")]
        public string Type { get; set; }
        public string Flavours { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
    }
}