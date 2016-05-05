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
            <asp:Panel runat="server" CssClass="MovieSessionItemContainer col-xs-6 col-sm-4 col-md-3 col-lg-2">
                <asp:Panel runat="server" CssClass="MovieSessionItem">
                    <asp:ImageButton runat="server" ImageUrl='<%# Eval("Movie.ImageUrl") %>' CssClass="MovieSessionImage" PostBackUrl='<%# "~/MovieSessionPage.aspx?Id=" + Eval("Id") %>' />
                    <asp:Panel runat="server" CssClass="MovieSessionDate"><%# Eval("SessionDate") %></asp:Panel>
                    <asp:Panel runat="server" CssClass="MovieSessionInfo"><strong><%# Eval("Movie.Title") %></strong> (<%# Eval("Movie.ReleaseYear") %>)</asp:Panel>
                </asp:Panel>
            </asp:Panel>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>