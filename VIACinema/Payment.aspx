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

        <div class="col-xs-12 col-md-6" runat="server" id="PanelDetails">
            <div class="panel panel-default">
              <div class="panel-heading">
                <h3 class="panel-title">Details</h3>
              </div>
              <div class="panel-body">

                <asp:Panel ID="CreditCardSelect" runat="server" Visible="false">
                    <strong><asp:Label ID="CreditCardListLabel" runat="server" Text="Your credit cards"></asp:Label></strong><br />
                    <asp:DropDownList ID="CreditCardList" runat="server" CssClass="form-control"></asp:DropDownList>
                    <hr />
                    <p class="lead text-center">Select a card or add a new one</p>
                    <hr />
                </asp:Panel>

                <asp:Panel ID="CreditCardInfo" runat="server" Visible="true">
                    <div class="form-group" runat="server" Visible="true">
                        <strong><asp:Label ID="Label1" runat="server" Text="E-Mail address"></asp:Label></strong>
                        <asp:TextBox ID="UserEmail" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <strong><asp:Label ID="CCnumberLabel" runat="server" Text="Credit Card number"></asp:Label></strong>
                        <asp:TextBox ID="CCnumber" runat="server" class="form-control" placeholder="Ex: 5555555555554444"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <strong><asp:Label ID="CCexpDateLabel" runat="server" Text="Credit Card Expiration date"></asp:Label></strong>
                        <asp:TextBox ID="CCexpDate" runat="server" class="form-control" placeholder="Ex: 0918"></asp:TextBox>
                        <div class="row">
                            <div class="col-xs-12 text-center"><small>Where in example <strong>09</strong> is a month number and <strong>18</strong> are the last 2 digits of the year</small></div>
                        </div>
                    </div>
                </asp:Panel>  

              </div>
            </div>
        </div>

    </div>
    <div class="row">
        <hr />
        <div class="text-center">
            <asp:Button ID="ConfirmPayment" runat="server" class="btn btn-success btn-lg" Text="Confirm Payment" OnClick="ConfirmPayment_Click"  />
        </div>
    </div>

</asp:Content>
