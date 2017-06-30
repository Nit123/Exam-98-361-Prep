<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetterForm.aspx.cs" Inherits="Scenario4_4.GetterForm" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID ="Label1" runat="server" Text="Please enter your name:" /><br />
            <asp:TextBox ID="TextBox1" runat="server" /> <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
