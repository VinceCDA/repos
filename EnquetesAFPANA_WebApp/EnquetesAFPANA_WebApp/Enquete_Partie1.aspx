<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Enquete_Partie1.aspx.cs" Inherits="EnquetesAFPANA_WebApp.Enquete_Partie1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="h3 col-md-12 " runat="server" id="titreEnquete" style="padding: 20px">
        </div>
        <div class="jumbotron col-md-12" runat="server" id="introduction">
        </div>
        <div class="row">
           <div class="col-5 "> <a id="hlEmploi" class="btn btn-primary btn-block" href='Emploi.aspx?IdentifiantMailing=<%=Request.QueryString["IdentifiantMailing"]%>'>Oui, j'ai repris un emploi</a></div>
            <div class="col"></div>
           <div class="col-5 "> <a id="hlSansEmploi" class="btn btn-primary btn-block" href='SansEmploi.aspx?IdentifiantMailing=<%= Request.QueryString["IdentifiantMailing"]%>'>Non, je n'ai pas retravaillé.</a></div>
        </div>

    </div>
</asp:Content>

