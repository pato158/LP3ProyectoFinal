<%@ Page Title="" Language="C#" MasterPageFile="~/Login/Login.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="LP3ProyectoFinal.Login.Registrar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4 class="text-center">Registrate como usuario</h4>
    <br />
    <div class="form">
        <label>Nombre de User:</label>
        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ingrese Nombre de Usuario" ForeColor="#990000" ControlToValidate="txtUser" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
        <label>Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>
        &nbsp;<asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Ingrese su nombre " ForeColor="#990000" ControlToValidate="txtnombre"></asp:RequiredFieldValidator>
        <br />
        <asp:DropDownList ID="idRol" runat="server">
             <asp:ListItem Value="0">Seleccione un rol</asp:ListItem>
            <asp:ListItem Value="1">Cliente</asp:ListItem>
            <asp:ListItem Value="2">Administrador</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="idRol" ErrorMessage="Seleccione un Rol" ForeColor="#990000" InitialValue="0"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Registrar" CssClass="btn btn-success" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="mensaje" runat="server" Text=""></asp:Label>
    </div>

</asp:Content>
