using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBLibrary.Models
{
    public partial class ProjectBiddingTable
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? BidId { get; set; }
        public int? BiddingModeId { get; set; }
        public string SupplierName1 { get; set; }
        public string SupplierName2 { get; set; }
        public string SupplierName3 { get; set; }
        public string SupplierName4 { get; set; }
        public decimal? SupplierPrice1 { get; set; }
        public decimal? SupplierPrice2 { get; set; }
        public decimal? SupplierPrice3 { get; set; }
        public decimal? SupplierPrice4 { get; set; }
    }
}
