using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBLibrary.Models
{
    public partial class UserTable
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserNumber { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string PasswordKey { get; set; }
        public int? UserGender { get; set; }
        public int? UserState { get; set; }
        public int? OrganizationId { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? CreateTm { get; set; }
        public string CreateEmp { get; set; }
        public DateTime? UpdateTm { get; set; }
        public string UpdateEmp { get; set; }
    }
}
