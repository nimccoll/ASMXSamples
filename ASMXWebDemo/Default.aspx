<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASMXWebDemo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>User Information</h2>
    <table class="table table-striped table-hover">
        <%
            foreach (var row in this.UserInformation)
            {
        %>
        <tr>
            <td><%: row.Key %></td>
            <td><%: row.Value %></td>
        </tr>
        <%
            }
        %>
    </table>
</asp:Content>