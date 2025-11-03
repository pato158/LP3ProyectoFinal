<%@ Page Title="" Language="C#" MasterPageFile="~/Login/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LP3ProyectoFinal.Login.Login1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <h3>Login</h3>
    <label>Usuario:</label>
    <asp:TextBox ID="txtUsuarioLogin" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsuarioLogin" ErrorMessage="RequiredFieldValidator" ForeColor="#990000">Ingrese un Usuario</asp:RequiredFieldValidator>
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Button ID="Button1" runat="server" Text="Ingresar" CssClass="btn btn-success" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="mensaje" runat="server" Text=""></asp:Label>
          

            <asp:UpdateProgress runat="server" DisplayAfter="0">
                <ProgressTemplate>
                    <img src="../images/loadDonut.gif" />
                </ProgressTemplate>
            </asp:UpdateProgress>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
