using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBLibrary.Models
{
    public partial class DemandBudgetTable
    {
        public int Id { get; set; }
        public int? BudgetId { get; set; }
        public int? DemandId { get; set; }
        public int? MaterielId { get; set; }
        public decimal? SimilarityBudgetDemand { get; set; }
        public decimal? Similarity2DemandBid { get; set; }
        public int? ResultOfNumber { get; set; }
        public ulong? IgnoreResultOfNumber { get; set; }
        public int? ResultOfPirce { get; set; }
        public ulong? IgnoreResultOfPirce { get; set; }
        public int? ResultOfBidPirce { get; set; }
        public ulong? IgnoreResultOfBidPirce { get; set; }
        public int? ExceptionOfType { get; set; }
        public string ModifyType { get; set; }
    }
}
