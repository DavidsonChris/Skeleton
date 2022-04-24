<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblphoneID" runat="server" Text="PhoneID" width="108px"></asp:Label>
        <asp:TextBox ID="txtphoneID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblphoneName" runat="server" Text="Phone Name" width="108px"></asp:Label>
        <asp:TextBox ID="txtphoneName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="108px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblreleaseDate" runat="server" Text="Release Date" width="108px"></asp:Label>
        <asp:TextBox ID="txtreleaseDate" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblphoneColour" runat="server" Text="Phone Colour" width="108px"></asp:Label>
        <asp:TextBox ID="txtphoneColour" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkAvailability" runat="server" Text="Availability" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
