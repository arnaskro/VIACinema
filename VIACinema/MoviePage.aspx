<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MoviePage.aspx.cs" Inherits="VIACinema.MoviePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header">
        <h1 id="MovieHeading" runat="server"><strong><span id="MovieTitle" runat="server">Movie</span></strong> <small>(<span id="MovieYear" runat="server">2016</span>)</small></h1>
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
            <h1 id="NumberOfPeople" runat="server">0</h1>
        </div>
    </div>

</asp:Content>
