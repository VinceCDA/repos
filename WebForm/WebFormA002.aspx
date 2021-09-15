<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormA002.aspx.cs" Inherits="WebForm.WebFormA002" Trace="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset id='fsCoordonnees'>
        <legend>Saisie des informations vous concernant</legend>
        <p>
            <label for='txtNom'>
                Nom :</label>
            <input class="inputText" id="txtNom" name="txtNom" runat="server" 

                type="text" onserverchange="txtNom_ServerChange" onchange="txtNom_OnChange"/>
           
        </p>
        <p>
            <label for='txtPrenom'>
                Prénom :</label>
            <input class="inputText" id="txtPrenom" name="txtPrenom" type="text" runat="server"/>
          
        </p>
        
        <p>
            <input id='btnEnvoyer' class="inputText"  value="Envoyer" type="submit" runat="server"/>
        </p>
    </fieldset>
        </div>
    </form>
    <script>
        $("#txtNom").on("keyup", function{
            $("#form1").submit();
        })
    </script>
</body>
</html>
