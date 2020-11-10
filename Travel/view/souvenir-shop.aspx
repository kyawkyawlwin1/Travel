
<%@ Page Title="" Language="C#" MasterPageFile="~/view/default.Master" AutoEventWireup="true" CodeBehind="souvenir-shop.aspx.cs" Inherits="Travel.view.souvenir_shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        <fieldset>
            <legend>Souvenir Shop Form</legend>
            <div>
                <label for="ddlVisitPlaceName">Visit Place :</label>
                <asp:DropDownList ID="ddlVisitPlaceName" runat="server" AutoPostBack="true"></asp:DropDownList>
                <br />
            </div>
            <div>
                <label for="txtSouvenirShopName">Souvenir Shop Name : </label>
                <asp:TextBox ID="txtSouvenirShopName" placeholder="Souvenir Shop Name" runat="server"></asp:TextBox>
                <br />
            </div>
            <div>
                <label for="txtSouvenirShopDesc">What kind of souvenir things are available in that shop? </label>
                <br />
                <asp:TextBox ID="txtSouvenirShopDesc" placeholder="Tap to enter" TextMode="MultiLine" runat="server" Height="250px" Width="750px"></asp:TextBox>
                <br />
            </div>

            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </fieldset>

</asp:Content>