using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCanCollector.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string WeeklyPickUpDay { get; set; }
        public string OneTimePickUp { get; set; }
        public string StartSubscriptionDate { get; set; }
        public string EndSubscriptionDate { get; set; }
        public int AddressZipCode { get; set; }
        public string AdrressStreet { get; set; }
        public string AddressState { get; set; }
        public int TrashPickUpFee { get; set; } 

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        
    }
}
