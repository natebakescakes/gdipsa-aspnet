<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication4.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="None" ErrorMessage="Name is required"></asp:RequiredFieldValidator>
        </div>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" Display="None" ErrorMessage="Email not the same"></asp:CompareValidator>
        <p>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" Display="None" ErrorMessage="Age must be 1 to 12" MaximumValue="12" MinimumValue="1" Type="Integer"></asp:RangeValidator>
        </p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" Display="None" ErrorMessage="Not recognised pattern" ValidationExpression="\d{4}"></asp:RegularExpressionValidator>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
