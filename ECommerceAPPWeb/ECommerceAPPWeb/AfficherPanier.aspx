<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AfficherPanier.aspx.cs" Inherits="ECommerceAPPWeb.AfficherPanier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="table responsive">
        <table class="table table-striped table-hover col-md-12">
            <asp:Repeater ID="AffichagePanier" runat="server" DataMember="LignePanier" OnItemCreated="AffichagePanier_ItemCreated">
                <HeaderTemplate>
                    <tr>
                        <th class="col-md-1">Référence
                        </th>
                        <th class="col-md-3">Désignation
                        </th>
                        <th class="col-md-2">Prix
                        </th>
                        <th class="col-md-2">Quantité
                        </th>
                        <th class="col-md-2">Total Ligne
                        </th>
                        <th class="col-md-1"></th>
                        <th class="col-md-1"></th>
                    </tr>
                </HeaderTemplate>

                <ItemTemplate>
                    <tr class="info">
                        <td>
                            <asp:Label runat="server" ID="IdProduit" Text='<%# Eval("IdProduit") %>' />
                        </td>
                        <td>
                            <asp:Label runat="server" ID="NomProduit" Text='<%# Eval("NomProduit") %>' />
                        </td>
                        <td>
                            <asp:Label runat="server" ID="Prix" Text='<%# Eval("Prix","{0:c}") %>' />
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="Quantite" Text='<%# Bind("Quantite") %>' required="true"></asp:TextBox>
                             <asp:RegularExpressionValidator ID="ValQuantite" runat="server" ErrorMessage="Seul un nombre entier est accepté" ControlToValidate="Quantite" Display="Dynamic" ValidationExpression="[0-9]" ></asp:RegularExpressionValidator>
                        </td>
                       
                        <td>
                            <asp:Label runat="server" ID="Label2" Text='<%# Eval("TotalLigne","{0:c}") %>' />
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton1" CssClass="btn btn-danger btn-sm" CommandName="Supprimer" OnCommand="LinkButton1_Command" CommandArgument='<%# Eval("IdProduit") %>' runat="server"><i class="bi bi-x-square"></i></asp:LinkButton>
                        </td>
                        <td>
                       
                        <asp:LinkButton ID="LinkButton2" CssClass="btn btn-primary btn-sm" CommandArgument='<%# Container.ItemIndex.ToString()%>' CommandName="Modifier" OnCommand="LinkButton1_Command" runat="server"><i class="bi bi-plus-square"></i></asp:LinkButton>
                            </td>
                    </tr>
                </ItemTemplate>

                <AlternatingItemTemplate>
                    <tr class="active">
                        <td>
                            <asp:Label runat="server" ID="IdProduit" Text='<%# Eval("IdProduit") %>' />
                        </td>
                        <td>
                            <asp:Label runat="server" ID="NomProduit" Text='<%# Eval("NomProduit") %>' />
                        </td>
                        <td>
                            <asp:Label runat="server" ID="Prix" Text='<%# Eval("Prix","{0:c}") %>' />
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="Quantite" Text='<%# Bind("Quantite") %>'></asp:TextBox>
                            <asp:RegularExpressionValidator ID="ValQuantite" runat="server" ErrorMessage="Seul un nombre entier est accepté" ControlToValidate="Quantite" ValidationExpression="[0-9]"  Display="Dynamic"></asp:RegularExpressionValidator>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="Label2" Text='<%# Eval("TotalLigne","{0:c}") %>' />
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton1" CssClass="btn btn-danger btn-sm" CommandName="Supprimer" OnCommand="LinkButton1_Command" CommandArgument='<%# Eval("IdProduit") %>' runat="server"><i class="bi bi-x-square"></i></asp:LinkButton>
                        </td>
                        <td>
                              <asp:LinkButton ID="LinkButton2" CssClass="btn btn-primary btn-sm" CommandArgument='<%# Container.ItemIndex.ToString()%>' CommandName="Modifier" OnCommand="LinkButton1_Command" runat="server"><i class="bi bi-plus-square"></i></asp:LinkButton>
                        </td>
                    </tr>
                </AlternatingItemTemplate>
                <SeparatorTemplate>
                </SeparatorTemplate>
                <FooterTemplate>
                    <tr>
                        <td colspan="3">Total du panier 
                        </td>
                        <td>
                            <asp:Label runat="server" ID="QuantiteTotale"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="MontantTotal"></asp:Label>
                        </td>
                         <td colspan="2">
                             <asp:HyperLink ID="hlCommander" CssClass="btn btn-primary"  NavigateUrl="~/ValiderPanier.aspx" runat="server">Commander</asp:HyperLink>
               
                        </td>
                    </tr>
                </FooterTemplate>

            </asp:Repeater>
        </table>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FooterContent" runat="server">
</asp:Content>
