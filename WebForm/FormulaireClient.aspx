<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormulaireClient.aspx.cs" Inherits="WebForm.FormulaireClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Table ID="Table1" runat="server" GridLines="Both">
            <asp:TableRow>
            <asp:TableCell>
                Key
            </asp:TableCell>
            <asp:TableCell>
                Value
            </asp:TableCell>
        </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
