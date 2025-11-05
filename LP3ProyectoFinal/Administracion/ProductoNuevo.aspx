<%@ Page Title="" Language="C#" MasterPageFile="~/Administracion/Administracion.Master" AutoEventWireup="true" CodeBehind="ProductoNuevo.aspx.cs" Inherits="LP3ProyectoFinal.Administracion.ProductoNuevo1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h3 class="text-center">Nuevo Producto</h3>

    <formview class=" d-flex justify-content-center align-items-center">
        <div class="mb-3 border border-warning p-2  " style="max-width: 50vw; min-width: 30vw;">
            <label class="form-label">Descripcion:</label>
            <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDescripcion" Display="Dynamic" ErrorMessage="Ingrese el nombre del producto" ForeColor="#990000"></asp:RequiredFieldValidator>
            <br />
            <label class="form-label">Precio:</label>
            <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPrecio" Display="Dynamic" ErrorMessage="Valor del precio incorrecto " ForeColor="#990000" ValidationExpression="^\d+([.]\d{1,2})?$"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPrecio" Display="Dynamic" ErrorMessage=" Ingrese el valor del producto" ForeColor="#990000"></asp:RequiredFieldValidator>
            <br />
            <label class="form-label">Imagen:</label>
            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Guardar" CssClass="btn btn-warning" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Cancelar" CssClass="btn btn-warning" OnClick="Button2_Click" />
            <br />
            <asp:Label ID="mensaje" runat="server" Text=""></asp:Label>
        </div>
    </formview>

</asp:Content>
