using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBLibrary.Models
{
    public partial class PriceTable
    {
        public int Id { get; set; }
        public int? MaterielId { get; set; }
        public decimal? BidPrice { get; set; }
        public DateTime? PriceTime { get; set; }
        public string Remarks { get; set; }
    }
}
