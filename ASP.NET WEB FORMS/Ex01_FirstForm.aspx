<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ex01_FirstForm.aspx.cs" Inherits="WEB_APPS.Ex01_FirstForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calci Program</title>
</head>
<body style="background-color: #FFCCCC">
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center; color: #000099">Sample Calculator</h1>
            <p>
           Enter First Value:
            <asp:TextBox Id="txtFirst" runat="server" />  
            </p>

            <p>
            Select The Operation:
            <asp:DropDownList runat="server" ID="dplist">
                <asp:ListItem Text="Add" />
                <asp:ListItem Text="Sub" />
                <asp:ListItem Text="Mul" />
                <asp:ListItem Text="Div" />               
            </asp:DropDownList>
            </p>

            <p>
            Enter Second Value:
            <asp:TextBox ID="txtSecond" runat="server" />  
            </p>
            <p>
                <asp:Button Text="Result" runat="server" ID="btnCLick" OnClick="btnCLick_Click" />
            </p>
            <p>
                <asp:Label runat="server" ID="pdisplay" /></p>
        </div>
    </form>
</body>
</html>
