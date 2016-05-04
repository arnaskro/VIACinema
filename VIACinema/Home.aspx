<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="VIACinema.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Current Movie Session programme</h1>
    <br />
    <asp:GridView ID="GridMovies" runat="server" CssClass="table table-hover table-responsive table-bordered">
    </asp:GridView>
&nbsp;
</asp:Content>
