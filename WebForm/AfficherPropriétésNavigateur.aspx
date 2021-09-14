<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AfficherPropriétésNavigateur.aspx.cs" Inherits="WebForm.AfficherPropriétésNavigateur" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Information sur les Capacités du browser:"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Marque du Navigateur : "></asp:Label>
        <asp:TextBox ID="txtNav" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Version : "></asp:Label>
        <asp:TextBox ID="txtNavVer" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Accepte les cookies : "></asp:Label>
        <asp:TextBox ID="txtCookies" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Accepete la version de Javasript : "></asp:Label>
        <asp:TextBox ID="txtJs" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Accepte les ActiveX : "></asp:Label>
        <asp:TextBox ID="txtActiveX" runat="server"></asp:TextBox>
    </form>

</body>
</html>
