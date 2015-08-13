<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wf_ModeloIntervencion.aspx.cs" Inherits="Financiero.App.Mantenedores.wf_ModeloIntervencion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <Triggers>
        <asp:AsyncPostBackTrigger ControlID="TextBox1" />
    </Triggers>
    </asp:UpdatePanel>
    <asp:Button ID="btn_manModIntPlazas" runat="server" Text="Plazas" OnClick="btn_manModIntPlazas_Click" />
    <asp:Button ID="btn_manModIntBorrar" runat="server" Text="Button" OnClick="btn_manModIntBorrar_Click" />
    <asp:Button ID="btn_manModIntSum" runat="server" Text="+" OnClick="btn_manModIntSum_Click" />
    <asp:Button ID="btn_manModIntRest" runat="server" Text="-" OnClick="btn_manModIntRest_Click" />
    <asp:Button ID="btn_manModIntMul" runat="server" Text="*" OnClick="btn_manModIntMul_Click" />
    <asp:Button ID="btn_manModIntDiv" runat="server" Text="/" OnClick="btn_manModIntDiv_Click" />
    <div class='col-md-6'>
        
    <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" AutoPostBack="true"></asp:TextBox>
    </div>
</asp:Content>
