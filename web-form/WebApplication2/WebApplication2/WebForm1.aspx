<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 262px;
            width: 969px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Message" runat="server" Text="Label"></asp:Label>
    
    </div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" DataSourceID="SqlDataSource2" DataTextField="Title" DataValueField="Title">
            <asp:ListItem Value="Test0"></asp:ListItem>
            <asp:ListItem Value="valueF">textF</asp:ListItem>
            <asp:ListItem>hahha</asp:ListItem>
        </asp:DropDownList>
        &nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:webform_s3301108ConnectionString2 %>" SelectCommand="SELECT [Title] FROM [Category]"></asp:SqlDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="CategoryID" DataSourceID="SqlDataSource1" Height="226px" Width="465px" AllowPaging="True">
            <Fields>
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" InsertVisible="False" ReadOnly="True" SortExpression="CategoryID" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="ImageUrl" HeaderText="ImageUrl" SortExpression="ImageUrl" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:webform_s3301108ConnectionString %>" SelectCommand="SELECT * FROM [Category]" DeleteCommand="DELETE FROM [Category] WHERE [CategoryID] = @CategoryID" InsertCommand="INSERT INTO [Category] ([Title], [ImageUrl]) VALUES (@Title, @ImageUrl)" UpdateCommand="UPDATE [Category] SET [Title] = @Title, [ImageUrl] = @ImageUrl WHERE [CategoryID] = @CategoryID">
            <DeleteParameters>
                <asp:Parameter Name="CategoryID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="ImageUrl" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="ImageUrl" Type="String" />
                <asp:Parameter Name="CategoryID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
 </body>
</html>
