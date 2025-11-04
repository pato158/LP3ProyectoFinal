<%@ Page Title="" Language="C#" MasterPageFile="~/Administracion/Administracion.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="LP3ProyectoFinal.Administracion.Producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="text-center">Nuevo Producto</h3>
    <label>Descripcion:</label><asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDescripcion" Display="Dynamic" ErrorMessage="Ingrese el nombre del producto" ForeColor="#990000"></asp:RequiredFieldValidator>
    <br />
    <label>Precio:</label><asp:TextBox ID="txtPrecio" runat="server" ></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPrecio" Display="Dynamic" ErrorMessage="Valor del precio incorrecto" ForeColor="#990000" ValidationExpression="^\d+([.]\d{1,2})?$"></asp:RegularExpressionValidator>
    <br />
    <label>Imagen:</label><asp:FileUpload ID="FileUpload1" runat="server" />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Guardar" CssClass="btn btn-warning" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Cancelar" CssClass="btn btn-warning" OnClick="Button2_Click" />
    <br />
    <asp:Label ID="mensaje" runat="server" Text=""></asp:Label>


</asp:Content>
