<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ferramentas.aspx.cs" Inherits="Ferramenta.Views.Ferramentas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <h1>CADASTRAR FERRAMENTAS</h1>
            <div class="form-group">
                <asp:Label ID="lblMatricula" runat="server" Text="Matricula"></asp:Label>
                <asp:TextBox ID="txtMatricula" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblDiametro" runat="server" Text="Diametro"></asp:Label>
                <asp:TextBox ID="txtDiametro" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblLote" runat="server" Text="Lote"></asp:Label>
                <asp:TextBox ID="txtLote" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" />
            <asp:Button ID="btnLimpar" CssClass="btn btn-primary" runat="server" Text="Limpar" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
