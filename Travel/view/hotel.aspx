<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hotel.aspx.cs" Inherits="Travel.view.hotel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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

    </form>
</body>
</html>
