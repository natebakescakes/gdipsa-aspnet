<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OrderPage.aspx.cs" Inherits="Workshop1.OrderPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form2" runat="server">
        <div class="page-header">
            <h1>Order Page</h1>
        </div>
        <div class="page-header">
            <h2>Select Dish</h2>
        </div>
        <asp:DropDownList ID="DishDropDownList" runat="server"></asp:DropDownList>
        <div class="page-header">
            <h2>Select Size</h2>
        </div>
        <asp:DropDownList ID="SizeDropDownList" runat="server"></asp:DropDownList>
        <div class="page-header">
            <h2>Select Option</h2>
        </div>
        <div class="align-content-center">
            <asp:RadioButtonList ID="OptionRadioButtonList" runat="server"></asp:RadioButtonList>
        </div>
        <div>
            <asp:Label ID="Label8" runat="server" Text="User ID"></asp:Label>
            <asp:TextBox ID="UserIdTextBox" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button2" class="btn-primary" runat="server" Text="Order Now" OnClick="Button1_Click" />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Back to Home</asp:HyperLink>
        </div>
    </form>
</asp:Content>
