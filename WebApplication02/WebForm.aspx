<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebForm.aspx.cs" Inherits="WebApplication02.WebForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-group">
        <label for="sexe" class="control-label">Sexe</label>
        <div class="radio">
            <label>
                <input id="radH" type="radio" name="sexe" runat="server" value="h" required>
                Homme
            </label>
        </div>
        <div class="radio">
            <label>
                <input id="radF" type="radio" name="sexe" runat="server" value="f" required>
                Femme
            </label>
        </div>
    </div>
    <div class="form-group">
        <div class="radio">
        <asp:RadioButtonList runat="server" ID="radListS" ClientIDMode="Static">
            <asp:ListItem class="radio" Value="h" >Homme</asp:ListItem>
            <asp:ListItem class="radio" Value="f">Femme</asp:ListItem>
        </asp:RadioButtonList>
            </div>
        </div>
    <asp:CustomValidator ID="chkRadListS" runat="server" ErrorMessage="Sel un S" ControleAssocie="radListS" OnServerValidate="ChkRadListS_ServerValidate"></asp:CustomValidator>
    <div class="form-group">
        <label for="txtNom" class="control-label">Nom</label>
        <asp:TextBox ID="txtNom" name="txtNom" type="text" class="form-control" runat="server" required="required" />
    </div>
    <div class="form-group">
        <label for="txtPrenom" class="control-label">Prénom</label>
        <asp:TextBox ID="txtPrenom" name="txtPrenom" type="text" class="form-control" runat="server" required="required" />
    </div>
    <div class="form-group">
        <label for="txtAdresse1" class="control-label">Adresse</label>
        <asp:TextBox ID="txtAdresse1" name="txtAdresse1" type="text" class="form-control" runat="server" required="required" />
    </div>
    <div class="form-group">
        <label for="txtAdresse2" class="control-label">Complément Adresse</label>
        <asp:TextBox ID="txtAdresse2" name="txtAdresse2" type="text" class="form-control" runat="server" />
    </div>
    <div class="form-group">
        <label for="txtZipcode" class="control-label">Code Postal</label>
        <asp:TextBox ID="txtZipcode" name="txtZipcode" type="text" class="form-control" runat="server" required="required" />
    </div>
    <div class="form-group">
        <label for="txtCity" class="control-label">Ville</label>
        <asp:TextBox ID="txtCity" name="txtCity" type="text" class="form-control" runat="server" required="required" />
    </div>
    <div class="form-group">
        <label for="selPays" class="control-label">Pays</label>
        <asp:DropDownList ID="selPays" name="selPays" class="select form-control" runat="server" />
    </div>
    <div class="form-group">
        <label for="txtMail" class="control-label">Adresse Mail</label>
        <asp:TextBox ID="txtMail" name="txtMail" type="email" class="form-control" runat="server" required="required" />
    </div>
    <div class="form-group">
        <label for="txtPhone" class="control-label">Téléphone</label>
        <asp:TextBox ID="txtPhone" name="txtPhone" type="text" class="form-control" runat="server" required="required" />
    </div>
    <div class="form-group">
        <label for="chkInterest" class="control-label">Vos centres d'intérêts</label>
        <div>
            <asp:CheckBoxList runat="server">
                <asp:ListItem name="chkInterest" Value="br">
                Bricolage</asp:ListItem>
                <asp:ListItem name="chkInterest" Value="ja">
                Jardinage</asp:ListItem>
                <asp:ListItem name="chkInterest" Value="le">
                Lecture</asp:ListItem>
                <asp:ListItem name="chkInterest" Value="vo" runat="server">
                     Voyages</asp:ListItem>


            </asp:CheckBoxList>
        </div>
    </div>
    <div class="form-group">
        <button name="btnSubmit" type="submit" class="btn btn-primary" runat="server">Envoyer</button>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </div>
    
</asp:Content>
