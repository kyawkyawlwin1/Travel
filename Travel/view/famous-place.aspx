<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="famous-place.aspx.cs" Inherits="Travel.view.famous_place" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Famous Place Form</legend>
            <div>
                <label for="ddlVisitPlaceName">Visit Place :</label>
                <asp:DropDownList ID="ddlVisitPlaceName" runat="server" AutoPostBack="true"></asp:DropDownList>
                <br />
            </div>
            <div>
                <label for="txtFamousPlaceName">Famous Place : </label>
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


    </form>
</body>
</html>
