<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GenerarCDP.aspx.cs" Inherits="Financiero.App.CDP.GenerarCDP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">   
   
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">



    </asp:UpdatePanel>
    <asp:Label ID="lblModeloAtencion" runat="server" Text="Modelo de Atencion"></asp:Label>
    <asp:DropDownList ID="DDModeloAtencion" runat="server"></asp:DropDownList>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>      
    
   
    
   
   <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
     

    <script>holamundo();</script>  
    <asp:Panel ID="Panel1" runat="server" CssClass="panel1"></asp:Panel> 
   <ajaxToolkit:ModalPopupExtender runat="server" ID="mpuASD"
       CancelControlID ="Button1"
       OnCancelScript="Cancel()" 
       PopupControlID="Panel1"
       TargetControlID="Button1">
   </ajaxToolkit:ModalPopupExtender>
       
   <script type="text/javascript">
       
      
</script>
    
</asp:Content>
