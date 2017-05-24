<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="Aula_24_05_EF_MF.Views.Categorias.Lista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    </br>
    <asp:Label runat="server" Text="CADASTRO DE CATEGORIAS"></asp:Label>
    </br></br>
    <asp:Label runat="server" Text="NOME"></asp:Label>
    </br>
    <asp:TextBox ID="txtNomeCat" runat="server"></asp:TextBox>
    </br></br>
    <asp:Label runat="server" Text="DESCRIÇÃO"></asp:Label>
    </br>
    <asp:TextBox ID="txtDescricaoCat" runat="server" Height="54px" Width="175px"></asp:TextBox>
    </br>
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
</asp:Content>
