<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Lab1_Part3_DillonKrein.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
    <!--
Dillon Krein
2-11-2022
Asp code for landing page of application, two buttons to navigate
-->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    &emsp;&emsp;&emsp; <asp:Button BackColor="#9900ff" ID="ScholarshipPage" runat="server" Text="Scholarship Page" OnClick="ScholarshipPage_Click" Height="100px" Width="200px" ForeColor="White"
         BorderStyle="Double" Font-Size="X-Large" Font-Italic="true"/>
    &emsp;<asp:Button BackColor="#9900ff" ID="StudentPage" runat="server" Text="Student Page" OnClick="StudentPage_Click" Height="100px" Width="200px" ForeColor="White" 
         BorderStyle="Double" Font-Size="X-Large" Font-Italic="true"/>
    </asp:Content>
