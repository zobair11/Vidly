using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribed { get; set; }

        [Display(Name = "Membership Type")]
        public MembershipType membershipType { get; set; }
        
        public byte MembershipTypeId { get; set; }
        public DateTime? Birthday { get; set; }
    }
}