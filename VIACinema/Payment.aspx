<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="VIACinema.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header">
        <h1><span class="glyphicon glyphicon-shopping-cart"></span> Payment</h1>
    </div>

    <div class="row">
        <div class="col-xs-12 col-md-6">
            <div class="panel panel-default">
              <div class="panel-heading">
                <h3 class="panel-title">Reservation info</h3>
              </div>
              <div class="panel-body">
                <dl class="dl-horizontal">
                  <dt>Movie:</dt>
                  <dd ID="InfoMovie" runat="server">?</dd>
                  <dt>Stage:</dt>
                  <dd ID="InfoStage" runat="server">?</dd>
                  <dt>Session date:</dt>
                  <dd ID="InfoDate" runat="server">?</dd>
                  <dt>Ticket price:</dt>
                  <dd ID="InfoPrice" runat="server">?</dd>
                  <dt>Number of seats:</dt>
                  <dd ID="InfoSeats" runat="server">?</dd>
                  <hr />
                  <dt>Total price to pay:</dt>
                  <dd ID="InfoTotalPrice" class="lead" runat="server">?</dd>
                </dl>
              </div>
            </div>
        </div>

        <div class="col-xs-12 col-md-6">
            <div class="panel panel-default">
              <div class="panel-heading">
                <h3 class="panel-title">Details</h3>
              </div>
              <div class="panel-body">

                <asp:Panel ID="CreditCardSelect" runat="server" Visible="false">
                    <asp:Label ID="CreditCardListLabel" runat="server" Text="Your credit cards"></asp:Label><br />
                    <asp:DropDownList ID="CreditCardList" runat="server" CssClass="form-control"></asp:DropDownList>
                    <hr />
                    <p class="lead text-center">Select a card or add a new one</p>
                    <hr />
                </asp:Panel>

                <asp:Panel ID="CreditCardInfo" runat="server" Visible="true">
                    <div class="form-group">
                        <asp:Label ID="CCnumberLabel" runat="server" Text="Credit Card number"></asp:Label>
                        <asp:TextBox ID="CCnumber" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="CCexpDateLabel" runat="server" Text="Credit Card Expiration date"></asp:Label>
                        <asp:TextBox ID="CCexpDate" runat="server" class="form-control" type="date"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="CCcodeLabel" runat="server" Text="Credit Card CVC code"></asp:Label>
                        <asp:TextBox ID="CCcode" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </asp:Panel>  

              </div>
            </div>
        </div>
    </div>
</asp:Content>
