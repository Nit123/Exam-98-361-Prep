<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubmittedForm.aspx.cs" Inherits="Scenario4_4.SubmittedForm" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" /><br />
            <asp:Label ID="Label2" runat="server" /><br />
            <asp:Button ID="Button1" runat="server" Text="Clear Session" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
