<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PoC.ClientRequestAudit.WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin: 25px">
        <ul>
            <li>Browser: <%= ViewModel.Browser %></li>
            <li>IPAddress: <%= ViewModel.IPAddress %></li>
            <li>OperatingSystem: <%= ViewModel.OperatingSystem %></li>
            <li>IsMobileDevice: <%= ViewModel.IsMobileDevice %></li>
        </ul>
    </div>
</asp:Content>
