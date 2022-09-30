using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalReportsInASP.NETWebApp.Models
{
    public class EmployeeInfoEntity
    {
        public long EmployeeID { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string MailID { get; set; } = string.Empty;
        public DateTime DOJ { get; set; }

    }
}