<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site1.Master" CodeBehind="calci.aspx.cs" Inherits="WEB_APPS.WebForm1" %>
<asp:Content id="MyContent" ContentPlaceHolderID="Maincontent" runat="server">
     <div>
            <h2 style="text-align: center; height: 26px">Calculator App</h2>
            <p>Enter First Values <asp:TextBox ID="txtfirst" runat="server"> </asp:TextBox>  </p>
            <p> Select The Operation <asp:DropDownList id="dplist" runat="server" >
                <asp:ListItem>Add</asp:ListItem>
                <asp:ListItem>sub</asp:ListItem>
                <asp:ListItem>mul</asp:ListItem>
                <asp:ListItem>div</asp:ListItem>
                </asp:DropDownList></p>

            <p>Enter Second Value<asp:TextBox ID="txtsecond" runat="server"></asp:TextBox> </p>
            <p><asp:Button Text="Answer" runat="server" id="btnclick" OnClick="btnclick_Click" /></p>
            <p>
                <asp:Label Text="" ID="pdisplay" runat="server" /></p>
        </div>
   
</asp:Content>   
