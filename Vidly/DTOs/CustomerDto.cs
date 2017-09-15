using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class CustomerDto
    {
        // Cutomer Info
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

//        [ValidateAgeForMembership]
        public DateTime? Birthdate { get; set; }

        // Membership Info
        public bool IsSubscribedToNewsletter { get; set; }

        public int MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }
    }
}