<%@ Page Title="Add Stage" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AddStage.aspx.cs" Inherits="VIACinema.Administration.AddStage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="row">

        <div class="col-xs-12 col-md-6 col-md-offset-3">
            
            <h1>Add New Stage</h1>
            <br />
            
            <div class="well">
                <div class="form-group">
                    <label for="InputTitle">Title</label>
                    <asp:TextBox ID="InputTitle" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            
                <div class="form-group">
                    <label for="InputMaxSeats">Number of Seats</label>
                    <asp:TextBox ID="InputMaxSeats" runat="server" CssClass="form-control" type="number"></asp:TextBox>
                </div>
            </div>

            <br />
           <asp:Button ID="SubmitAddStage" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="SubmitAddStage_Click" />

        </div>
    </div>
</asp:Content>
