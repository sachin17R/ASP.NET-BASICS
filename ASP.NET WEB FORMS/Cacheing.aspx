<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cacheing.aspx.cs" Inherits="WEB_APPS.Cacheing" %>
<%@ Register TagName="CustomControls1" TagPrefix="myctrls" Src="~/Custom Controls/ServerTime.ascx" %>
<%--<%@ OutputCache Duration="5" VaryByParam="City" %>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Maincontent" runat="server">
    <h1>Cacheing Example</h1>
    <div class="container">
        <div class="row" style="border:solid 2px">
            <p> <asp:Label ID="lblTime" CssClass="form-control" runat="server" Width="200px" /></p>
        </div>
        <br />
        <br />
        <div class="row" style="border:solid 2px">
            <h2 style="text-align:center">Time At Different Places</h2>
            
                <h3>Select Your City</h3>
            <p>
                <asp:DropDownList runat="server" ID="dplist" CssClass="form-check" Width="200px">
                    <asp:ListItem Text="New Delhi" />
                    <asp:ListItem Text="London" />
                    <asp:ListItem Text="New York" />
                    <asp:ListItem Text="Tokyo" />
                </asp:DropDownList>          
                <asp:Button Text="Get Time" ID="btnTime"  runat="server" OnClick="btnTime_Click" Width="100px" />
                <asp:Label ID="lblbtntime" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Larger" ForeColor="Red" Width="300px" />
            </p>
        </div>
        <br />
        <div class="row">
            <h2>Fragment Cacheing</h2>
            <div style="text-align:center">
               <myctrls:CustomControls1 runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
