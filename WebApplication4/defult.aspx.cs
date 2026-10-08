using System;
using System.Text;

namespace WebApplication4
{
    public partial class defult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Check all validation controls
            Page.Validate();

            if (!Page.IsValid)
            {
                return;
            }

            StringBuilder result = new StringBuilder();

            // Full Name
            result.Append("Full Name: ");
            result.Append(Server.HtmlEncode(TextBox3.Text));
            result.Append("<br />");

            // Email
            result.Append("Email: ");
            result.Append(Server.HtmlEncode(TextBox4.Text));
            result.Append("<br />");

            // Mobile
            result.Append("Mobile: ");
            result.Append(Server.HtmlEncode(TextBox5.Text));
            result.Append("<br />");

            // College
            result.Append("College: ");
            result.Append(Server.HtmlEncode(TextBox6.Text));
            result.Append("<br />");

            // Department
            result.Append("Department: ");

            if (RadioComputer.Checked)
            {
                result.Append("Computer");
            }
            else if (RadioIT.Checked)
            {
                result.Append("IT");
            }
            else if (RadioMechanical.Checked)
            {
                result.Append("Mechanical");
            }
            else if (RadioCivil.Checked)
            {
                result.Append("Civil");
            }
            else
            {
                result.Append("Not Selected");
            }

            result.Append("<br />");

            // Event
            result.Append("Event: ");
            result.Append(
                Server.HtmlEncode(DropDownList1.SelectedItem.Text)
            );
            result.Append("<br />");

            // Gender
            result.Append("Gender: ");

            if (RadioMale.Checked)
            {
                result.Append("Male");
            }
            else if (RadioFemale.Checked)
            {
                result.Append("Female");
            }
            else
            {
                result.Append("Not Selected");
            }

            result.Append("<br />");

            // Skills
            result.Append("Skills: ");

            bool skillSelected = false;

            if (Checkbox1.Checked)
            {
                result.Append("C ");
                skillSelected = true;
            }

            if (Checkbox3.Checked)
            {
                result.Append("C# ");
                skillSelected = true;
            }

            if (Checkbox4.Checked)
            {
                result.Append("Java ");
                skillSelected = true;
            }

            if (Checkbox5.Checked)
            {
                result.Append(".NET ");
                skillSelected = true;
            }

            if (!skillSelected)
            {
                result.Append("None");
            }

            result.Append("<br />");

            // Address
            result.Append("Address: ");
            result.Append(Server.HtmlEncode(TextArea1.Text));
            result.Append("<br />");

            // Terms
            result.Append("Terms Accepted: ");

            if (Checkbox6.Checked)
            {
                result.Append("Yes");
            }
            else
            {
                result.Append("No");
            }

            // Display all data in DBResult
            DBResult.Text = result.ToString();
        }
    }
}