using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBLibrary.Models
{
    public partial class Supplier
    {
        public int Id { get; set; }
        public int? BidId { get; set; }
        public int? BiddingModeId { get; set; }
        public string Name { get; set; }
        public string LegalPerson { get; set; }
        public string ContactInformation { get; set; }
        public string AuthorizedPersonnel { get; set; }
        public string ContactInformation2 { get; set; }
        public string Email { get; set; }
        public string RecommendCompany { get; set; }
    }
}
