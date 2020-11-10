
<%@ Page Title="" Language="C#" MasterPageFile="~/view/default.Master" AutoEventWireup="true" CodeBehind="hospital-clinic.aspx.cs" Inherits="Travel.view.hospital_clinic" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        <fieldset>
            <legend>Hospital / Clinic Form</legend>
            <div>
            <label for="ddlVisitPlaceName">Visit Place :</label>
            <asp:DropDownList ID="ddlVisitPlaceName" runat="server" AutoPostBack="true"></asp:DropDownList>
            <br />
        </div>
        <div>
            <label for="txtHorCName">Hospital / Clinic Name : </label>
            <asp:TextBox ID="txtHorCName" placeholder="H / C Name" runat="server"></asp:TextBox>
            <br />
        </div>
        <div>
            <label for="txtHorCDesc">About that Hospital / Clinic</label>
            <br />
            <asp:TextBox ID="txtHorCDesc" placeholder="Tap to enter" TextMode="MultiLine" runat="server" Height="250px" Width="750px"></asp:TextBox>
            <br />
        </div>

        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </fieldset>
        

</asp:Content>