<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AddCreditCard.aspx.cs" Inherits="VIACinema.AddCreditCard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <div class="row">
        <div class="col-xs-12 col-md-6 col-md-offset-3">
            <div class="panel panel-default">
                <div class="panel-heading"><h3 class="panel-title"><strong>Add new Credit Card</strong></h3></div>
                <div class="panel-body">

                    <div class="form-group">
                        <strong><asp:Label ID="Label4" runat="server" Text="Credit Card number"></asp:Label></strong>
                        <asp:TextBox ID="CreditCardNumber" runat="server" class="form-control" placeholder="Ex: 4012888888881881"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <strong><asp:Label ID="Label5" runat="server" Text="Credit Card Expiration date"></asp:Label></strong>
                        <asp:TextBox ID="ExpirationDate" runat="server" class="form-control" placeholder="Ex: 0918"></asp:TextBox>
                        <div class="row">
                            <div class="col-xs-12 text-center"><small>Where in example <strong>09</strong> is a month number and <strong>18</strong> are the last 2 digits of the year</small></div>
                        </div>
                    </div>

                </div>
                <div class="panel-footer text-right"><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" class="btn btn-success" Text="Add Card" /></div>
            </div>
        </div>
    </div>

</asp:Content>
