<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebForm.aspx.cs" Inherits="WebApplication02.WebForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-group">
        <label for="sexe" class="control-label">Sexe</label>
        <div class="radio">
      <label>
        <input type="radio" name="sexe" runat="server" value="h" required>
        Homme
      </label>
    </div>
    <div class="radio">
      <label>
        <input type="radio" name="sexe" runat="server" value="f" required>
        Femme
      </label>
    </div>
    </div>
    <div class="form-group">
        <label for="txtNom" class="control-label">Nom</label>
        <asp:TextBox id="txtNom" name="txtNom" type="text" class="form-control" runat="server" required="required" />
    </div>
    <div class="form-group">
        <label for="txtPrenom" class="control-label">Prénom</label>
        <asp:TextBox id="txtPrenom" name="txtPrenom" type="text" class="form-control" runat="server" required="required"/>
    </div>
    <div class="form-group">
        <label for="txtAdresse1" class="control-label">Adresse</label>
        <asp:TextBox id="txtAdresse1" name="txtAdresse1" type="text" class="form-control" runat="server" required="required"/>
    </div>
    <div class="form-group">
        <label for="txtAdresse2" class="control-label">Complément Adresse</label>
        <asp:TextBox id="txtAdresse2" name="txtAdresse2" type="text" class="form-control" runat="server" />
    </div>
    <div class="form-group">
        <label for="txtZipcode" class="control-label">Code Postal</label>
        <asp:TextBox id="txtZipcode" name="txtZipcode" type="text" class="form-control" runat="server" required="required"/>
    </div>
    <div class="form-group">
        <label for="txtCity" class="control-label">Ville</label>
        <asp:TextBox id="txtCity" name="txtCity" type="text" class="form-control" runat="server" required="required" />
    </div>
    <div class="form-group">
        <label for="selPays" class="control-label">Pays</label>
        <asp:DropDownList id="selPays" name="selPays" class="select form-control" runat="server"/>
    </div>
    <div class="form-group">
        <label for="txtMail" class="control-label">Adresse Mail</label>
        <asp:TextBox id="txtMail" name="txtMail" type="email" class="form-control" runat="server" required="required"/>
    </div>
    <div class="form-group">
        <label for="txtPhone" class="control-label">Téléphone</label>
        <asp:TextBox id="txtPhone" name="txtPhone" type="text" class="form-control" runat="server" required="required" />
    </div>
    <div class="form-group">
        <label for="chkInterest" class="control-label">Vos centres d'intérêts</label>
        <div>
            <asp:CheckBoxList runat="server">
                <asp:ListItem name="chkInterest" value="br">
                Bricolage</asp:ListItem>
                <asp:ListItem name="chkInterest" value="ja">
                Jardinage</asp:ListItem>
                <asp:ListItem name="chkInterest" value="le">
                Lecture</asp:ListItem>
                 <asp:ListItem  name="chkInterest" value="vo" runat="server">
                     Voyages</asp:ListItem>
                
            
                </asp:CheckBoxList>
        </div>
    </div>
    <div class="form-group">
        <button name="btnSubmit" type="submit" class="btn btn-primary" runat="server">Envoyer</button>
    </div>

</asp:Content>
