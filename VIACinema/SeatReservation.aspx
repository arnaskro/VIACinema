<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SeatReservation.aspx.cs" Inherits="VIACinema.SeatReservation" EnableEventValidation="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header">
        <h1><span class="glyphicon glyphicon-bookmark"></span> Choose your seats</h1>
    </div>

    <asp:Repeater ID="Seats" runat="server" OnItemCommand="Seats_ItemCommand">
        <HeaderTemplate>
            <ul class="seatlist well">
        </HeaderTemplate>
        <ItemTemplate>
            <li><asp:ImageButton ID="ImageButton1" runat="server" class="seat" ImageUrl="~/Content/images/seat-black.png"/></li>
        </ItemTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>

    <hr />

    <div class="text-center">
        <p class="lead">Continue only when you have chosen your seats!</p>
        <asp:Button ID="BtnSubmit" runat="server" Text="Continue" CssClass="btn btn-success btn-lg"/>
    </div>

</asp:Content>
