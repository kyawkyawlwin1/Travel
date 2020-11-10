<%@ Page Title="" Language="C#" MasterPageFile="~/view/default.Master" AutoEventWireup="true" CodeBehind="famous-place.aspx.cs" Inherits="Travel.view.famous_place" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <fieldset>
            <legend>Famous Place Form</legend>
    <div>
        <label>Visit Place Name :</label>
        <asp:DropDownList ID="ddlVisitPlaceName" runat="server" AutoPostBack="true"></asp:DropDownList>
        <br />
    </div>

    <div>
        <label for="txtFamousPlaceName">Famous Place Name :</label>
        <asp:TextBox ID="txtFamousPlaceName" placeholder="Famous Place Name" runat="server"></asp:TextBox>
        <br />
    </div>
    <div>
        <label for="txtFamousPlaceDesc">About That Place</label>
        <br />
        <asp:TextBox ID="txtFamousPlaceDesc" placeholder="Tap to enter" TextMode="MultiLine" runat="server" Height="250px" Width="750px"></asp:TextBox>
        <br />
    </div>
        
    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </fieldset>



</asp:Content>
