<%@ Page Title="Registration" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="VIACinema.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="row">
        <div class="col-xs-12 col-md-6 col-md-offset-3">
            <div class="panel panel-default">
                <div class="panel-heading"><h3 class="panel-title"><strong>Sign In</strong></h3></div>
                <div class="panel-body">

                    <div class="form-group">
                        <asp:Label ID="Label9" runat="server" Text="Name:"></asp:Label>
                        <asp:TextBox ID="name" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Address:"></asp:Label>
                        <asp:TextBox ID="address" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label5" runat="server" Text="Email:"></asp:Label>
                        <asp:TextBox ID="email" runat="server" TextMode="Email" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label6" runat="server" Text="Password:"></asp:Label>
                        <asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>
                <div class="panel-footer text-right"><asp:Button ID="Button2" runat="server" OnClick="Button1_Click" class="btn btn-success" Text="Register" /></div>
            </div>
        </div>
    </div>
</asp:Content>
