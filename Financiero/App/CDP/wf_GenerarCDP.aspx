<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wf_GenerarCDP.aspx.cs" Inherits="Financiero.App.CDP.GenerarCDP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">   
   <div class="container">
       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       </asp:UpdatePanel>
       <h1 class="text-center">Generar Nuevo Certificado de Disponibilidad Presupuestaria</h1>
        <div class="page-header">
              <h3>I. Identificación del CDP</h3>
        </div>
       <div class="row">
              
            <div class="form-group bg-input col-md-6">
     				 <asp:Label ID="lblLineaAccion" runat="server"  Text="Línea de Acción"></asp:Label>
     				 <asp:DropDownList ID="ddLinAcc" CssClass="form-control btn-sename" runat="server"></asp:DropDownList>
     		 </div>
     
              <div class="form-group bg-input col-md-6">
     				 <asp:Label ID="lblModAten" runat="server"  Text="Modelo de Atención"></asp:Label>
     				 <asp:DropDownList ID="ddModAten" CssClass="form-control btn-sename" runat="server"></asp:DropDownList>
     		 </div>
             <div class="form-group bg-input col-md-3">
                 <asp:Label ID="lblRegion" runat="server" Text="Región"></asp:Label>
                 <asp:DropDownList ID="ddRegion" CssClass="form-control btn-sename" runat="server"></asp:DropDownList>
             </div>
           <div class="form-group bg-input col-md-3">
                 <asp:Label ID="lblComuna" runat="server" Text="Comuna"></asp:Label>
                 <asp:DropDownList ID="ddComuna" CssClass="form-control btn-sename" runat="server"></asp:DropDownList>
           </div>

           <div class='col-md-3'>
                    <div class="form-group">
                        <asp:Label ID="lblFechaInicio" runat="server" Text="Fecha de inicio"></asp:Label>
                        <asp:TextBox ID="txtCalendario" CssClass="form-control" runat="server"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="ajaxCalendarFechaInicio"  runat="server" TargetControlID="txtCalendario"/>
              
                    </div>
           </div>
           <div class='col-md-3'>
                    <div class="form-group">
                        <asp:Label ID="lblCantMeses" runat="server" Text="Duración Meses"></asp:Label>
                        <asp:TextBox ID="txtCantMeses" CssClass="form-control" runat="server"></asp:TextBox>             
                    </div>
           </div>
           <div class='col-md-3'>
                    <div class="form-group">
                        <asp:Label ID="lblCantPlazas" runat="server" Text="Cantidad De Plazas"></asp:Label>
                        <asp:TextBox ID="txtCantPlazas" CssClass="form-control" runat="server"></asp:TextBox>             
                    </div>
           </div>


      </div>
   
    <div>
        <asp:Button ID="btnGenerarCDP" runat="server" CssClass="btn btn-sename-md" Text="Generar CDP" />
    </div>
    
    
 
   
   
       


 
 </div>   
    
</asp:Content>
