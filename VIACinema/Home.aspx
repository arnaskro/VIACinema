<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="VIACinema.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Current Movie Session programme</h1>
    <br />
    <asp:GridView ID="GridMovies" runat="server" CssClass="table table-hover table-responsive table-bordered">
    </asp:GridView>
   
    <br />
    <asp:Repeater id="ListViewMS" runat="server">
        <ItemTemplate>
            <asp:Panel runat="server" CssClass="MovieItemContainer col-xs-6 col-sm-4 col-md-3 col-lg-2">
                <asp:Panel runat="server" CssClass="MovieItem">
                    <asp:ImageButton runat="server" ImageUrl='<%# Eval("ImageUrl") %>' CssClass="MovieImage" PostBackUrl='<%# "~/MoviePage.aspx?Id=" + Eval("Id") %>' />
                    <asp:Panel runat="server" CssClass="MovieInfo"><strong><%# Eval("Title") %></strong> (<%# Eval("ReleaseYear") %>)</asp:Panel>
                </asp:Panel>
            </asp:Panel>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>