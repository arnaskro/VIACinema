<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MoviePage.aspx.cs" Inherits="VIACinema.MoviePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="page-header">
        <h1 id="MovieHeading" runat="server"><span class="glyphicon glyphicon-film"></span> <strong><span id="MovieTitle" runat="server">Movie</span></strong> <small>(<span id="MovieYear" runat="server">2016</span>)</small></h1>
    </div>

    
    <div class="row">
        <div class="col-xs-12 col-md-4">
            <asp:Image ID="MovieImage" runat="server" CssClass="thumbnail MoviePageImage" />
        </div>
        <div class="col-xs-12 col-md-7">
            <h4>Description:</h4>
            <div class="well well-lg">
                <p id="MovieDescription" runat="server"></p>
            </div>
            <br />
            <h4>Number of people who have watched this movie:</h4>
            <h1 id="MovieViews" runat="server">0</h1>
        </div>
    </div>

    <div class="page-header">
        <h2><span class="glyphicon glyphicon-tags"></span> <strong>Available Movie Sessions</strong></h2>
    </div>

    <asp:Repeater id="UpcomingMovieSessions" runat="server">
        <HeaderTemplate>
            <table class="table table-bordered table-hover table-responsive">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Session Date</th>
                        <th>Ticket Price</th>
                        <th>Stage</th>
                        <th>Seats left available</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("Id") %></td>
                <td><%# Eval("SessionDate") %></td>
                <td><%# Eval("Price") %></td>
                <td><%# Eval("Stage.Title") %></td>
                <td><%# GetNumberOfSeats(Eval("Id")) %></td>
                <td><a href='<%# "~/SeatReservation.aspx?Id=" + Eval("Id") %>' class="btn btn-primary btn-xs" runat="server">Buy Tickets</a></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </tbody></table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
