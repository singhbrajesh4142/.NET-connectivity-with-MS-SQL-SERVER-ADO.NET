<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="adoDemo1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>stored procedure with output parameter</h1>
        <p>Employee Name:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="empName" runat="server"></asp:TextBox>
        </p>
        <p>Gender:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="genderList" runat="server">
                <asp:ListItem>male</asp:ListItem>
                <asp:ListItem>female</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>Salary:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="empSalary" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </p>
        <p>
            <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
        </p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>

    </div>
    </form>
</body>
</html>
