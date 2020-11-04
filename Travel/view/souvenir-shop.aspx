<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="souvenir-shop.aspx.cs" Inherits="Travel.view.souvenir_shop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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

    </form>
</body>
</html>
