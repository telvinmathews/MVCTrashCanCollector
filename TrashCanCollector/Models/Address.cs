using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCanCollector.Models
{
    public class Address
    {
        [Key]
        public int AdressId { get; set; }
        public string StreetName { get; set; }
        public int ZipCode { get; set; }
        public string State { get; set; }
    }
}
