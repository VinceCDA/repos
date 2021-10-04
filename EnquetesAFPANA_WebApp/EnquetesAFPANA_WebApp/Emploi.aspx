<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Emploi.aspx.cs" Async="true" Inherits="EnquetesAFPANA_WebApp.Emploi" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/1000hz-bootstrap-validator/0.11.9/validator.min.js" integrity="sha512-dTu0vJs5ndrd3kPwnYixvOCsvef5SGYW/zSSK4bcjRBcZHzqThq7pt7PmCv55yb8iBvni0TSeIDV8RYKjZL36A==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <div class="form-group">
        <label for="typecontrat">Type Contrat</label>
        <div>
            <asp:DropDownList ID="typecontrat" name="typecontrat" aria-describedby="typecontratHelpBlock" class="custom-select" runat="server" required="required"></asp:DropDownList>
            <span id="typecontratHelpBlock" class="form-text text-muted">Veuillez sélectionné un type de contrat.</span>
            <div class="invalid-feedback">Date Naissance est requise.</div>
        </div>
    </div>
    <div class="form-group">
        <label>Durée Contrat</label>
        <%--<asp:Repeater ID="dureecontrat" runat="server">
            <ItemTemplate>
                <div class="custom-control custom-radio custom-control-inline">
                    <div class="radio">
                    <label>
                        <input id="radH" type="radio" name="sexe" runat="server" value=<%#Eval("idDureeContrat") %> GroupName="rdBtnDuree" required>
                        <%#Eval("libelleDureeContrat") %>
                    </label>
                &nbsp;&nbsp;</div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>--%>

        <asp:RadioButtonList ID="rdBtnListDuree" runat="server">
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ErrorMessage="Choisissez une durée.<br />"
    ControlToValidate="rdBtnListDuree" runat="server" ForeColor="Red" Display="Dynamic" />
        <span id="dureecontratHelpBlock" class="form-text text-muted">Veuillez sélectionné une durée.
        </span>
    </div>
    &nbsp;<div class="form-group">
        <label for="exercicemetier">Métier Exercer</label>
        <div class="input-group">
            <div class="input-group-prepend">
                <div class="input-group-text">
                    <i class="fa fa-font"></i>
                </div>
            </div>
            <input id="exercicemetier" name="exercicemetier" type="text" class="form-control" runat="server" required="required">
        </div>
    </div>
    <div class="form-group">
        <label for="coderome">Code ROME</label>
        <div class="input-group">
            <div class="input-group-prepend">
                <div class="input-group-text">
                    <i class="fa fa-font"></i>
                </div>
            </div>
            <input id="coderome" name="coderome" type="text" class="form-control" runat="server">
        </div>
    </div>
    <div class="form-group">
        <label for="dateDebutContrat">Date Début Contrat</label>
        <input type="date" class="form-control" name="dateDebutContrat" id="dateDebutContrat" runat="server" required>
        <asp:CustomValidator ID="chkDateDebutContrat" runat="server" ErrorMessage="Date début contrat invalide." ControlToValidate="dateDebutContrat" OnServerValidate="ChkDateDebutContrat_ServerValidate" ForeColor="Red" Display="Dynamic"></asp:CustomValidator>
    </div>
    <div class="form-group">
        <label for="dateDebutContrat">Date Fin Contrat</label>
        <input type="date" class="form-control" name="dateFinContrat" id="dateFinContrat" runat="server">
    </div>
    <div class="form-group">
        <button name="submit" type="submit" class="btn btn-primary">Envoyer</button>
    </div>
    
    <asp:ValidationSummary ID="ValidationSummary" runat="server" ShowSummary="true" />
</asp:Content>
