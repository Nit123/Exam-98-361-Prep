<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebPage1.aspx.cs" Inherits="Scenario4_2.WebPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
           Name: <asp:TextBox ID="TextBox1" runat="server" Text="Enter Name" /> <br />
           Email Address: <asp:TextBox ID ="TextBox2" runat="server" Text="Enter Email" /><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><br />
        </p>
    </form>
</body>
</html>
