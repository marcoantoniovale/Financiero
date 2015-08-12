<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wf_LineaAccionaspx.aspx.cs" Inherits="Financiero.App.Mantenedores.wf_LineaAccionaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container">
       
       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       </asp:UpdatePanel>
       
       <h1 class="text-center">Mantenedor L&iacute;neas de Acci&oacute;n</h1>
        <div class="page-header">
              <h3>I. Identificaci&oacute;n de L&iacute;nea de Acci&oacute;n</h3>
        </div>
       <div class="row">
              
           <div class='col-md-6'>
                    <div class="form-group">
                        <asp:Label ID="lblManLinea" runat="server" Text="Linea de Accion"></asp:Label>
                        <asp:TextBox ID="txtManLinea" CssClass="form-control" runat="server"></asp:TextBox>             
                    </div>
           </div>

      <div class='col-md-6'>
   
   </div>
          <br />
        <asp:Button ID="btnGuardarLinea" runat="server" CssClass="btn btn-sename-md" Text="Guardar Línea de Acción" OnClick="btnGuardarLinea_Click" />
        <asp:Label ID="Alerta" runat="server" Text=""></asp:Label>
        <br />
                
       </div>
         </div>
</asp:Content>
