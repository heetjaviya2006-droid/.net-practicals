using System;
using System.Web;

namespace prac5
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (name == "" || email == "" || password == "")
            {
                lblMessage.Text = "Please enter all details.";
                return;
            }

            // Store Name and Email in Session
            Session["StudentName"] = name;
            Session["StudentEmail"] = email;

            // Create Cookie
            HttpCookie studentCookie = new HttpCookie("StudentName");
            studentCookie.Value = name;
            studentCookie.Expires = DateTime.Now.AddDays(7);

            Response.Cookies.Add(studentCookie);

            // Redirect to Leave Application page
            Response.Redirect("LeaveApplication.aspx");
        }
    }
}