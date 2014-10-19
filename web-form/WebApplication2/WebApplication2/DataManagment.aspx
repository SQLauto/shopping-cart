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
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
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

        <hr />

        <strong>Delete Category:
        <asp:DropDownList ID="DropDownList3" runat="server"  DataTextField="Title" DataValueField="CategoryID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Delete" />
&nbsp;</strong></form>
</body>
</html>
