<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="defult.aspx.cs" Inherits="WebApplication4.defult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>ONLINE EVENT REGISTRATION</title>

    <style type="text/css">

        .auto-style1 {
            width: 148px;
            text-align: left;
        }

        .auto-style2 {
            width: 147px;
        }

        .auto-style5 {
            width: 837px;
        }

        .auto-style6 {
            width: 277px;
        }

        .auto-style7 {
            width: 152px;
        }

        .auto-style9 {
            width: 147px;
            height: 33px;
        }

        .auto-style10 {
            width: 316px;
            height: 33px;
        }

        .auto-style11 {
            height: 33px;
        }

        .auto-style12 {
            width: 270px;
        }

        .auto-style13 {
            width: 316px;
        }
        .auto-style14 {
            width: 266px;
        }

    </style>

</head>

<body>

<form id="form1" runat="server">

    <h1>ONLINE EVENT REGISTRATION</h1>

    <!-- FULL NAME, EMAIL, MOBILE -->

    <table style="width:100%;">

        <!-- Full Name -->

        <tr>

            <td class="auto-style1">
                Full Name
            </td>

            <td class="auto-style6">

                <asp:TextBox
                    ID="TextBox3"
                    runat="server">
                </asp:TextBox>

            </td>

            <td class="auto-style5">

                <asp:RequiredFieldValidator
                    ID="RequiredFieldValidator1"
                    runat="server"
                    ControlToValidate="TextBox3"
                    ErrorMessage="Enter Name"
                    ForeColor="Red"
                    Display="Dynamic">
                </asp:RequiredFieldValidator>

            </td>

        </tr>


        <!-- Email -->

        <tr>

            <td class="auto-style1">
                Email
            </td>

            <td class="auto-style6">

                <asp:TextBox
                    ID="TextBox4"
                    runat="server">
                </asp:TextBox>

            </td>

            <td class="auto-style5">

                <asp:RequiredFieldValidator
                    ID="RequiredFieldValidator2"
                    runat="server"
                    ControlToValidate="TextBox4"
                    ErrorMessage="Enter Email"
                    ForeColor="Red"
                    Display="Dynamic">
                </asp:RequiredFieldValidator>

                <br />

                <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator1"
                    runat="server"
                    ControlToValidate="TextBox4"
                    ErrorMessage="Invalid Email"
                    ForeColor="Red"
                    Display="Dynamic"
                    ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$">
                </asp:RegularExpressionValidator>

            </td>

        </tr>


        <!-- Mobile -->

        <tr>

            <td class="auto-style1">
                Mobile
            </td>

            <td class="auto-style6">

                <asp:TextBox
                    ID="TextBox5"
                    runat="server">
                </asp:TextBox>

            </td>

            <td class="auto-style5">

                <asp:RequiredFieldValidator
                    ID="RequiredFieldValidator3"
                    runat="server"
                    ControlToValidate="TextBox5"
                    ErrorMessage="Enter Mobile"
                    ForeColor="Red"
                    Display="Dynamic">
                </asp:RequiredFieldValidator>

                <br />

                <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator2"
                    runat="server"
                    ControlToValidate="TextBox5"
                    ErrorMessage="Enter 10 Digit Mobile"
                    ForeColor="Red"
                    Display="Dynamic"
                    ValidationExpression="^[0-9]{10}$">
                </asp:RegularExpressionValidator>

            </td>

        </tr>

    </table>


    <!-- COLLEGE, DEPARTMENT, EVENT -->

    <table style="width:100%;">

        <!-- College -->

        <tr>

            <td class="auto-style9">
                College
            </td>

            <td class="auto-style10">

                <asp:TextBox
                    ID="TextBox6"
                    runat="server">
                </asp:TextBox>

            </td>

            <td class="auto-style11">

                <asp:RequiredFieldValidator
                    ID="RequiredFieldValidator4"
                    runat="server"
                    ControlToValidate="TextBox6"
                    ErrorMessage="Enter College"
                    ForeColor="Red"
                    Display="Dynamic">
                </asp:RequiredFieldValidator>

            </td>

        </tr>


        <!-- Department -->

        <tr>

            <td class="auto-style2">
                Department
            </td>

            <td class="auto-style13">

                <asp:RadioButton
                    ID="RadioComputer"
                    runat="server"
                    GroupName="Department"
                    Text="Computer" />

                <br />

                <asp:RadioButton
                    ID="RadioIT"
                    runat="server"
                    GroupName="Department"
                    Text="IT" />

                <br />

                <asp:RadioButton
                    ID="RadioMechanical"
                    runat="server"
                    GroupName="Department"
                    Text="Mechanical" />

                <br />

                <asp:RadioButton
                    ID="RadioCivil"
                    runat="server"
                    GroupName="Department"
                    Text="Civil" />

            </td>

            <td>
                &nbsp;
            </td>

        </tr>



        <tr>

            <td class="auto-style2">
                Event
            </td>

            <td class="auto-style13">

                <asp:DropDownList
                    ID="DropDownList1"
                    runat="server">

                    <asp:ListItem>Select Event</asp:ListItem>
                    <asp:ListItem>PT</asp:ListItem>
                    <asp:ListItem>YOGA</asp:ListItem>
                    <asp:ListItem>LEB</asp:ListItem>
                    <asp:ListItem>CLASS</asp:ListItem>

                </asp:DropDownList>

            </td>

            <td>
                &nbsp;
            </td>

        </tr>

    </table>


    <!-- GENDER, SKILLS, ADDRESS -->

    <table style="width:100%;">

        <!-- Gender -->

        <tr>

            <td class="auto-style7">
                Gender
            </td>

            <td class="auto-style14">

                <asp:RadioButton
                    ID="RadioMale"
                    runat="server"
                    GroupName="Gender"
                    Text="Male" />

                <asp:RadioButton
                    ID="RadioFemale"
                    runat="server"
                    GroupName="Gender"
                    Text="Female" />

            </td>

            <td>
                &nbsp;
            </td>

        </tr>


        <!-- Skills -->

        <tr>

            <td class="auto-style7">
                Skills
            </td>

            <td class="auto-style14">

                <asp:CheckBox
                    ID="Checkbox1"
                    runat="server"
                    Text="C" />

                <br />

                <asp:CheckBox
                    ID="Checkbox3"
                    runat="server"
                    Text="C#" />

                <br />

                <asp:CheckBox
                    ID="Checkbox4"
                    runat="server"
                    Text="Java" />

                <br />

                <asp:CheckBox
                    ID="Checkbox5"
                    runat="server"
                    Text=".NET" />

            </td>

            <td>
                &nbsp;
            </td>

        </tr>


        <!-- Address -->

        <tr>

            <td class="auto-style7">
                Address
            </td>

            <td class="auto-style14">

                <asp:TextBox
                    ID="TextArea1"
                    runat="server"
                    TextMode="MultiLine"
                    Rows="4"
                    Columns="25">
                </asp:TextBox>

            </td>

            <td>
                &nbsp;
            </td>

        </tr>

    </table>
    <!-- TERMS, REGISTER, DBRESULT -->
    <table style="width:100%;">
        <!-- Terms -->
        <tr>
            <td class="auto-style7">
                Terms
            </td>
            <td class="auto-style12">
                <asp:CheckBox ID="Checkbox6" runat="server" Text="I Accept Terms &amp; Conditions" />
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <!-- Register Button -->
        <tr>
            <td class="auto-style7">
                &nbsp;
            </td>

            <td class="auto-style12">

                <asp:Button
                    ID="Button1"
                    runat="server"
                    Text="Register"
                    OnClick="Button1_Click" />

            </td>

            <td>
                &nbsp;
            </td>

        </tr>


        <!-- DBResult -->

        <tr>

            <td class="auto-style7">
                &nbsp;
            </td>

            <td class="auto-style12">

                <asp:Label
                    ID="DBResult"
                    runat="server"
                    Text="[DBResult]">
                </asp:Label>

            </td>

            <td>
                &nbsp;
            </td>

        </tr>

    </table>

</form>

</body>
</html>