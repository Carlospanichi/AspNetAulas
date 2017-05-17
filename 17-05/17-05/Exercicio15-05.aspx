<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exercicio15-05.aspx.cs" Inherits="_17_05.Exercicio15_05" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br>
            <br></br>
            <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtvalor2" runat="server"></asp:TextBox>
            <asp:Button ID="btnSoma" runat="server" OnClick="btnSoma_Click" Text="+" />
            <asp:Button ID="btnIgual" runat="server" OnClick="btnIgual_Click" Text="=" />
            <br>
            <br></br>
            <asp:Label ID="lblresultado" runat="server" Text="A Soma dos valores é: "></asp:Label>
            <asp:TextBox ID="txtResuldado" runat="server"></asp:TextBox>
            <br>
            <br></br>
            </br>
            </br>
            </br>
        </ContentTemplate>

    </asp:UpdatePanel>
</asp:Content>
