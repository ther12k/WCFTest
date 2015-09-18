<%@ Page Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Input 0 or 1</h2>
    <h3>Result : <%: ViewData("Message") %></h3>
    <form action = "" method="post">
    Server (if server on the same host, this field can be empty)<br /><input type="text" name="ip" value="<%: ViewData("ip") %>" style="width:200px"/><br />
    Input <br /><input type="text" name="input" id="input" value="<%: ViewData("input") %>" style="width:50px"/><br /><br />
    <input type = "submit" />
    </form>
<span></span>
</asp:Content>
