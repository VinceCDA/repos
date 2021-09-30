<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" Async="true" CodeBehind="Index.aspx.cs" Inherits="CommerceWeb.Index" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <asp:Repeater ID="repCategory" runat="server">
            <ItemTemplate>
                <%--<asp:Label ID="lblParent" runat="server" Text='<%#Eval("Name") %>' Font-Bold="true" />--%>
                <div class="dropdown">
                    <button class="btn btn-secondary" type="button" id="dropdownMenu2" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        <%#Eval("Name") %>
                    </button>

                    <asp:Repeater ID="childCategory" runat="server" DataSource='<%#Eval("categoryDTOs") %>'>
                        <HeaderTemplate>
                            <div class="dropdown-menu" aria-labelledby="dropdownMenu2">
                        </HeaderTemplate>
                        <ItemTemplate>

                            <button class="dropdown-item" type="button"><%#Eval("Name") %></button>
                            <%--<asp:Label ID="lblChild" runat="server" Text='<%#Eval("Name") %>' />--%>
                        </ItemTemplate>
                        <FooterTemplate>
                            </div>
                        </FooterTemplate>
                    </asp:Repeater>

                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <div class="btn-group dropdown">
        <button type="button" class="btn btn-secondary">
            Split dropdown
        </button>
        <button type="button" class="btn btn-secondary dropdown-toggle dropdown-toggle-split" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
            <span class="sr-only">Toggle Dropright</span>
        </button>
        <div class="dropdown-menu">
            <div class="btn-group dropright">
                <button type="button" class="btn btn-secondary">
                    Split dropright
                </button>
                <button type="button" class="btn btn-secondary dropdown-toggle dropdown-toggle-split" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                    <span class="sr-only">Toggle Dropright</span>
                </button>
                <div class="dropdown-menu">
                    <button class="dropdown-item" type="button">2</button>
                    <button class="dropdown-item" type="button">2</button>
                    <button class="dropdown-item" type="button">2</button>
                </div>
            </div>
            <div class="btn-group dropright">
                <button type="button" class="btn btn-secondary">
                    Split dropright
                </button>
                <button type="button" class="btn btn-secondary dropdown-toggle dropdown-toggle-split" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                    <span class="sr-only">Toggle Dropright</span>
                </button>
                <div class="dropdown-menu">
                    <button class="dropdown-item" type="button">2</button>
                    <button class="dropdown-item" type="button">2</button>
                    <button class="dropdown-item" type="button">2</button>
                </div>
            </div>
            <button class="dropdown-item" type="button">2</button>
            <!-- Dropdown menu links -->

        </div>
    </div>
</asp:Content>
