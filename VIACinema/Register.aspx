<%@ Page Title="Registration" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="VIACinema.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    </p>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="name" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Adress:"></asp:Label>
        <asp:TextBox ID="address" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label5" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
</div>
    <div>
        <asp:Label ID="Label6" runat="server" Text="Password:"></asp:Label>
        &nbsp;<asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Credit card number:"></asp:Label>
        <asp:TextBox ID="creditCardNumber" runat="server"></asp:TextBox>
</div>
    <div>
        <asp:Label ID="Label4" runat="server" Text="Credit card expiration dates:"></asp:Label>
        <asp:TextBox ID="expirationDates" runat="server"></asp:TextBox>
</div>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
</asp:Content>
