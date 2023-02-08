﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ProductApp.aspx.cs" Inherits="WEB_APPS.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Maincontent" runat="server">
     <div class="container">
            <div class="row d-flex">
                <div class="col-md-4">
                    <asp:ListBox ID="lstProducts" CssClass="form-control" runat="server" Height="386px" Width="213px" OnSelectedIndexChanged="lstProducts_SelectedIndexChanged" AutoPostBack="True">
                    </asp:ListBox>
                </div>
                <div class="col-md-7">
                    <h2>Details of the Product</h2>
                    <div class="row">
                        <div class="col-md-6">
                            <asp:Image ID="imgPic" Height="253px" runat="server" Width="225px" />
                        </div>
                        <div class="col-md-4">
                            <p>Product Id: <asp:TextBox runat="server" CssClass="form-control" ID="txtId"/></p>
                            <p>Name: <asp:TextBox CssClass="form-control" runat="server" ID="txtName"/></p>
                            <p>Price: <asp:TextBox  CssClass="form-control" runat="server" ID="txtPrice"/></p>
                            <p>Quantity: 
                                <asp:DropDownList CssClass="form-control" ID="dpQuantity" runat="server">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                </asp:DropDownList>
                            </p>

                        </div>
                        <div class="col-md-1 align-items-center" >
                            <button runat="server" onserverclick="btnEdit_Click" class="btn btn-info m-2">
                                <i class="fa fa-pencil"></i>
                            </button>
                            <button onserverclick="btnDelete_Click" runat="server" class="btn btn-danger m-2">
                                <i class="fa fa-trash"></i>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
  

</asp:Content>