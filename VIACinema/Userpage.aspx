<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="VIACinema.UserPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="row">
        <div class="col-xs-12 col-md-6">
            <div class="panel panel-default">
                <div class="panel-heading"><h3 class="panel-title"><strong>Edit User info</strong></h3></div>
                <div class="panel-body">

                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="Email" runat="server" autocomplete="off" TextMode="Email" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
                        <asp:TextBox ID="Name" runat="server" autocomplete="off" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label6" runat="server" Text="Address"></asp:Label>
                        <asp:TextBox ID="Address" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    
                </div>
                <div class="panel-footer text-right"><asp:Button ID="SubmitChanges" runat="server" class="btn btn-success" Text="Save Changes" OnClick="SubmitChanges_Click" /></div>
            </div>
        </div>
    
        <div class="col-xs-12 col-md-6">
             <div class="panel panel-default">
                <div class="panel-heading"><h3 class="panel-title"><strong>Credit Cards</strong></h3></div>
                <div id="CreditCardPanelBody" class="panel-body" runat="server" Visible="false">
                    <div class="alert alert-warning" role="alert">No Credit Cards were found! Please add one.</div>
                    <div class="text-center"><a href="/AddCreditCard.aspx"  class="btn btn-primary btn-xs btn-success"><span class="glyphicon glyphicon-plus" aria-hidden="true"></span> Add new credit card</a></div>
                </div>

                 <asp:DataList ID="ListCreditCards" runat="server" OnItemCommand="ListCreditCards_ItemCommand"  class="table table-hover table-bordered">
                    <HeaderTemplate>
                        <th>ID</th>
                        <th>Credit Card Number</th>
                        <th>Expiration Date</th>
                        <th>Actions</th>
                    </HeaderTemplate>

                    <ItemTemplate>
                        <td><asp:Label ID="ccCardId" runat="server" Text='<%# Eval("Id") %>'></asp:Label></td>
                        <td><%# Eval("Code") %></td>
                        <td><%# Eval("ExpirationDate") %></td>
                        <td><asp:Button ID="Delete" OnClientClick="return confirm('Are you sure to delete?')" CommandName="Delete" class="btn btn-primary btn-xs btn-danger" runat="server" Text="Delete"></asp:Button></td>
                    </ItemTemplate>
                     
                    <FooterTemplate>
                        <td colspan="4" class="text-center">
                            <a href="/AddCreditCard.aspx"  class="btn btn-primary btn-xs btn-success"><span class="glyphicon glyphicon-plus" aria-hidden="true"></span> Add new credit card</a>
                        </td>
                    </FooterTemplate>
                 </asp:DataList>

             </div>
        </div>
    </div>

</asp:Content>
