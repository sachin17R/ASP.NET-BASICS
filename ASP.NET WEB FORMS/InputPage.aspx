<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="InputPage.aspx.cs" Inherits="WEB_APPS.InputPage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Maincontent" runat="server">
    <h1>Input Page For Site Mangement</h1>
    <div class="col-md-4">
        <p>
           Enter The Name:
            <asp:TextBox runat="server" id="txtname" />
        </p>
        <p>
           Enter The Email:
            <asp:TextBox runat="server" id="txtemail" />
        </p>
        <p>
           Enter The Phone:
            <asp:TextBox runat="server" id="txtnumber" />
        </p>
        <p>
            <asp:Button runat="server" Text="Save Changes" id="btnsave" OnClick="btnsave_Click" />
        </p>
    </div>
</asp:Content>
