<%@ Page Title="" Language="C#"  EnableEventValidation="false" MasterPageFile="~/Administracion/Administracion.Master" AutoEventWireup="true" CodeBehind="IndexAdmin.aspx.cs" Inherits="LP3ProyectoFinal.Administracion.IndexAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="text-center">Administracion de la tienda</h3>
    <asp:GridView ID="GridView1" CssClass="table table-striped" runat="server" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:linkButton ID="Button1" runat="server" Text="Editar" CommandName="editar" CssClass="btn btn-warning" CausesValidation="false" CommandArgument='<%# Container.DataItemIndex %>'
/>
                    <asp:LinkButton ID="Button2" runat="server" Text="Eliminar" CommanName="eliminar" CssClass="btn btn-warning" CausesValidation="false" CommandArgument='<%# Container.DataItemIndex %>'
 />
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>
    <div class="position-absolute d-flex justify-content-center" id="divEditar" runat="server" style="top: 0; left: 0; width: 100%; height: 100%; z-index: 1050; background-color: rgba(0,0,0,0.5);">
        <formview class=" d-flex justify-content-center align-items-center">
            <div class="mb-3 border border-warning p-2  " style="max-width: 50vw; min-width: 30vw;  background-color: rgb(201, 227, 232);">
                <label class="form-label">Descripcion:</label>
                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
                 <asp:TextBox ID="txtDescripcioOriginal" runat="server" CssClass="d-none" ></asp:TextBox>
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
                <asp:Button ID="Button1" runat="server" Text="Guardar" CssClass="btn btn-warning" CausesValidation="true"  OnClick="Button1_Click"/>
                <asp:Button ID="Button2" runat="server" Text="Cerrar" CssClass="btn btn-warning" OnClick="Button2_Click" CausesValidation="false"/>
                <br />
                <asp:Label ID="mensaje" runat="server" Text=""></asp:Label>
            </div>
        </formview>
    </div>
</asp:Content>
