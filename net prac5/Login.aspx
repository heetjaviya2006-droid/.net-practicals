<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="prac5.Login" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Student Login</title>

    <style>
        body {
            font-family: Arial;
            background-color: #f2f2f2;
        }

        .container {
            width: 400px;
            margin: 80px auto;
            padding: 30px;
            background-color: white;
            border-radius: 10px;
            box-shadow: 0 0 10px gray;
        }

        h2 {
            text-align: center;
        }

        .textbox {
            width: 100%;
            padding: 10px;
            margin: 8px 0 15px 0;
            box-sizing: border-box;
        }

        .button {
            width: 100%;
            padding: 10px;
            background-color: #007bff;
            color: white;
            border: none;
            cursor: pointer;
        }

        .message {
            color: red;
            text-align: center;
        }
    </style>
</head>

<body>

<form id="form1" runat="server">

    <div class="container">

        <h2>Student Login</h2>

        <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>

        <asp:TextBox ID="txtName"
            runat="server"
            CssClass="textbox">
        </asp:TextBox>

        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>

        <asp:TextBox ID="txtEmail"
            runat="server"
            CssClass="textbox"
            TextMode="Email">
        </asp:TextBox>

        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>

        <asp:TextBox ID="txtPassword"
            runat="server"
            CssClass="textbox"
            TextMode="Password">
        </asp:TextBox>

        <asp:Button ID="btnLogin"
            runat="server"
            Text="Login"
            CssClass="button"
            OnClick="btnLogin_Click" />

        <br /><br />

        <asp:Label ID="lblMessage"
            runat="server"
            CssClass="message">
        </asp:Label>

    </div>

</form>

</body>
</html>
