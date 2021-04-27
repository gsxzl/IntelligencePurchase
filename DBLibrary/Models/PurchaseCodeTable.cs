using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBLibrary.Models
{
    public partial class PurchaseCodeTable
    {
        public int Id { get; set; }
        public string HighCode { get; set; }
        public string HighDescribe { get; set; }
        public string MiddleCode { get; set; }
        public string MiddleDescribe { get; set; }
        public string LowCode { get; set; }
        public string LowDescribe { get; set; }
        public string MaterielCode { get; set; }
        public string MaterielDescribe { get; set; }
    }
}
