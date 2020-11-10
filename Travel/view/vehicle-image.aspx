<%@ Page Title="" Language="C#" MasterPageFile="~/view/default.Master" AutoEventWireup="true" CodeBehind="vehicle-image.aspx.cs" Inherits="Travel.view.vehicle_image" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset>
    <h4>Vehicle Image</h4>
    <div>
        <label for="ddlVisitPlaceName">Visit Place :</label>
        <asp:DropDownList ID="ddlVisitPlaceName" runat="server" AutoPostBack="true"></asp:DropDownList>
        <br />
    </div>
    <div>
        <asp:FileUpload ID="imgVehicle" runat="server" />
    </div>
    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"/>
        </fieldset>
</asp:Content>
