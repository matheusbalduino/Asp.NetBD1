<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="teste.aspx.cs" Inherits="asp.NetBD1.teste" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <asp:Button ID="btnTestar" runat="server" CssClass="btn btn-primary"
            Text="Testar Conexão BD" OnClick="btnTestar_Click" />
        <br />
        <asp:label ID="lblResultado" runat="server" CssClass="text-capitalize"></asp:label>
    </div>
</asp:Content>
