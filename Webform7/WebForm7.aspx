<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="adoDemo1.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div><h1>SqlDataAdapter</h1>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Get Product By Id" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server" ></asp:GridView>
    </div>
    </form>
</body>
</html>
