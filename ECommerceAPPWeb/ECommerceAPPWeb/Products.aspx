 ﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" MasterPageFile="~/Site.Master" Async="true" Inherits="CommerceWeb.Products" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">



        <asp:Repeater ID="repProduct" runat="server">
            <ItemTemplate>
                <div class="card" style="width: 18rem;">
                    <img class="card-img-top" src="https://localhost:44340/api/Pictures/<%#Eval("PictureId") %>" alt="Card image cap">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Name") %></h5>
                        <p class="card-text"><%#Eval("ShortDescription") %></p>

                    </div>
                    <div class="card-footer">
                        <h5 class="card-text"><%#Eval("Price") %></p>
                        <a href="#" class="btn btn-primary">Add to Cart</a>
                        
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
