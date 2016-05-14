<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ManageReservations.aspx.cs" Inherits="VIACinema.Administration.ManageReservations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-xs-12 col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title"><strong>Reservations</strong></h3>
                </div>
                <div id="ReservationPanelBody" class="panel-body" runat="server" visible="false">
                    <div class="alert alert-warning" role="alert">No Reservetations were found! Please add one.</div>
                </div>

                <asp:datalist id="ListReservations" runat="server" onitemcommand="ListReservations_ItemCommand" class="table table-hover table-bordered">
                    <HeaderTemplate>
                        <th>Id</th>
                        <th>Price payed</th>
                        <th>Movie session Id</th>
                        <th>User Id</th>
                        <th>Seat Id</th>
                    </HeaderTemplate>

                    <ItemTemplate>
                        <td><asp:Label ID="reservationId" runat="server" Text='<%# Eval("Id") %>'></asp:Label></td>
                        <td><%# Eval("PricePayed") %></td>
                        <td><%# Eval("MovieSessionId") %></td>
                        <td><%# Eval("UserId") %></td>
                        <td><%# Eval("SeatId") %></td>
                        <td><asp:Button ID="Delete" OnClientClick="return confirm('Are you sure to delete?')" CommandName="Delete" class="btn btn-primary btn-xs btn-danger" runat="server" Text="Delete"></asp:Button></td>
                    </ItemTemplate>
                     
                 </asp:datalist>

            </div>
        </div>
    </div>
</asp:Content>
