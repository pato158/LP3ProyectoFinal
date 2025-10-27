<%@ Page Title="" Language="C#" MasterPageFile="~/Tienda/Tienda.Master" AutoEventWireup="true" CodeBehind="IndexTienda.aspx.cs" Inherits="LP3ProyectoFinal.Tienda.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="text-center">Tienda Oficial  The Simpsons</h3>
    <br />
    <div class="d-flex flex-wrap">
        <asp:PlaceHolder ID="phProductos" runat="server" />
    </div>
<script type="text/javascript">
    function Comprar(producto) {       
        document.cookie = producto + "=" + producto + "; path=/; max-age=36000"; 
        
    }
    function Eliminar(producto) {
        document.cookie = producto+"=; path=/; max-age=0";
        
    }
   
</script>
</asp:Content>