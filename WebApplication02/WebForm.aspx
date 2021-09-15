<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebForm.aspx.cs" Inherits="WebApplication02.WebForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-group">
        <label for="sexe" class="control-label">Sexe</label>
        <div>
            <label class="radio-inline">
                <asp:RadioButton  name="sexe" value="h" runat="server" GroupName="RadioGroup1"/>
                Homme
            </label>
            <label class="radio-inline">
                <asp:RadioButton  name="sexe" value="f" runat="server" GroupName="RadioGroup1"/>
                Femme
            </label>
        </div>
    </div>
    <div class="form-group">
        <label for="txtNom" class="control-label">Nom</label>
        <asp:TextBox id="txtNom" name="txtNom" type="text" class="form-control" runat="server" />
    </div>
    <div class="form-group">
        <label for="txtPrenom" class="control-label">Prénom</label>
        <asp:TextBox id="txtPrenom" name="txtPrenom" type="text" class="form-control" runat="server" />
    </div>
    <div class="form-group">
        <label for="txtAdresse1" class="control-label">Adresse</label>
        <asp:TextBox id="txtAdresse1" name="txtAdresse1" type="text" class="form-control" runat="server" />
    </div>
    <div class="form-group">
        <label for="txtAdresse2" class="control-label">Complément Adresse</label>
        <asp:TextBox id="txtAdresse2" name="txtAdresse2" type="text" class="form-control" runat="server" />
    </div>
    <div class="form-group">
        <label for="txtZipcode" class="control-label">Code Postal</label>
        <asp:TextBox id="txtZipcode" name="txtZipcode" type="text" class="form-control" runat="server" />
    </div>
    <div class="form-group">
        <label for="txtCity" class="control-label">Ville</label>
        <asp:TextBox id="txtCity" name="txtCity" type="text" class="form-control" runat="server" />
    </div>
    <div class="form-group">
        <label for="selPays" class="control-label">Pays</label>
        <asp:DropDownList id="selPays" name="selPays" class="select form-control" runat="server"/>
    </div>
    <div class="form-group">
        <label for="txtMail" class="control-label">Adresse Mail</label>
        <asp:TextBox id="txtMail" name="txtMail" type="text" class="form-control" runat="server" />
    </div>
    <div class="form-group">
        <label for="txtPhone" class="control-label">Téléphone</label>
        <asp:TextBox id="txtPhone" name="txtPhone" type="text" class="form-control" runat="server" />
    </div>
    <div class="form-group">
        <label for="chkInterest" class="control-label">Vos centres d'intérêts</label>
        <div>
            <label class="checkbox-inline">
                <input type="checkbox" name="chkInterest" value="br">
                Bricolage
            </label>
            <label class="checkbox-inline">
                <input type="checkbox" name="chkInterest" value="ja">
                Jardinage
            </label>
            <label class="checkbox-inline">
                <input type="checkbox" name="chkInterest" value="le">
                Lecture
            </label>
            <label class="checkbox-inline">
                 <asp:CheckBox type="checkbox" name="chkInterest" value="vo" runat="server"/>
                Voyages
            </label>
        </div>
    </div>
    <div class="form-group">
        <button name="submit" type="submit" class="btn btn-primary">Envoyer</button>
    </div>

</asp:Content>
