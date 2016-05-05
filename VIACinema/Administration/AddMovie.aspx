<%@ Page Title="Add Movie" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AddMovie.aspx.cs" Inherits="VIACinema.Administration.AddMovie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

        <div class="col-xs-12 col-md-6 col-md-offset-3">
            
            <h1>Add New Movie</h1>
            <br />

            <div class="well">
                <div class="form-group">
                    <label for="InputTitle">Title</label>
                    <asp:TextBox ID="InputTitle" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            
                <div class="form-group">
                    <label for="InputDescription">Description</label>
                    <asp:TextBox ID="InputDescription" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="InputReleaseYear">Release Year</label>
                    <asp:TextBox ID="InputReleaseYear" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="InputImageURL">Image URL</label>
                    <asp:TextBox ID="InputImageURL" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <br />
           <asp:Button ID="SubmitAddMovie" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="SubmitAddMovie_Click" />

        </div>
    </div>
</asp:Content>
