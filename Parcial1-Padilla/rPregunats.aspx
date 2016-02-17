<%@ Page Title="" Language="C#" MasterPageFile="~/MasterP.Master" AutoEventWireup="true" CodeBehind="rPregunats.aspx.cs" Inherits="Parcial1_Padilla.rPregunats" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
 
     <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
        <Items>
            <asp:MenuItem Text="Inicio" Value="Inicio"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/cPregunats.aspx" Text="Consultar pregunats" Value="Consultar pregunats"></asp:MenuItem>
        </Items>
    </asp:Menu>
    <br />
         <label class="control-label col-xs-3">Pregunta Id:</label>
        <div class="col-xs-9">
            <asp:TextBox ID="PreguntaIdTextBox" class="form-control" placeholder="PreguntaId" runat="server"></asp:TextBox>
        </div>
    <div class="form-group">
        <label class="control-label col-xs-3">Fecha:</label>
        <div class="col-xs-9">
            <asp:TextBox ID="FechaTextBox" class="form-control" placeholder="Fecha" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label class="control-label col-xs-3">Descipcion:</label>
        <div class="col-xs-9">
            <asp:TextBox ID="DescripcionTextBox" class="form-control" placeholder="Descripcion" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label class="control-label col-xs-3">Respuestas posibles:</label>
        <div class="col-xs-9">
            <asp:TextBox ID="RespuestasTextBox" class="form-control" placeholder="Respuestas Posibles" runat="server"></asp:TextBox>
        </div>
    </div>
           
    <div class="form-group">
        <div class="col-xs-offset-3 col-xs-9">
            <asp:Button ID="BuascarButton" type="submit" class="btn btn-primary" runat="server" OnClick="BuascarButton_Click" Text="Buascar" />
            <asp:Button ID="Button1" type="submit" CssClass="btn btn-primary"  runat="server" OnClick="NuevoButton_Click" Text="Nuevo" />
<asp:Button ID="Button2" type="submit" CssClass="btn btn-primary"  runat="server" OnClick="GuardarButton_Click" Text="Guardar" />
<asp:Button ID="Button3" type="submit" CssClass="btn btn-primary"  runat="server" OnClick="EliminarButton_Click" Text="Eliminar" />
        </div>
    </div>


     
</asp:Content>
