<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="UsingSessionState.WebForm2" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" /><br />
            <asp:Button ID="Button1" runat="server" Text="Clear Session" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
