<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="VehicleValLab" runat="server" Text="Vehicle Value" Height="30px" Width="80px"></asp:Label>
    <asp:TextBox ID="VehichleVal" runat="server" Height="30px" Width="80px"></asp:TextBox>

    <asp:Label ID="Comp3rdLab" runat="server" Text="Comprehensive/third party" Height="30px" Width="80px"></asp:Label>
    <asp:TextBox ID="Comp3rd" runat="server" Height="30px" Width="80px"></asp:TextBox>

      <asp:Label ID="DOBLab" runat="server" Text="Date Of Birth" Height="30px" Width="80px"></asp:Label>
    <asp:TextBox ID="DOB" runat="server" Height="30px" Width="80px"></asp:TextBox>

      <asp:Label ID="PenPLab" runat="server" Text="Penalty Points" Height="30px" Width="80px"></asp:Label>
    <asp:TextBox ID="PenP" runat="server" Height="30px" Width="80px"></asp:TextBox>

    <asp:Button ID="Button2" runat="server" Height="30px" Width="100px" OnClick="Button1_Click" Text="Button" />
    <asp:Label ID="ResultLab" runat="server" Text="Result" Height="30px" Width="180px"></asp:Label>
</asp:Content>

