<%@ Page Title="" Language="C#" MasterPageFile="~/Login/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LP3ProyectoFinal.Login.Login1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Login</h3>
    <label>Usuario:</label>
    <asp:TextBox ID="txtUsuarioLogin" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Ingresar" CssClass="btn btn-success" OnClick="Button1_Click" />
    <br />
    <asp:Label ID="mensaje" runat="server" Text=""></asp:Label>
</asp:Content>
