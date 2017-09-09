using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        // Cutomer Info
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        [Display(Name = "Date of Birth")]
        [ValidateAgeForMembership]
        public DateTime? Birthdate { get; set; }

        // Membership Info
        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }

        public MembershipType MembershipType { get; set; }
    }
}