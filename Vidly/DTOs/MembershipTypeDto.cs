﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.DTOs
{
    public class MembershipTypeDto
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public byte DiscountRate { get; set; }
    }
}