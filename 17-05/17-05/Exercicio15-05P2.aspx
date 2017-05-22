<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exercicio15-05P2.aspx.cs" Inherits="_17_05.Exercicio15_05P2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            </br>
            <asp:TextBox ID="txtAdd1" runat="server"></asp:TextBox>
            <asp:Label ID="lblSoma1" runat="server" Text="+"></asp:Label>
            <asp:TextBox ID="txtAdd2" runat="server"></asp:TextBox>
            <asp:Label ID="lblResult1" runat="server" Text="="></asp:Label>
            <asp:TextBox ID="txtResultSoma" runat="server"></asp:TextBox>
            </br>
            <asp:TextBox ID="txtSub1" runat="server"></asp:TextBox>
            <asp:Label ID="lbl2" runat="server" Text="-"></asp:Label>
            <asp:TextBox ID="txtSub2" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="="></asp:Label>
            <asp:TextBox ID="txtResultSub" runat="server"></asp:TextBox>
            </br>
            <asp:TextBox ID="txtV1" runat="server"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="/"></asp:Label>
            <asp:TextBox ID="txtV2" runat="server"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Text="="></asp:Label>
            <asp:TextBox ID="txtResulMult" runat="server"></asp:TextBox>
            </br>
            <asp:TextBox ID="txtDividendo" runat="server"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="*"></asp:Label>
            <asp:TextBox ID="txtDivisor" runat="server"></asp:TextBox>
            <asp:Label ID="Label7" runat="server" Text="="></asp:Label>
            <asp:TextBox ID="txtresultDiv" runat="server"></asp:TextBox>
            </br>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
