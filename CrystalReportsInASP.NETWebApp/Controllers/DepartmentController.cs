using CrystalReportsInASP.NETWebApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CrystalReportsInASP.NETWebApp.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult DepartmentReport()
        {
            return View();
        }

        public void GenerateDepartmentReport()
        {
            ReportParams<Department> objReportParams = new ReportParams<Department>();

            objReportParams.DataSource = GetAllEmployee();
            objReportParams.ReportTitle = "Department Info Report";
            objReportParams.RptFileName = "DepartmentReport.rpt";
            this.HttpContext.Session["ReportType"] = "DepartmentReport";
            this.HttpContext.Session["ReportParam"] = objReportParams;
        }

        public List<Department> GetAllEmployee()
        {
            string constr = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM  Departments";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);

            var list = ConvertDataTableToList<Department>(dt);

            return list;
        }

        private static List<T> ConvertDataTableToList<T>(DataTable dt)
        {

            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;

                }

            }

            return obj;
        }

    }
}