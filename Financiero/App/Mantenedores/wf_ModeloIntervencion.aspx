<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wf_ModeloIntervencion.aspx.cs" Inherits="Financiero.App.Mantenedores.wf_ModeloIntervencion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
     <Triggers>
        <asp:AsyncPostBackTrigger ControlID="txtCalculoManModInter" />
    </Triggers>
    </asp:UpdatePanel>
     <div class="page-header"><h1 class="text-center">Mantenedor de Modelo de Intervenci&oacute;n   </h1> </div>
    <div class="page-header">
                <h3>Datos Del Modelo</h3>
        </div>
        <div id="row">
         <div class='col-md-6'>
                    <div class="form-group">
                        <asp:Label ID="lblManModInterModAtencion" runat="server" Text="Modelo de Atención"></asp:Label>
                        <asp:DropDownList ID="ddlManModInterModAtencion" runat="server"></asp:DropDownList>            
                    </div>
         </div>
         <div class='col-md-6'>
                    <div class="form-group">
                        <asp:Label ID="lblManModInterLineaAccion" runat="server" Text="Línea de acción"></asp:Label>
                        <asp:DropDownList ID="ddlManModInterLineaAccion" runat="server"></asp:DropDownList>            
                    </div>
         </div>

        <div class='col-md-6'>
                    <div class="form-group">
                        <asp:Label ID="lblManModInter" runat="server" Text="Modelo Intervención"></asp:Label>
                        <asp:TextBox ID="txtManModInter" CssClass="form-control" runat="server"></asp:TextBox>       
                    </div>
         </div>
        <div class='col-md-6'>
                    <div class="form-group">
                        <asp:Label ID="lblManModInterNombreCorto" runat="server" Text="Nombre Corto Modelo de Intervención"></asp:Label>
                        <asp:TextBox ID="txtManModInterNombreCorto" CssClass="form-control" runat="server"></asp:TextBox>       
                    </div>
         </div>
       
        </div>
        <div class="page-header">
                <h3>Factores</h3>
        </div>
        <div class="row">
          <div class="col-md-4">
               <div class="form-group">
                        <asp:Label ID="lblManModIntFactorFijo" runat="server" Text="Factor Fijo"></asp:Label>
                        <asp:TextBox ID="txtManModIntFactorFijo" CssClass="form-control" runat="server"></asp:TextBox>       
                    </div>

          </div>
          <div class="col-md-4">
               <div class="form-group">
                        <asp:Label ID="lblManModIntFactorVariable" runat="server" Text="Factor Variable"></asp:Label>
                        <asp:TextBox ID="txtManModIntFactorVariable" CssClass="form-control" runat="server"></asp:TextBox>       
                    </div>
          </div>
            <div class="col-md-4">
                 <div class="form-group">
                        <asp:Label ID="lblManModIntFactorEdad" runat="server" Text="Factor Edad"></asp:Label>
                        <asp:TextBox ID="txtManModIntFactorEdad" CssClass="form-control" runat="server"></asp:TextBox>       
                    </div>
          </div>
          <div class="col-md-4">
               <div class="form-group">
                        <asp:Label ID="lblManModIntFactorComplejidad" runat="server" Text="Factor Complejidad"></asp:Label>
                        <asp:TextBox ID="txtManModIntFactorComplejidad" CssClass="form-control" runat="server"></asp:TextBox>       
                    </div>
          </div>
            <div class="col-md-4">
                 <div class="form-group">
                        <asp:Label ID="lblManModIntFactorDiscapacidad" runat="server" Text="Factor Discapacidad"></asp:Label>
                        <asp:TextBox ID="txtManModIntFactorDiscapacidad" CssClass="form-control" runat="server"></asp:TextBox>       
                    </div>
          </div>
          
        </div>
        <div class="page-header">
                <h3>Proceso de c&aacute;lculo</h3>
            </div>
        <div class="row">
            
            <div class='col-md-6'>
                <asp:TextBox ID="txtCalculoManModInter" CssClass="form-control" runat="server" AutoPostBack="true"></asp:TextBox>
                
            </div>
        </div>
        <div class="row">
          
            <div class='col-md-5'>    
                <asp:Button ID="btn_manModIntSum" runat="server" Text="  +  " OnClick="btn_manModIntSum_Click" />      
                <asp:Button ID="btn_manModIntRest" runat="server" Text="  -  " OnClick="btn_manModIntRest_Click" />         
                <asp:Button ID="btn_manModIntMul" runat="server" Text="  *  " OnClick="btn_manModIntMul_Click" />        
                 <asp:Button ID="btn_manModIntDiv" runat="server" Text="  /  " OnClick="btn_manModIntDiv_Click" />                
                <asp:Button ID="btn_manModIntPar1" runat="server" Text="  (  " OnClick="btn_manModIntPar1_Click" />           
                <asp:Button ID="btn_manModIntPar2" runat="server" Text="  )  " OnClick="btn_manModIntPar2_Click" />
            </div>
            <div class="col-md-5">
                <asp:Button ID="btn_modManIntZona" runat="server" Text="Zona" OnClick="btn_modManIntZona_Click" />
                 <asp:Button ID="btn_modManIntCobertura" runat="server" Text="Cobertura" OnClick="btn_modManIntCobertura_Click" />
                 <asp:Button ID="btn_modManIntCvf" runat="server" Text="Cvf" OnClick="btn_modManIntCvf_Click" />
                <asp:Button ID="btn_modManFactorUss" runat="server" Text="FactorUss" OnClick="btn_modManFactorUss_Click" />
            </div>
            <div class="col-md-5">
                <asp:Button ID="btn_ManModIntFactorFijo" runat="server" Text="Factor Fijo" OnClick="btn_ManModIntFactorFijo_Click" />
                 <asp:Button ID="btn_ManModIntFactorVariable" runat="server" Text="Factor Variable" OnClick="btn_ManModIntFactorVariable_Click" />
                 <asp:Button ID="btn_ManModIntFactorEdad" runat="server" Text="Factor Edad" OnClick="btn_ManModIntFactorEdad_Click" />
                <asp:Button ID="btn_ManModIntFactorComplejidad" runat="server" Text="Factor Complejidad" OnClick="btn_ManModIntFactorComplejidad_Click" />
                 <asp:Button ID="btn_ManModIntFactorDiscapacidad" runat="server" Text="Factor Discapacidad" OnClick="btn_ManModIntFactorDiscapacidad_Click" />
            </div>
           </div>
        <div class="row">

        </div>
       
           

        
        <div class="page-header">
                <h3>Guardar Modelo de Intervenci&iacute;n</h3>
         </div>
        <div class="row">
            <div class='col-md-12'>
                <asp:Button ID="btn_guatdarManModInt" runat="server" Text="Guardar" OnClick="btn_guatdarManModInt_Click" />
                <asp:Button ID="btn_manModIntBorrar" runat="server" Text="Borrar" OnClick="btn_manModIntBorrar_Click" />
            </div>
        </div>
            
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> 

        </div>
        
    </div>
</asp:Content>
