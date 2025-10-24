<%@ Page Title="" Language="C#" MasterPageFile="~/Login/Login.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="LP3ProyectoFinal.Login.Registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4 class="text-center">Registrate como usuario</h4>
    <br />
    <div class="form">
    <label>Nombre de Usuario:</label>
    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Registrar" CssClass="btn btn-success" OnClick="Button1_Click" />
    <br />    <asp:Label ID="mensaje" runat="server" Text=""></asp:Label>
    </div>

</asp:Content>
