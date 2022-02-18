<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentPage.aspx.cs" Inherits="Lab1_Part3_DillonKrein.StudentPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--
Dillon Krein
2-11-2022
Asp code for textboxes and labels for the add student page. Buttons on the bottom
-->
    <style type="text/css">

        fieldset{
            display:inline-flex;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div runat="server">
        <asp:Label ID="TxtAddStudent" runat="server" Text="Add a Student" Font-Bold="true" Font-Size="150%" ForeColor="DarkViolet"></asp:Label>
        <br />
        <fieldset>         
            <asp:Table ID="TblCreateStudent" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LblFirstName" runat="server" Text="Enter Firstname"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtFirstName" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"
                            ControlToValidate="TxtFirstName" ForeColor="Red" Text="(First Name is a Required field)">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LblLastName" runat="server" Text="Enter Lastname"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtLastName" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator"
                            ControlToValidate="TxtLastName" ForeColor="Red" Text="(Last Name is a Required field)">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LblEmail" runat="server" Text="Enter Email"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator"
                            ControlToValidate="TxtEmail" ForeColor="Red" Text="(Email is a Required field)">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LblPhoneNumber" runat="server" Text="Enter Phone Number"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtPhoneNumber" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator"
                            ControlToValidate="TxtPhoneNumber" ForeColor="Red" Text="(Phone Number is a required field)">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LblGradYear" runat="server" Text="Enter Expected Graduation Year"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtGradYear" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator"
                            ControlToValidate="TxtGradYear" ForeColor="Red" Text="(Expected graduation year is a required field)">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LblMajor" runat="server" Text="Enter Major"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtMajor" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator"
                            ControlToValidate="TxtMajor" ForeColor="Red" Text="(Major is a required field)">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LblUniYear" runat="server" Text="Enter University Year"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtUniYear" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="RequiredFieldValidator"
                            ControlToValidate="TxtUniYear" ForeColor="Red" Text="(University year is a required field)">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LblInternStatus" runat="server" Text="Enter Internship Status"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtInternStatus" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="RequiredFieldValidator"
                            ControlToValidate="TxtInternStatus" ForeColor="Red" Text="(Internship status is a required field)">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LblEmpStatus" runat="server" Text="Enter Employment Status"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtEmpStatus" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="RequiredFieldValidator"
                            ControlToValidate="TxtEmpStatus" ForeColor="Red" Text="(Employment status is a required field)">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            </fieldset>
        <br />
            &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;<asp:DropDownList ID="DdlStudent" runat="server" OnSelectedIndexChanged="DdlStudent_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
           
            <br />
            <asp:Button ID="BtnTestData" runat="server" Text="Populate" OnClick="BtnTestData_Click" CausesValidation="false" />            
            <br />
            <asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" />
            <br />
            <asp:Button ID="BtnComit" runat="server" Text="Commit" OnClick="BtnComit_Click" />
            <br />            
            <asp:Button ID="BtnClear" runat="server" Text="Clear" OnClick="BtnClear_Click" CausesValidation="false" />        
    </div>
</asp:Content>
