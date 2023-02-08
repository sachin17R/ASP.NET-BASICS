<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="WEB_APPS.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Maincontent" runat="server">
    <style>
        .item{
            border:2px solid blue;
        }
    </style>
     <h1 class="h1">
        Server side state management using Sessions and Application State
    </h1>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
            <asp:Repeater ID="rpProduct" runat="server">
                <HeaderTemplate>
                    <p>Item List We Have</p>
                </HeaderTemplate>
                <ItemTemplate>
                   <div class="row">
                <div class="col-md-8" style="border:solid thick ">
                    <p>
                        <h2><%#Eval("ProductName") %></h2>
                        </p>
                    <asp:Image ImageUrl=<%#Eval("ProductImage")%> runat="server" Height="200" Width="200px"  />
                    <p>Price: <%#Eval("Price") %></p>
                    <p>
                    <asp:Button Text="View More" CommandName="Details" CommandArgument='<%#Eval("ProductId") %>' OnCommand="OnView_Command" runat="server" CssClass="btn btn-info"/>
                    </p>
                </div>
                       </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
            <div class="col-md-5">
                <h2>Details of the selected Product</h2>
                <div>
                    <asp:TextBox ID="txtProductId" runat="server" Enabled="false" />
                </div>
                <div>
                    <asp:TextBox ID="txtProductName" runat="server" Enabled="false" />
                </div>
                <div>
                    <asp:TextBox ID="txtProductCost" runat="server" Enabled="false" />
                </div>
                <div>
                    <asp:TextBox runat="server" ID="txtQuantity" Enabled="false" />   
                </div>
                <div>
                    <asp:Button Text="Add to Cart" runat="server" OnClick="Unnamed1_Click" />
                </div>
            </div>
        </div>
        <div class="row">
            <asp:DataList ID="lstRecentList" runat="server" RepeatColumns="5" CellPadding="10" CellSpacing="20" >
                <ItemTemplate>
                    <div class="row item">
                        <div class="col-md-8">
                            <p><%#Eval("ProductName")%></p>
                            <asp:Image ImageUrl=<%#Eval("ProductImage")%> runat="server" Width="100" Height="100" />
                            <p>Price: <%#Eval("Price") %></p>
                        </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>           
</asp:Content>
