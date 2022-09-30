using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrystalReportsInASP.NETWebApp.Report
{
    public partial class DepartmentReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        public void LoadReport()
        {
            var reportParam = (dynamic)HttpContext.Current.Session["ReportParam"];
            if (reportParam != null)
            {
                ReportDocument rd = new ReportDocument();
                string path = Server.MapPath("~") + "Report\\Rpt\\" + reportParam.RptFileName;
                var dataSource = reportParam.DataSource;
                rd.Load(path);
                rd.SetDataSource(dataSource);
                rd.SetParameterValue("@rptName", reportParam.ReportTitle);
                CrystalReportViewer1.ReportSource = rd;
            }
            else
            {
                Response.Redirect("~/Department/DepartmentReport");
            }


        }

    }
}