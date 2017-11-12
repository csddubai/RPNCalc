<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RPNCalculator.aspx.cs" MasterPageFile="~/Site.Master" AutoEventWireup="true" Inherits="RPNCalCWeb.RPNCalculator"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Input"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />
        </div>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </form>
</body>
</html>
