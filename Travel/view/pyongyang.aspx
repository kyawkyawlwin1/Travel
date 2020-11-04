<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pyongyang.aspx.cs" Inherits="Travel.view.pyongyang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Visit Place Form</legend>
            <div>
                <label for="txtVisitPlaceName">Visit Place :</label>
                <asp:TextBox ID="txtVisitPlaceName" placeholder="Visit Place Name" runat="server"></asp:TextBox>
                <br />
            </div>
            <div>
                <label for="txtVisitPlaceDesc">About that Place</label>
                <br />
                <asp:TextBox ID="txtVisitPlaceDesc" placeholder="Tap to enter" runat="server" TextMode="MultiLine" Height="250px" Width="250px"></asp:TextBox>
                <br />
            </div>

            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </fieldset>


    </form>
</body>
</html>
