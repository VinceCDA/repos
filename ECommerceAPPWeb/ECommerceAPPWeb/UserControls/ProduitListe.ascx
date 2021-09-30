<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProduitListe.ascx.cs" Inherits="EcommerceAPPWeb.UserControls.ProduitListe" EnableViewState="false" %>
<div class="container">
    <div class="row">
        <div class="col-md-12">
            <h2 id="Title" runat="server"></h2>
        </div>
    </div>
    <div class="row" style="margin-bottom: 5px; margin-top: 5px">
        <div class="col-md-4">
            <asp:Image ID="ImageProduit" CssClass="img-responsive" runat="server" Width="304" Height="304" />
        </div>
        <div class="col-md-8">
            <span class="" id="txtDescription" runat="server"></span>
        </div>
    </div>
    <div class="row" style="margin-bottom: 5px; margin-top: 5px">
        <div class="col-md-4">
            <asp:Literal ID="litPrix" runat="server"></asp:Literal>
        </div>
        <div class="btn-group btn-group-md col-md-8">
            <input id="btnCommander" class="btn btn-primary Add" type="button" value="Ajouter au panier"  runat="server" />
            <input id="btnPrix" class="btn btn-success" type="button" runat="server" />
           
        </div>
    </div>
</div>

