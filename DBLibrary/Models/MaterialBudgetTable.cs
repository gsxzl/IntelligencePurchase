using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBLibrary.Models
{
    public partial class MaterialBudgetTable
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public string MaterialName { get; set; }
        public string Type { get; set; }
        public string Company { get; set; }
        public decimal? Number { get; set; }
        public decimal? TaxPrice { get; set; }
        public decimal? TaxTotalPrice { get; set; }
        public decimal? Similarity { get; set; }
    }
}
