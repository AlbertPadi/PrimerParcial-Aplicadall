<%@ Page Title="" Language="C#" MasterPageFile="~/MasterP.Master" AutoEventWireup="true" CodeBehind="cPregunats.aspx.cs" Inherits="Parcial1_Padilla.cPregunats" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Listar por<asp:TextBox ID="DatosTextBox" runat="server" Width="138px"></asp:TextBox>
    De<asp:TextBox ID="DeTextBox" runat="server"></asp:TextBox>
    Hasta<asp:TextBox ID="HastaTextBox" runat="server"></asp:TextBox>
    <asp:Button ID="BuascarButton" runat="server" OnClick="BuascarButton_Click" Text="Buascar" Width="91px" />
    <asp:GridView ID="DatosGridView" runat="server" Width="707px">
    </asp:GridView>
</asp:Content>
