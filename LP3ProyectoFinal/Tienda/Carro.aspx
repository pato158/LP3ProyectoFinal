<%@ Page Title="" Language="C#" MasterPageFile="~/Tienda/Tienda.Master" AutoEventWireup="true" CodeBehind="Carro.aspx.cs" Inherits="LP3ProyectoFinal.Tienda.Carro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="text-center">Mi Carrito</h3>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="mensaje" runat="server" Text=""></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Comprar" CssClass="btn btn-success" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Vaciar Carrito" CssClass="btn btn-danger" OnClick="Button2_Click" />
            <br />


            <asp:UpdateProgress runat="server" DisplayAfter="0">
                <ProgressTemplate>
                    <div class="position-relative d-flex justify-content-center" style="width: 100%;">
                        <img class="position-absolute top-50 start-50" id="loading" runat="server" src="../images/loadDonut.gif" />
                    </div>
                </ProgressTemplate>
            </asp:UpdateProgress>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:GridView ID="GridView1" CssClass="table table-striped" runat="server" EmptyDataText="Sin Productos en el carrito" AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField HeaderText="Vista Previa">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# "../images/"+Eval("img") %>' Height="80px" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
            <asp:BoundField DataField="precio" HeaderText="Precio" />
            <asp:TemplateField HeaderText="img" HeaderStyle-CssClass="d-none" ItemStyle-CssClass="d-none"></asp:TemplateField>

        </Columns>

    </asp:GridView>
    <asp:GridView ID="GridView2" CssClass="table table-striped" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Producto" HeaderText="Descripción" />
            <asp:BoundField DataField="img" HeaderText="Cantidad" />
            <asp:BoundField DataField="Precio" HeaderText="Precio" />
        </Columns>
    </asp:GridView>

</asp:Content>
