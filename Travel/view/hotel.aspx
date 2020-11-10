
<%@ Page Title="" Language="C#" MasterPageFile="~/view/default.Master" AutoEventWireup="true" CodeBehind="hotel.aspx.cs" Inherits="Travel.view.hotel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        <fieldset>
            <legend>Hotel Form</legend>
            <div>
                <label for="ddlVisitPlace">Visit Place :</label>
                <asp:DropDownList ID="ddlVisitPlaceName" AutoPostBack="true" runat="server"></asp:DropDownList>
                <br />
            </div>
            <div>
                <label for="txtHotelName">Hotel Name :</label>
                <asp:TextBox ID="txtHotelName" placeholder="Hotel Name" runat="server"></asp:TextBox>
                <br />
            </div>
            <div>
                <label for="txtHotelDesc">About That Hotel</label>
                <br />
                <asp:TextBox ID="txtHotelDesc" placeholder="Tap to enter" runat="server" TextMode="MultiLine" Height="250px" Width="750px"></asp:TextBox>
                <br />
            </div>
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </fieldset>

</asp:Content>