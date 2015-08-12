<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wf_Provincias.aspx.cs" Inherits="Financiero.App.Mantenedores.wf_Provincias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
       
       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       </asp:UpdatePanel>
       
       <h1 class="text-center">Mantenedor Provincias</h1>
        <div class="page-header">
              <h3>I. Identificación de la provincia</h3>
        </div>
       <div class="row">
              
           <div class='col-md-6'>
                    <div class="form-group">
                        <asp:Label ID="lblSelRegion" runat="server" Text="Region"></asp:Label>
                       <asp:DropDownList ID="ddlRegion" CssClass="form-control btn-sename" runat="server"></asp:DropDownList>            
                    </div>
           </div>
           <div class='col-md-6'>
                    <div class="form-group">
                        <asp:Label ID="lblManProvincia" runat="server" Text="Nombre"></asp:Label>
                        <asp:TextBox ID="txtManProvincia" CssClass="form-control" runat="server"></asp:TextBox>             
                    </div>
           </div>


      
   
   
        <asp:Button ID="btnGuardarProvincia" runat="server" CssClass="btn btn-sename-md" Text="Guardar Provincia" />
        <asp:Label ID="Alerta" runat="server" Text=""></asp:Label>
        <br />
       </div>
         </div>
</asp:Content>
