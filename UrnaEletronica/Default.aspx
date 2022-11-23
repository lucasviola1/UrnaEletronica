<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UrnaEletronica._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div style="text-align:center">
    <span style="font-size:25px;" >Candidatos</span>
        </div>
    <div style="text-align: center">
        <span style="margin-right: 1rem">Jimmy Neutron - 45</span>
        <span style="margin-right: 1rem">Sheen - 35</span>
        <span>Caio - 25</span>
    </div>
    <div style="text-align: center !important; margin-top: 2rem;">
        <asp:TextBox ID="FirstNumber" MaxLength="1"
            runat="server" placeholder="Digite o primeiro numero"/>
        <asp:TextBox ID="SecondNumber" MaxLength="1"
            runat="server"  placeholder="Digite o segundo numero"/>
    </div>
    <br />
    <div style="text-align: center; margin-bottom: 2rem">
        <asp:Button CssClass="btn btn-primary" ID="b1" Text="Exibir Candidato" runat="server" OnClick="b1_Click" />
        <asp:Button CssClass="btn btn-success" ID="btnVotar" Text="Confirmar" runat="server" OnClick="btnVotar_Click" />
    </div>
    <div style="text-align: center">
        <asp:Image BorderStyle="Dashed" runat="server" ID="foto" />
    </div>
    <br />
    <div style="text-align: center">
        <span>Candidato: </span>
        <asp:Label ID="lblNome"
            Text=""
            runat="server" />
        <br />
        <span>Partido: </span>
        <asp:Label ID="lblPartido"
            Text=""
            runat="server" />
        <br />
        <asp:Label ID="lblTexto"
            Text=""
            runat="server" />
    </div>
</asp:Content>
