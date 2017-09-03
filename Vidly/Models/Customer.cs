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

        public DateTime? Birthdate { get; set; }

        // Membership Info
        public bool IsSubscribedToNewsletter { get; set; }

        public int MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }
    }
}