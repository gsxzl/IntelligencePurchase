using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBLibrary.Models
{
    public partial class IntelligencePurchaseContext : DbContext
    {
        public IntelligencePurchaseContext()
        {
        }

        public IntelligencePurchaseContext(DbContextOptions<IntelligencePurchaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BidSection> BidSection { get; set; }
        public virtual DbSet<BiddingMode> BiddingMode { get; set; }
        public virtual DbSet<ContractManagerTable> ContractManagerTable { get; set; }
        public virtual DbSet<ContractMaterielTable> ContractMaterielTable { get; set; }
        public virtual DbSet<DemandBudgetTable> DemandBudgetTable { get; set; }
        public virtual DbSet<Logrecord> Logrecord { get; set; }
        public virtual DbSet<MaterialBudgetTable> MaterialBudgetTable { get; set; }
        public virtual DbSet<MaterialDemandTable> MaterialDemandTable { get; set; }
        public virtual DbSet<Materiel> Materiel { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<PriceTable> PriceTable { get; set; }
        public virtual DbSet<ProjectBiddingTable> ProjectBiddingTable { get; set; }
        public virtual DbSet<ProjectManagerTable> ProjectManagerTable { get; set; }
        public virtual DbSet<PurchaseCodeTable> PurchaseCodeTable { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleMenu> RoleMenu { get; set; }
        public virtual DbSet<RoleUser> RoleUser { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<UserTable> UserTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=DESKTOP-Q574UBG;port=3306;user=root;password=root;database=IntelligencePurchase", x => x.ServerVersion("5.7.30-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BidSection>(entity =>
            {
                entity.ToTable("bid_section");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BiddingMode>(entity =>
            {
                entity.ToTable("bidding_mode");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ContractManagerTable>(entity =>
            {
                entity.ToTable("contract_manager_table");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdvanceCharge)
                    .HasColumnName("Advance_Charge")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.CheckTime)
                    .HasColumnName("Check_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company_Name")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContractCode)
                    .HasColumnName("Contract_Code")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContractName)
                    .HasColumnName("Contract_Name")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContractSignTime)
                    .HasColumnName("Contract_Sign_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractState)
                    .HasColumnName("Contract_State")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContractType)
                    .HasColumnName("Contract_Type")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CostBear35)
                    .HasColumnName("Cost_Bear_35")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Department)
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GeneralContractor)
                    .HasColumnName("General_Contractor")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.IfContractBuySel)
                    .HasColumnName("If_Contract_BuySel")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Intermediary)
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JointTrialTime)
                    .HasColumnName("Joint_Trial_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ManufacturerContacts)
                    .HasColumnName("Manufacturer_Contacts")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ManufacturerPhone)
                    .HasColumnName("Manufacturer_Phone")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaterialCompany)
                    .HasColumnName("Material_Company")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObjectionTime)
                    .HasColumnName("Objection_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentProportion)
                    .HasColumnName("Payment_Proportion")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Person)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlanStartTime)
                    .HasColumnName("Plan_Start_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreparationTime)
                    .HasColumnName("Preparation_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Producer)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectCode)
                    .HasColumnName("Project_Code")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectName)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectNumber)
                    .HasColumnName("Project_Number")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaseType)
                    .HasColumnName("Purchase_Type")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SendTime)
                    .HasColumnName("Send_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.SupplierName)
                    .HasColumnName("Supplier_Name")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TradingServices)
                    .HasColumnName("Trading_services")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.VersionNumber)
                    .HasColumnName("Version_Number")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ContractMaterielTable>(entity =>
            {
                entity.ToTable("contract_materiel_table");

                entity.HasIndex(e => e.ContractId)
                    .HasName("FK_CONTRACT_REFERENCE_CONTRACT");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Company)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LeasePrice)
                    .HasColumnName("Lease_Price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.MaterialName)
                    .HasColumnName("Material_Name")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Month).HasColumnType("decimal(10,0)");

                entity.Property(e => e.Number).HasColumnType("decimal(10,0)");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("Serial_Number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StockCode)
                    .HasColumnName("Stock_Code")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaxNumber)
                    .HasColumnName("Tax_Number")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.TaxPrice)
                    .HasColumnName("Tax_Price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.TaxRate)
                    .HasColumnName("Tax_Rate")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.TaxTotalPrice)
                    .HasColumnName("Tax_Total_Price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<DemandBudgetTable>(entity =>
            {
                entity.ToTable("demand_budget_table");

                entity.HasIndex(e => e.BudgetId)
                    .HasName("FK_DEMAND_B_REFERENCE_MATERIAL");

                entity.HasIndex(e => e.DemandId)
                    .HasName("FK_DEMAND_B_REFERENCE_MATERIAL2");

                entity.HasIndex(e => e.MaterielId)
                    .HasName("FK_DEMAND_B_REFERENCE_MATERIEL3");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BudgetId)
                    .HasColumnName("Budget_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DemandId)
                    .HasColumnName("Demand_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExceptionOfType)
                    .HasColumnName("Exception_Of_Type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IgnoreResultOfBidPirce)
                    .HasColumnName("Ignore_Result_Of_BidPirce")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.IgnoreResultOfNumber)
                    .HasColumnName("Ignore_Result_Of_Number")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.IgnoreResultOfPirce)
                    .HasColumnName("Ignore_Result_Of_Pirce")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.MaterielId)
                    .HasColumnName("Materiel_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifyType)
                    .HasColumnName("Modify_Type")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResultOfBidPirce)
                    .HasColumnName("Result_Of_BidPirce")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResultOfNumber)
                    .HasColumnName("Result_Of_Number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResultOfPirce)
                    .HasColumnName("Result_Of_Pirce")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Similarity2DemandBid)
                    .HasColumnName("Similarity2_Demand_Bid")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.SimilarityBudgetDemand)
                    .HasColumnName("Similarity_Budget_Demand")
                    .HasColumnType("decimal(10,0)");
            });

            modelBuilder.Entity<Logrecord>(entity =>
            {
                entity.ToTable("logrecord");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Exception)
                    .HasColumnName("exception")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LevelName)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<MaterialBudgetTable>(entity =>
            {
                entity.ToTable("material_budget_table");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("FK_MATERIAL_REFERENCE_PROJECT_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Company)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaterialName)
                    .HasColumnName("Material_Name")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Number).HasColumnType("decimal(10,0)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("Project_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Similarity).HasColumnType("decimal(10,0)");

                entity.Property(e => e.TaxPrice)
                    .HasColumnName("Tax_Price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.TaxTotalPrice)
                    .HasColumnName("Tax_Total_Price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<MaterialDemandTable>(entity =>
            {
                entity.ToTable("material_demand_table");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("FK_MATERIAL_REFERENCE_PROJECT_2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BidName)
                    .HasColumnName("Bid_Name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Company)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaterialCode)
                    .HasColumnName("Material_Code")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaterialName)
                    .HasColumnName("Material_Name")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Number).HasColumnType("decimal(10,0)");

                entity.Property(e => e.Price).HasColumnType("decimal(10,0)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("Project_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Similarity).HasColumnType("decimal(10,0)");

                entity.Property(e => e.TaxPrice)
                    .HasColumnName("Tax_Price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.TaxTotalPrice)
                    .HasColumnName("Tax_Total_Price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("Total_Price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Materiel>(entity =>
            {
                entity.ToTable("materiel");

                entity.HasIndex(e => e.BidId)
                    .HasName("FK_MATERIEL_REFERENCE_BID_SECT");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BidId)
                    .HasColumnName("Bid_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Company)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FixedPrice)
                    .HasColumnName("Fixed_Price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Number).HasColumnType("decimal(10,0)");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Weight).HasColumnType("decimal(10,0)");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateEmp)
                    .HasColumnName("create_emp")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTm)
                    .HasColumnName("create_tm")
                    .HasColumnType("datetime");

                entity.Property(e => e.FullPath)
                    .HasColumnName("Full_Path")
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MenuState).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NodesNumber)
                    .HasColumnName("Nodes_Number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateEmp)
                    .HasColumnName("update_emp")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateTm)
                    .HasColumnName("update_tm")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.ToTable("organization");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateEmp)
                    .HasColumnName("create_emp")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTm)
                    .HasColumnName("create_tm")
                    .HasColumnType("datetime");

                entity.Property(e => e.FullPath)
                    .HasColumnName("Full_Path")
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IfDelete).HasColumnType("bit(1)");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateEmp)
                    .HasColumnName("update_emp")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateTm)
                    .HasColumnName("update_tm")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PriceTable>(entity =>
            {
                entity.ToTable("price_table");

                entity.HasIndex(e => e.MaterielId)
                    .HasName("FK_PRICE_TA_REFERENCE_MATERIEL");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BidPrice)
                    .HasColumnName("Bid_Price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.MaterielId)
                    .HasColumnName("Materiel_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PriceTime)
                    .HasColumnName("Price_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ProjectBiddingTable>(entity =>
            {
                entity.ToTable("project_bidding_table");

                entity.HasIndex(e => e.BidId)
                    .HasName("FK_PROJECT__REFERENCE_BID_SECT");

                entity.HasIndex(e => e.BiddingModeId)
                    .HasName("FK_PROJECT__REFERENCE_BIDDING_");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("FK_PROJECT__REFERENCE_PROJECT_");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BidId)
                    .HasColumnName("Bid_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BiddingModeId)
                    .HasColumnName("Bidding_Mode_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("Project_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SupplierName1)
                    .HasColumnName("Supplier_Name_1")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierName2)
                    .HasColumnName("Supplier_Name_2")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierName3)
                    .HasColumnName("Supplier_Name_3")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierName4)
                    .HasColumnName("Supplier_Name_4")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierPrice1)
                    .HasColumnName("Supplier_Price_1")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.SupplierPrice2)
                    .HasColumnName("Supplier_Price_2")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.SupplierPrice3)
                    .HasColumnName("Supplier_Price_3")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.SupplierPrice4)
                    .HasColumnName("Supplier_Price_4")
                    .HasColumnType("decimal(10,0)");
            });

            modelBuilder.Entity<ProjectManagerTable>(entity =>
            {
                entity.ToTable("project_manager_table");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApplyTime)
                    .HasColumnName("Apply_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.BiddingRequirements)
                    .HasColumnName("Bidding_Requirements")
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NcProjectNumber)
                    .HasColumnName("NC_ProjectNumber")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NetProjectNumber)
                    .HasColumnName("Net_ProjectNumber")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectName)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectNumber)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplyAddress)
                    .HasColumnName("Supply_Address")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplyCycle)
                    .HasColumnName("Supply_Cycle")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UnitName)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PurchaseCodeTable>(entity =>
            {
                entity.ToTable("purchase_code_table");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HighCode)
                    .HasColumnName("High_Code")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HighDescribe)
                    .HasColumnName("High_Describe")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LowCode)
                    .HasColumnName("Low_Code")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LowDescribe)
                    .HasColumnName("Low_Describe")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaterielCode)
                    .HasColumnName("Materiel_Code")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaterielDescribe)
                    .HasColumnName("Materiel_Describe")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MiddleCode)
                    .HasColumnName("Middle_Code")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MiddleDescribe)
                    .HasColumnName("Middle_Describe")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateEmp)
                    .HasColumnName("create_emp")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTm)
                    .HasColumnName("create_tm")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateEmp)
                    .HasColumnName("update_emp")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateTm)
                    .HasColumnName("update_tm")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<RoleMenu>(entity =>
            {
                entity.ToTable("role_menu");

                entity.HasIndex(e => e.MenuId)
                    .HasName("FK_ROLE_MEN_REFERENCE_MENU");

                entity.HasIndex(e => e.RoleId)
                    .HasName("FK_ROLE_MEN_REFERENCE_ROLE");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MenuId)
                    .HasColumnName("Menu_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoleId)
                    .HasColumnName("Role_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<RoleUser>(entity =>
            {
                entity.ToTable("role_user");

                entity.HasIndex(e => e.RoleId)
                    .HasName("FK_ROLE_USE_REFERENCE_ROLE");

                entity.HasIndex(e => e.UserId)
                    .HasName("FK_ROLE_USE_REFERENCE_USER");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoleId)
                    .HasColumnName("Role_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("supplier");

                entity.HasIndex(e => e.BidId)
                    .HasName("FK_SUPPLIER_REFERENCE_BID_SECT");

                entity.HasIndex(e => e.BiddingModeId)
                    .HasName("FK_SUPPLIER_REFERENCE_BIDDING_");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AuthorizedPersonnel)
                    .HasColumnName("Authorized_Personnel")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BidId)
                    .HasColumnName("Bid_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BiddingModeId)
                    .HasColumnName("Bidding_Mode_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactInformation)
                    .HasColumnName("Contact_Information")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContactInformation2)
                    .HasColumnName("Contact_Information2")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LegalPerson)
                    .HasColumnName("Legal_Person")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RecommendCompany)
                    .HasColumnName("Recommend_Company")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.ToTable("user_table");

                entity.HasIndex(e => e.OrganizationId)
                    .HasName("FK_USER_REFERENCE_ORGANIZA");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Account)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateEmp)
                    .HasColumnName("create_emp")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTm)
                    .HasColumnName("create_tm")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrganizationId)
                    .HasColumnName("Organization_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Password)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PasswordKey)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateEmp)
                    .HasColumnName("update_emp")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateTm)
                    .HasColumnName("update_tm")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserGender)
                    .HasColumnName("User_Gender")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserName)
                    .HasColumnName("User_Name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserNumber)
                    .HasColumnName("User_Number")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserState)
                    .HasColumnName("User_State")
                    .HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
