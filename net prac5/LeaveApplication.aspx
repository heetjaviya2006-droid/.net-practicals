<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeaveApplication.aspx.cs" Inherits="prac5.LeaveApplication" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <title>Leave Application</title>

    <style>

        body {
            font-family: Arial;
            background-color: #f2f2f2;
        }

        .container {
            width: 600px;
            margin: 40px auto;
            padding: 30px;
            background-color: white;
            border-radius: 10px;
            box-shadow: 0 0 10px gray;
        }

        h2 {
            text-align: center;
        }

        .textbox,
        .dropdown,
        .calendar {
            width: 100%;
            padding: 10px;
            margin: 8px 0 15px 0;
            box-sizing: border-box;
        }

        .button {
            width: 100%;
            padding: 12px;
            background-color: green;
            color: white;
            border: none;
            cursor: pointer;
        }

        .result {
            margin-top: 20px;
            padding: 15px;
            background-color: #eeeeee;
        }

    </style>

</head>

<body>

<form id="form1" runat="server">

<div class="container">

    <h2>Student Leave Application</h2>

    <asp:Label ID="lblStudentName"
        runat="server"
        Text="Student Name">
    </asp:Label>

    <asp:TextBox ID="txtStudentName"
        runat="server"
        CssClass="textbox">
    </asp:TextBox>


    <asp:Label ID="lblRollNo"
        runat="server"
        Text="Roll Number">
    </asp:Label>

    <asp:TextBox ID="txtRollNo"
        runat="server"
        CssClass="textbox">
    </asp:TextBox>


    <asp:Label ID="lblEmail"
        runat="server"
        Text="Email">
    </asp:Label>

    <asp:TextBox ID="txtEmail"
        runat="server"
        CssClass="textbox">
    </asp:TextBox>


    <asp:Label ID="lblLeaveDate"
        runat="server"
        Text="Leave Date">
    </asp:Label>

    <asp:Calendar ID="calLeaveDate"
        runat="server"
        CssClass="calendar">
    </asp:Calendar>


    <asp:Label ID="lblLeaveType"
        runat="server"
        Text="Type of Leave">
    </asp:Label>

    <asp:DropDownList ID="ddlLeaveType"
        runat="server"
        CssClass="dropdown">

        <asp:ListItem Text="-- Select Leave Type --"
            Value="">
        </asp:ListItem>

        <asp:ListItem Text="Sick Leave"
            Value="Sick Leave">
        </asp:ListItem>

        <asp:ListItem Text="Casual Leave"
            Value="Casual Leave">
        </asp:ListItem>

        <asp:ListItem Text="Emergency Leave"
            Value="Emergency Leave">
        </asp:ListItem>

        <asp:ListItem Text="Personal Leave"
            Value="Personal Leave">
        </asp:ListItem>

    </asp:DropDownList>


    <asp:Label ID="lblReason"
        runat="server"
        Text="Reason for Leave">
    </asp:Label>

    <asp:TextBox ID="txtReason"
        runat="server"
        CssClass="textbox"
        TextMode="MultiLine"
        Rows="5">
    </asp:TextBox>


    <asp:Button ID="btnSubmit"
        runat="server"
        Text="Submit Leave Application"
        CssClass="button"
        OnClick="btnSubmit_Click" />

    <div class="result">

        <asp:Label ID="lblResult"
            runat="server">
        </asp:Label>

    </div>

</div>

</form>

</body>
</html>