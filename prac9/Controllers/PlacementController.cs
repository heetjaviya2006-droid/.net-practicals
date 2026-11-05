using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Mvc;
using Practical9.Models;


namespace Practical9.Controllers
{
    public class PlacementController : Controller
    {
    
        
            string cs = ConfigurationManager
                    .ConnectionStrings["cs"].ConnectionString;
        public ActionResult Index()
        {
            PlacementDashboard dashboard = new PlacementDashboard();

            dashboard.Students = new List<Student>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                // Total Students
                string q1 = "SELECT COUNT(*) FROM Students";

                SqlCommand cmd1 = new SqlCommand(q1, con);

                dashboard.TotalStudents =
                    Convert.ToInt32(cmd1.ExecuteScalar());


                // Placed Students
                string q2 = "SELECT COUNT(*) FROM Students WHERE Status='Placed'";

                SqlCommand cmd2 = new SqlCommand(q2, con);

                dashboard.PlacedStudents =
                    Convert.ToInt32(cmd2.ExecuteScalar());


                // Total Companies
                string q3 = @"SELECT COUNT(DISTINCT CompanyName)
                              FROM Students
                              WHERE CompanyName IS NOT NULL";

                SqlCommand cmd3 = new SqlCommand(q3, con);

                dashboard.TotalCompanies =
                    Convert.ToInt32(cmd3.ExecuteScalar());


                // Placement Percentage
                if (dashboard.TotalStudents > 0)
                {
                    dashboard.PlacementPercentage =
                        (decimal)dashboard.PlacedStudents /
                        dashboard.TotalStudents * 100;
                }


                // Get Student Records
                string q4 = "SELECT * FROM Students";

                SqlCommand cmd4 = new SqlCommand(q4, con);

                SqlDataReader dr = cmd4.ExecuteReader();

                while (dr.Read())
                {
                    Student s = new Student();

                    s.StudentId = Convert.ToInt32(dr["StudentId"]);
                    s.StudentName = dr["StudentName"].ToString();
                    s.Branch = dr["Branch"].ToString();
                    s.CompanyName = dr["CompanyName"] == DBNull.Value
                        ? "Not Assigned"
                        : dr["CompanyName"].ToString();

                    s.Package = Convert.ToDecimal(dr["Package"]);
                    s.Status = dr["Status"].ToString();

                    dashboard.Students.Add(s);
                }

                dr.Close();
            }

            return View(dashboard);
        }
    }
}