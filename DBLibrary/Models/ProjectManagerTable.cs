using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBLibrary.Models
{
    public partial class ProjectManagerTable
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectNumber { get; set; }
        public string NetProjectNumber { get; set; }
        public string NcProjectNumber { get; set; }
        public string UnitName { get; set; }
        public DateTime? ApplyTime { get; set; }
        public string SupplyCycle { get; set; }
        public string SupplyAddress { get; set; }
        public string Remarks { get; set; }
        public string BiddingRequirements { get; set; }
    }
}
