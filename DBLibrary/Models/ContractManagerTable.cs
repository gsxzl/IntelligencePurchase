using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBLibrary.Models
{
    public partial class ContractManagerTable
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public decimal? AdvanceCharge { get; set; }
        public string ContractType { get; set; }
        public string VersionNumber { get; set; }
        public DateTime? ContractSignTime { get; set; }
        public DateTime? PlanStartTime { get; set; }
        public DateTime? SendTime { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public string PurchaseType { get; set; }
        public string SupplierName { get; set; }
        public string Intermediary { get; set; }
        public string MaterialCompany { get; set; }
        public string Department { get; set; }
        public string Person { get; set; }
        public string ContractState { get; set; }
        public string ProjectNumber { get; set; }
        public DateTime? CheckTime { get; set; }
        public DateTime? ObjectionTime { get; set; }
        public decimal? TradingServices { get; set; }
        public decimal? PaymentProportion { get; set; }
        public string CostBear35 { get; set; }
        public string Remarks { get; set; }
        public ulong? IfContractBuySel { get; set; }
        public DateTime? JointTrialTime { get; set; }
        public decimal? GeneralContractor { get; set; }
        public string ManufacturerContacts { get; set; }
        public string ManufacturerPhone { get; set; }
        public string Producer { get; set; }
        public DateTime? PreparationTime { get; set; }
    }
}
