<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exercicio15-05.aspx.cs" Inherits="_17_05.Exercicio15_05" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            </br>
            <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtvalor2" runat="server"></asp:TextBox>
            <asp:Button ID="btnSoma" runat="server" OnClick="btnSoma_Click" Text="+" />
            <asp:Button ID="btnIgual" runat="server" OnClick="btnIgual_Click" Text="=" />
            </br>
            </br>
            <asp:Label ID="lblresultado" runat="server" Text="A Soma dos valores é: "></asp:Label>
            <asp:TextBox ID="txtResuldado" runat="server"></asp:TextBox>
            </br>
            <asp:Label ID="Label1" runat="server" Text="Subtração: "></asp:Label>            
            <asp:Label ID="lblsub" runat="server" Text="Label"></asp:Label>
            </br> 
            <asp:Label ID="Label2" runat="server" Text="Multiplicação: "></asp:Label>
            <asp:Label ID="lblmult" runat="server" Text="Label"></asp:Label>
            </br> 
            <asp:Label ID="Label3" runat="server" Text="Divisão: "></asp:Label>
            <asp:Label ID="lbldiv" runat="server" Text="Label"></asp:Label>
        </ContentTemplate>

    </asp:UpdatePanel>
</asp:Content>
