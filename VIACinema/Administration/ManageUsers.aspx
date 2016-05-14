<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ManageUsers.aspx.cs" Inherits="VIACinema.ManageUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
         <div class="col-xs-12 col-md-12">
             <div class="panel panel-default">
                <div class="panel-heading"><h3 class="panel-title"><strong>Users</strong></h3></div>
                <div id="UserPanelBody" class="panel-body" runat="server" Visible="false">
                    <div class="alert alert-warning" role="alert">No Users were found! Please add one.</div>
                </div>

                 <asp:DataList ID="ListUsers" runat="server" OnItemCommand="ListUsers_ItemCommand"  class="table table-hover table-bordered">
                    <HeaderTemplate>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Email</th>
                        <th>Address</th>
                        <th>Actions</th>
                    </HeaderTemplate>

                    <ItemTemplate>
                        <td><asp:Label ID="userId" runat="server" Text='<%# Eval("Id") %>'></asp:Label></td>
                        <td><%# Eval("Name") %></td>
                        <td><%# Eval("Email") %></td>
                        <td><%# Eval("Address") %></td>
                        <td><asp:Button ID="Delete" OnClientClick="return confirm('Are you sure to delete?')" CommandName="Delete" class="btn btn-primary btn-xs btn-danger" runat="server" Text="Delete"></asp:Button></td>
                    </ItemTemplate>
                     
                 </asp:DataList>

             </div>
        </div>
    </div>
</asp:Content>
