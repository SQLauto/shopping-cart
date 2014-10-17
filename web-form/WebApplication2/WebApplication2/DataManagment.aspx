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
        <hr />
        <strong>Add new product</strong>:<br />
        Category ID:<asp:TextBox ID="TextBox2" runat="server" Width="22px"></asp:TextBox>
&nbsp;Title:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;Short Description:<asp:TextBox ID="TextBox4" runat="server" Width="370px"></asp:TextBox>
&nbsp;<br />
        Long Description:<asp:TextBox ID="TextBox5" runat="server" Width="819px"></asp:TextBox>
        <br />
        Image URL:<asp:TextBox ID="TextBox6" runat="server" Width="413px"></asp:TextBox>
        <br />
        Price:<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="insertButton" runat="server" OnClick="Button2_Click" Text="Add new product" />
    </form>
</body>
</html>
