<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wf_Regiones.aspx.cs" Inherits="Financiero.App.Mantenedores.wf_Regiones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
       
       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       </asp:UpdatePanel>
       
       <h1 class="text-center">Mantenedor Regiones</h1>
        <div class="page-header">
              <h3>I. Identificación de Regi&oacute;n</h3>
        </div>
       <div class="row">
              
           <div class='col-md-6'>
                    <div class="form-group">
                        <asp:Label ID="lblManRegion" runat="server" Text="Región"></asp:Label>
                        <asp:TextBox ID="txtManRegion" CssClass="form-control" runat="server"></asp:TextBox>             
                    </div>
           </div>
           <div class='col-md-6'>
                    <div class="form-group">
                        <asp:Label ID="lblManRegionNombreCorto" runat="server" Text="Nombre Corto"></asp:Label>
                        <asp:TextBox ID="txtManRegionNombreCorto" CssClass="form-control" runat="server"></asp:TextBox>             
                    </div>
           </div>


      
   
   
        <asp:Button ID="btnGuardarRegion" runat="server" CssClass="btn btn-sename-md" Text="Guardar Región" OnClick="btnGuardarRegion_Click" />
        <asp:Label ID="Alerta" runat="server" Text=""></asp:Label>
        <br />
       </div>
         <div class="row">
            <div class="panel panel-default">
                <h1 class="text-center">Ver Regiones </h1>
                <div class="table-responsive">
           <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>


                    

        </div>
                </div>

             
        </div>

        <div id="Result">
        
           

        </div>


        <div id="myDiv" style="width:300px; height:300px; position:fixed; left:100px; top:100px; background-color:#666666;">
            <div class='col-md-6'>
            <div class="form-group">
                <asp:Label ID="lbl1" runat="server" Text="Región"></asp:Label>
                <asp:TextBox ID="txt1" CssClass="form-control" runat="server"></asp:TextBox>             
            </div>
            </div>
            <div class='col-md-6'>
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Nombre Corto"></asp:Label>
                        <asp:TextBox ID="txt2" CssClass="form-control" runat="server"></asp:TextBox> 
                        <input ID="txt5" class="form-control" type="text" />            
                    </div>
            </div>
        </div>
      
        

    </div>

    <script>
       
        function getDate() {
            PageMethods.set_path("/App/Manetenedores/wf_Regiones.aspx");      
            $.ajax({
                type: "POST",
                url: "/App/Mantenedores/wf_Regiones.aspx/getDate",
                data: "{}",
                contentType: "application/json; charset=utf-8",
                //dataType: "json",
                success: function (msg) {
                    // Replace the div's content with the page method's return.

                    //alert(msg);
                    alert(msg.d);
                    
                    //$("#myDiv").text(msg.d);
                    //$("#txt1").text(msg.d);
                    $("#txt5").val(msg.d);
                    
                    /*if (msg.d) {
                        //$("#Result").text(msg.d);
                        alert("Yahoo");
                    } else {
                        alert("Errorrrr");
                    }*/
                }
            });
        }

    </script>
        
        

</asp:Content>
