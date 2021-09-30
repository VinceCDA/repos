<%@ Page async="true" Language="C#" AutoEventWireup="true" CodeBehind="ListeProduits.aspx.cs" MasterPageFile="~/Site.Master" Inherits="ECommerceAPPWeb.ListeProduits" %>
<%@ Register Src="~/UserControls/ProduitListe.ascx" TagPrefix="uc1" TagName="ProduitListe" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<nav class="navbar navbar-expand-lg navbar-light bg-light">
  <a class="navbar-brand" href="#">Notre catalogue</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNavDropdown">
  <ul class="navbar-nav" runat="server" id="MenuListe" enableviewstate="true">
  </ul>
  </div>
  </nav>
    <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False"  EnableViewState="False" GridLines="None" BackColor="#FF99FF">
        <Columns>
            <asp:TemplateField InsertVisible="False">                
                <ItemTemplate>
                   <uc1:ProduitListe runat="server"  id="ProduitListe2"  IdProduit='<%# Eval("Id") %>' TitreProduit='<%# Eval("Name") %>'
                       Description='<%# Eval("FullDescription") %>' Prix='<%# Eval("Price") %>' IdImage='<%# Eval("PictureId") %>'/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:datalist ID="dlCategories" runat="server" >
    <ItemTemplate>
   
        <div >
            <h2 id="Name" runat="server"><%#Eval("Name") %></h2>
         </div>
   
        <div >
            <img ID="ImageCategorie" Class="img-responsive"  src='https://localhost:44320/api/picture/GetPicture/<%# Eval("PictureId") %>' />
        </div>                                                                             
   
        </ItemTemplate>
        </asp:datalist>
   
<div class="modal fade" id="dialogueTransaction" role="dialog">
   <div class="modal-dialog">
    
     <!-- Modal content-->
     <div class="modal-content">
       <div class="modal-header">
         <h4 class="modal-title">Ajout au panier</h4>
         <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
         
       </div>
       <div class="modal-body">
         <p id="modDetail1"></p>
         <p id="modDetail2"></p>
       </div>
       <div class="modal-footer">
         <button type="button" class="btn btn-secondary" data-dismiss="modal">Fermer</button>
       </div>
     </div>
   </div>
 </div>
</asp:Content>
<asp:Content ID="Footer" ContentPlaceHolderID="FooterContent" runat="server">
    <script src="ScriptsApplication/GererPanier.js"></script>
    </asp:Content>
