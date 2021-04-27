using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBLibrary.Models
{
    public partial class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string FullPath { get; set; }
        public ulong? IfDelete { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreateTm { get; set; }
        public string CreateEmp { get; set; }
        public DateTime? UpdateTm { get; set; }
        public string UpdateEmp { get; set; }
    }
}
