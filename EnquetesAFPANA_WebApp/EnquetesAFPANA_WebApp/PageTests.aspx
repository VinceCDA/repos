<%@ Page Title="" Async="true" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PageTests.aspx.cs" Inherits="EnquetesAFPANA_WebApp.PageTests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="table responsive">
        <table class="table table-striped table-hover col-md-12">
            <asp:Repeater ID="AffichageSoumissionnaires" runat="server"  ItemType="EnquetesAFPANA_WebApp.Models.Soumissionnaire" >
                
                <ItemTemplate>
                    <tr class="info">
                        <td>
                        <a href="Enquete_Partie1.aspx?IdentifiantMailing=<%#:Item.IdentifiantMailing%>">
                          Répondre à l'enquête
                        </a>
                    
                        </td>
                       </tr>
            </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
</asp:Content>
