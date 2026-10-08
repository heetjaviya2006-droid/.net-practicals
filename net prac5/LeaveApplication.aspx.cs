using System;

namespace prac5
{
    public partial class LeaveApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Get data from Session
                if (Session["StudentName"] != null)
                {
                    txtStudentName.Text =
                        Session["StudentName"].ToString();
                }

                if (Session["StudentEmail"] != null)
                {
                    txtEmail.Text =
                        Session["StudentEmail"].ToString();
                }

                // Get data from Cookie
                if (Request.Cookies["StudentName"] != null)
                {
                    string cookieName =
                        Request.Cookies["StudentName"].Value;

                    txtStudentName.Text = cookieName;
                }
            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtStudentName.Text;
            string rollNo = txtRollNo.Text;
            string email = txtEmail.Text;
            string leaveType = ddlLeaveType.SelectedValue;
            string reason = txtReason.Text;

            string leaveDate = "";

            if (calLeaveDate.SelectedDate != DateTime.MinValue)
            {
                leaveDate =
                    calLeaveDate.SelectedDate.ToString("dd-MM-yyyy");
            }

            // Store leave details in Session
            Session["RollNo"] = rollNo;
            Session["LeaveDate"] = leaveDate;
            Session["LeaveType"] = leaveType;
            Session["Reason"] = reason;

            // Display all submitted details
            lblResult.Text =
                "<h3>Leave Application Submitted Successfully</h3>" +

                "<b>Student Name:</b> " + name + "<br/>" +

                "<b>Roll Number:</b> " + rollNo + "<br/>" +

                "<b>Email:</b> " + email + "<br/>" +

                "<b>Leave Date:</b> " + leaveDate + "<br/>" +

                "<b>Leave Type:</b> " + leaveType + "<br/>" +

                "<b>Reason:</b> " + reason;
        }
    }
}