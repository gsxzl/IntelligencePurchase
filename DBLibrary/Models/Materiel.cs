﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBLibrary.Models
{
    public partial class Materiel
    {
        public int Id { get; set; }
        public int? BidId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Company { get; set; }
        public decimal? Number { get; set; }
        public decimal? Weight { get; set; }
        public decimal? FixedPrice { get; set; }
        public string Remarks { get; set; }
    }
}
