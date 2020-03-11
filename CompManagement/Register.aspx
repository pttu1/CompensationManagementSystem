<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CompManagement.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Register Page"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="fnametxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="lnametxt" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label4" runat="server" Text="Email Address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="emailtxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="passwordtxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Confirm Password"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="confpasswordtxt" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:CompareValidator ID="comparePass" runat="server" ControlToCompare="passwordtxt" ControlToValidate="confpasswordtxt" ErrorMessage="Enter Same Password!"></asp:CompareValidator>
            <br />
            <br />
            <asp:Button ID="registerButton" runat="server" OnClick="registerButton_Click" Text="Register" />
        </div>
    </form>
</body>
</html>
