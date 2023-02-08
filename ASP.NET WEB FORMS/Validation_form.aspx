<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Validation_form.aspx.cs" Inherits="WEB_APPS.Validation_form" %>

<asp:Content ContentPlaceHolderID="Maincontent" runat="server">
    <h1>Validation Part</h1>
    <hr />
    <div class="container">
        <div class="col-8">
            <div>
            </div>
        </div>
        <div class=" col-3"></div>
        <p>Employee Name:</p>
        <asp:TextBox runat="server" ID="txtname" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtname" runat="server" ErrorMessage="Name Is Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        <asp:CustomValidator ID="CustomValidator1" ControlToValidate="txtname" runat="server" ErrorMessage="CustomValidator" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>

        <p>Employee Email:</p>
        <asp:TextBox TextMode="Email" runat="server" ID="txtemail" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtemail" runat="server" ErrorMessage="Email is Not in Correct Format" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Not In correct Format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtemail" ForeColor="Red"></asp:RegularExpressionValidator>

        <p>Password:</p>
        <asp:TextBox runat="server" TextMode="Password" ID="txtpass" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtpass" runat="server" ErrorMessage="Password is Required" ForeColor="Red"></asp:RequiredFieldValidator>

        <p>Confirm Password:</p>
        <asp:TextBox runat="server" ID="tctpass2" />
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password mismatched" ControlToCompare="txtpass" ControlToValidate="tctpass2" ForeColor="Red"></asp:CompareValidator>

        <p>
            Enter the years of Experience:
                
            <asp:TextBox runat="server" ID="txtExperience" TextMode="Number" />
            <asp:RangeValidator ErrorMessage="Experience should be b/w 3 to 10 years" ControlToValidate="txtExperience" runat="server" MaximumValue="20" MinimumValue="5" Type="Integer" ForeColor="Red" />
        </p>
        <p>
            <asp:Button Text="Submit" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" />
        </p>

    </div>
    <div class="col-4">
        <asp:validationsummary runat="server" DisplayMode="List" ForeColor="#FF3300" HeaderText="List of Errors to Resolve:" ShowMessageBox="True"></asp:validationsummary>
                <asp:Label runat="server" ID="lblInfo" ForeColor="indianred" />

    </div>
</asp:Content>
