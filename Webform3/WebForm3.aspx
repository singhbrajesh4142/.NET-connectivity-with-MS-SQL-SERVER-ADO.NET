<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="adoDemo1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>SQL injection prevention using stored procedure</h1>
        <asp:TextBox ID="textBox1" runat="server" ></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" /><br /><br />
        <asp:GridView ID="gridView1" runat="server" ></asp:GridView>
    </div>
    </form>
</body>
</html>
