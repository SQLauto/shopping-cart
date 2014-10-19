<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadImage.aspx.cs" Inherits="WebApplication2.UploadImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Label ID="uploadLabel" runat="server" EnableViewState="false" ForeColor="Green"></asp:Label>

    
        <br /><strong>
        Choose Image File:</strong>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        Product ID
        <asp:TextBox ID="TextBox1" runat="server" Width="60px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
        <br />
        &nbsp;</div>
        <a href="DataManagment.aspx">Back</a>
    </form>
</body>
</html>
