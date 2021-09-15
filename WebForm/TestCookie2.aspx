<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestCookie2.aspx.cs" Inherits="WebForm.TestCookie2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="LireCookie.aspx">
        <div>
            <div id="div1" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Nom"></asp:Label>
                <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="Prénom"></asp:Label>
                <asp:TextBox ID="txtPrenom" runat="server"></asp:TextBox>
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Envoyer" />
            </div>
        </div>
    </form>
    <div id="div2" runat="server">
    </div>
</body>
</html>
