<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="foodandbeverage.aspx.cs" Inherits="Travel.view.foodandbeverage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Food & Beverage Form</legend>
            <div>
                <label for="ddlVisitPlaceName">Visit Place :</label>
                <asp:DropDownList ID="ddlVisitPlaceName" runat="server" AutoPostBack="true"></asp:DropDownList>
                <br />
            </div>
            <div>
                <label for="txtFnBName">Famous Place : </label>
                <asp:TextBox ID="txtFnBName" placeholder="Name" runat="server"></asp:TextBox>
                <br />
            </div>
            <div>
                <label for="txtFnBDesc">About That Place</label>
                <br />
                <asp:TextBox ID="txtFnBDesc" placeholder="Tap to enter" TextMode="MultiLine" runat="server" Height="250px" Width="750px"></asp:TextBox>
                <br />
            </div>
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </fieldset>


    </form>
</body>
</html>
