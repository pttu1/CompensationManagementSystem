<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="CompManagement.FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Upload HR Data<br />
            <br />
            Click to upload file&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <br />
            <asp:Button ID="uploadButton" runat="server" Text="Submit" class="ccbtn" OnClick="uploadButton_Click"/>


            <br />
            <br />
            <asp:Label ID="Success" runat="server"></asp:Label>


        </div>
    </form>
</body>
</html>
