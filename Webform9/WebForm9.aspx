<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="adoDemo1.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div><h1>Dataset Caching </h1>
      
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Load Data" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Clear Cache" />
        <br />
        <asp:Label ID="Label1" runat="server" ></asp:Label>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
      
    </div>
    </form>
</body>
</html>
