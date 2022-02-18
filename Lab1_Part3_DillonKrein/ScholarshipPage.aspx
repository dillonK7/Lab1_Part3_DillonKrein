<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ScholarshipPage.aspx.cs" Inherits="Lab1_Part3_DillonKrein.ScholarshipPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<!--
Dillon Krein
2-11-2022
Asp code for textboxes and labels for the add scholarship page. Buttons on the bottom
-->

    <style type="text/css">

        fieldset{
            display:inline-flex;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div runat="server">
            <asp:Label ID="TxtAddScholar" runat="server" Text="Add a SCholarship" Font-Bold="true" Font-Size="150%" ForeColor="DarkViolet"></asp:Label>
        <br />
            <fieldset>
                <asp:Table ID="TblCreateScholarship" runat="server">
                    <asp:TableRow>
                        <asp:TableCell><asp:Label ID="LblScholarshipName" runat="server" Text="Enter Scholarship Name"></asp:Label></asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="TxtScholarName" runat="server"></asp:TextBox></asp:TableCell>
                        <asp:TableCell> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" 
                            ControlToValidate="TxtScholarName" ForeColor="Red" Text="(Scholarship Name is a Required field)" ></asp:RequiredFieldValidator></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell><asp:Label ID="LblSCholarYear" runat="server" Text="Enter Scholarship Year"></asp:Label></asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="TxtScholarYear" runat="server"></asp:TextBox></asp:TableCell>
                        <asp:TableCell> <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" 
                            ControlToValidate="TxtSCholarYear" ForeColor="Red" Text="(Scholarship Year is a Required field)" ></asp:RequiredFieldValidator></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell><asp:Label ID="LblScholarAmount" runat="server" Text="Enter Scholarship Amount"></asp:Label></asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="TxtScholarAmount" runat="server"></asp:TextBox></asp:TableCell><asp:TableCell> 
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" 
                            ControlToValidate="TxtScholarAmount" ForeColor="Red" Text="(Scholarship Amount is a Required field)" ></asp:RequiredFieldValidator></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell><asp:Label ID="LblCoordName" runat="server" Text="Enter Coordinator Name"></asp:Label></asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="TxtCoordName" runat="server"></asp:TextBox></asp:TableCell><asp:TableCell> 
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" 
                            ControlToValidate="TxtCoordName" ForeColor="Red" Text="(Coordinator Name is a Required field)" ></asp:RequiredFieldValidator></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                </fieldset>
            <br />
            &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;<asp:DropDownList ID="DdlScholarship" runat="server" OnSelectedIndexChanged="DdlScholarship_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            <br />                
            <asp:Button ID="BtnPopulate" runat="server" Text="Populate" OnClick="BtnPopulate_Click" CausesValidation="false" />
            <br />   
            <asp:Button ID="BtnSvae" runat="server" Text="Save" OnClick="BtnSave_Click"/>
            <br />
                <asp:Button ID="BtnCommit" runat="server" Text="Commit" OnClick="BtnCommit_Click" />
            <br />              
                <asp:Button ID="BtnClear" runat="server" Text="Clear" OnClick="BtnClear_Click" CausesValidation="false"/>            
        </div>
 </asp:content>
