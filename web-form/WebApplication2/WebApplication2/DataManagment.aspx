<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataManagment.aspx.cs" Inherits="WebApplication2.DataManagment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    
        Select Category:
        <asp:DropDownList ID="DropDownList1" runat="server"  DataTextField="Title" DataValueField="CategoryID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
&nbsp;<br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="True">
        </asp:GridView>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Add new product" />
    </form>
</body>
</html>
