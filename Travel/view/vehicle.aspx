<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vehicle.aspx.cs" Inherits="Travel.view.vehicle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Vehicle Form</legend>
            <div>
                <label for="ddlVisitPlaceName">Visit Place :</label>
                <asp:DropDownList ID="ddlVisitPlaceName" runat="server" AutoPostBack="true"></asp:DropDownList>
                <br />
            </div>
            <div>
                <label for="txtVehicleName">Vehicle Name : </label>
                <asp:TextBox ID="txtVehicleName" placeholder="Vehicle Name" runat="server"></asp:TextBox>
                <br />
            </div>
            <div>
                <label for="txtVehicleDesc">Kind Of Vehicles</label>
                <br />
                <asp:TextBox ID="txtVehicleDesc" placeholder="Tap to enter" TextMode="MultiLine" runat="server" Height="250px" Width="750px"></asp:TextBox>
                <br />
            </div>

            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </fieldset>

    </form>
</body>
</html>
