<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Userpage.aspx.cs" Inherits="VIACinema.Userpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-xs-12 col-md-6 col-md-offset-3">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title"><strong>Edit info</strong></h3>
                </div>
                <div class="panel-body">

                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                        <asp:TextBox ID="name" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                        <asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                    </div>

                    <asp:Label ID="Label6" runat="server" Text="Credit card info:"></asp:Label>

                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="Number"></asp:Label>
                        <asp:TextBox ID="number" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label4" runat="server" Text="ExpirationDate"></asp:Label>
                        <asp:TextBox ID="expirationdate" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>
                <div class="panel-footer text-right">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" class="btn btn-success" Text="Save changes" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
