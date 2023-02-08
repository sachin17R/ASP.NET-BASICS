<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WEB_APPS.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap-grid.min.css" rel="stylesheet" />
    <style>
        body{
            background-color:gainsboro;  
           text-align:center;
        }
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4">

                <h2>Login Page</h2>
                <hr />
                <br />
                <table> 
                    <tr>    
                        <td>User Name:</td>
                        <td> <asp:TextBox runat="server" ID="txtusername" Height="15px" Width="300px" /></td>
                    </tr>
                    <tr>    
                        <td>Password:</td>
                        <td><asp:TextBox runat="server" ID="txtpassword" Width="300px" Height="15px" TextMode="Password" /></td>
                    </tr>
                    <tr>    
                        <td></td>
                        <td> <asp:Button Text="Login" ID="btnlogin" runat="server" OnClick="btnlogin_Click" Width="76px" /></td>
                    </tr>               
                                   </table>           
            </div>
                </div>
                <%--<div class="col-md-4"></div>--%>

            <p> <asp:Label ID="lblerror" runat="server" ForeColor="Red" Width="500px" /></p>
        </div>
    </form>
</body>
</html>
