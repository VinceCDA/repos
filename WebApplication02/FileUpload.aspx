<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="FileUpload.aspx.cs" Inherits="WebApplication02.FileUpload" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="panel panel-default">
            <div class="panel-heading"><strong>Upload Files</strong> <small>Bootstrap files upload</small></div>
            <div class="panel-body">

                <!-- Standar Form -->
                <h4>Select files from your computer</h4>

                <div class="form-inline">
                    <div class="form-group">
                        <input type="file" name="fileInput" id="fileInput" runat="server" accept=".jpg,.jpeg,.png,.gif">
                    </div>
                    <asp:Button ID="btnUpload" class="btn btn-sm btn-primary" type="submit" Text="Upload" runat="server" OnClick="btnUpload_Click"></asp:Button>

                </div>
            </div>
        </div>
    </div>
    <asp:Panel ID="frmConfirmation" Visible="False" runat="server">
        <asp:Label ID="lblUploadResult" runat="server"></asp:Label>
    </asp:Panel>


</asp:Content>
