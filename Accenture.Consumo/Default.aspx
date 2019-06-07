<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Accenture.Consumo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p><b><asp:Label ID="lblNombreUsuario" runat="server">NOMBRE DE USUARIO</asp:Label></b></p>
        <p><asp:Label ID="lblUserName" runat="server">NOMBRE DE USER</asp:Label></p>
        <p><b><asp:Label ID="lblTituloPost" runat="server">TITULO DE POST</asp:Label></b></p>
        <p><asp:Label ID="lblTitlePost" runat="server">TITULO DE POST</asp:Label></p>
        <p><b><asp:Label ID="lblCuerpoPost" runat="server">BODY DEL POST</asp:Label></b></p>
        <p><asp:Label ID="lblBodyPost" runat="server">BODY DEL POST</asp:Label></p>
        <p><b><asp:Label ID="lblTituloAlbum" runat="server">TITLE ALBUM</asp:Label></b></p>
        <p><asp:Label ID="lblTitleAlbum" runat="server">TITLE ALBUM</asp:Label></p>
    </div>

    <div class="row">
        <div class="col-md-12">
            <p><b><asp:Label ID="lblNombreComentario" runat="server">Nombre del comentario:</asp:Label></b>
            <asp:Label ID="lblNameComment" runat="server">name comment</asp:Label></p>
           
    
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
   <p><b><asp:Label ID="lblCorreoComentario" runat="server">Correo del comentario:</asp:Label></b>
                <asp:Label ID="lblEmailComment" runat="server">email comment</asp:Label></p>
        </div>
    </div>

    <div class="row">
        <div class="col-md-12">
                    <p><b><asp:Label ID="lblCuerpoComentario" runat="server">Cuerpo del comentario:</asp:Label></b>
                <asp:Label ID="lblBodyComment" runat="server">body comment</asp:Label></p>
        </div>
    </div>

</asp:Content>
