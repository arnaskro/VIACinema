<%@ Page Title="Add Movie Session" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AddMovieSession.aspx.cs" Inherits="VIACinema.Administration.AddMovieSession" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">

        <div class="col-xs-12 col-md-6 col-md-offset-3">
            
            <h1>Add New Movie Session</h1>
            <br />
            <div class="well">
                <div class="form-group">
                    <label for="InputMovie">Movie</label>
                    <asp:DropDownList ID="InputMovie" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>

                <div class="form-group">
                    <label for="InputStage">Stage</label>
                    <asp:DropDownList ID="InputStage" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
            
                <div class="form-group">
                    <label for="InputPrice">Ticket price</label>
                    <asp:TextBox ID="InputPrice" runat="server" CssClass="form-control" placeholder="How much will a ticket cost?"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="InputSessionDate">Session Date</label>
                    <asp:TextBox ID="InputSessionDate" runat="server" CssClass="form-control" type="date"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="InputSessionTime">Session Time</label>
                    <asp:TextBox ID="InputSessionTime" runat="server" CssClass="form-control" type="time"></asp:TextBox>
                </div>
            </div>
            
            <br />
           <asp:Button ID="SubmitAddMovieSession" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="SubmitAddMovieSession_Click" />

        </div>
    </div>
</asp:Content>
