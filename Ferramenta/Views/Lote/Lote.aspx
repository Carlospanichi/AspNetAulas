<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lote.aspx.cs" Inherits="Ferramenta.Views.Lote.Lote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <h1>CADASTRAR LOTE</h1>
            <div class="form-group">
                <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
                <asp:TextBox ID="txtMatricula" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
                <asp:TextBox ID="txtDescricao" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>                    
            <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
