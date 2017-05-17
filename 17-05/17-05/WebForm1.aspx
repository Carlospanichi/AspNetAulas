<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_17_05.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="lblQntDeClickes" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            <asp:Button ID="btnEnviarCliques" runat="server" Text="Enviar" OnClick="btnEnviarCliques_Click"/>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>

